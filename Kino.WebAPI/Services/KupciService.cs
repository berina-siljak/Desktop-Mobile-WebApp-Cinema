using AutoMapper;
using Kino.Model.Requests;
using Kino.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public class KupciService : IKupciService
    {
        private readonly KinoContext _context;
        private readonly IMapper _mapper;
        public KupciService(KinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Model.Kupci AuthenticirajKupca(string username, string pass)
        {
            var user = _context.Kupci.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Kupci>(user);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }

        public List<Model.Kupci> Get(KupciSearchRequest search)
        {
            var query = _context.Kupci.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime) || x.Ime.ToUpper().StartsWith(search.Ime));

            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime) || x.Prezime.ToUpper().StartsWith(search.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.ToLower().StartsWith(search.KorisnickoIme) || x.KorisnickoIme.ToUpper().StartsWith(search.KorisnickoIme));

            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Kupci>>(list);
        }

        public Model.Kupci GetById(int id)
        {
            var entity = _context.Kupci.Find(id);

            return _mapper.Map<Model.Kupci>(entity);
        }


        public Model.Kupci Insert(KupciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Kupci>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Kupci.Add(entity);
            _context.SaveChanges();

           
            var kupac = new Model.Kupci()
            {
                Ime = request.Ime,
                Prezime = request.Prezime,
                KorisnickoIme = request.KorisnickoIme,
                Email = request.Email,
                Telefon = request.Telefon,
                BrojTokena = request.BrojTokena,
               
    };
          
            _context.SaveChanges();

            // return _mapper.Map<Model.Kupac>(entity);
            return kupac;
        }

        public Model.Kupci Update(int id, KupciInsertRequest request)
        {
            var entity = _context.Kupci.Find(id);
            _context.Kupci.Attach(entity);
            _context.Kupci.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(entity);
        }
    }
}
