using AutoMapper;
using Kino.Model;
using Kino.Model.Requests;
using Kino.WebAPI.EF;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Kino.WebAPI.Services
{
    public class UlazniceService : IUlazniceService
    {
        private readonly KinoContext _context;
        private readonly IMapper _mapper;
        public UlazniceService(KinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Ulaznice> Get(UlazniceSearchRequest search)
        {
            var q = _context.Set<Database.Ulaznice>().Include(x => x.Sjediste).Include(x => x.Projekcija.Film).Include(x => x.Projekcija.Sala).Include(x => x.Kupac).AsQueryable();

            if (search?.KupacID.HasValue == true)
            {
                q = q.Where(s => s.Kupac.KupacID == search.KupacID);
            }

            if (!String.IsNullOrEmpty(search?.ImeKupca))
            {
                q = q.Where(s => s.Kupac.Ime.Contains(search.ImeKupca));
            }

            if (search?.ProjekcijaID.HasValue == true)
            {
                q = q.Where(s => s.ProjekcijaID == search.ProjekcijaID);
            }
            if (search?.Godina.HasValue == true)
            {
                q = q.Where(s => s.Datum.Year == search.Godina);
            }
            if (search?.SjedisteID.HasValue == true)
            {
                q = q.Where(s => s.Sjediste.SjedisteID == search.SjedisteID);
            }

            //if(search?.DatumOd.HasValue== true && search.DatumDo.HasValue==true)
            //{
            //    q = q.Where(s => s.Datum >= search.DatumOd && s.Datum <= search.DatumDo);
            //}

            //if(search?.Min !=null)
            //{
            //    q = q.Where(s => s.CijenaSaPopustom >= search.Min);
            //}

            var list = q.ToList();
            return _mapper.Map<List<Ulaznice>>(list);
        }
        public Ulaznice Insert(UlazniceInsertRequest request, string baseUrl)
        {
            var entity = _mapper.Map<Database.Ulaznice>(request);
            _context.Add(entity);
            _context.SaveChanges();

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(baseUrl+"api/Ulaznice/Provjera/" + entity.UlaznicaID, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);

            Bitmap qrCodeImage = code.GetGraphic(10);
            var bitmapBytes = BitmapToBytes(qrCodeImage);
            entity.BarCodeIMG = bitmapBytes;

            _context.SaveChanges();

            return _mapper.Map<Model.Ulaznice>(entity);
        }

        public Ulaznice ProvjeraUlaznice(int ulaznicaId)
        {
            var entity = _context.Set<Database.Ulaznice>().Include(x => x.Sjediste).Include(x => x.Projekcija.Film).Include(x => x.Projekcija.Sala).Include(x => x.Kupac).FirstOrDefault(x => x.UlaznicaID == ulaznicaId);
            return _mapper.Map<Model.Ulaznice>(entity);
        }

        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        public Model.Ulaznice Delete(int id)
        {
            var entity = _context.Ulaznice.Find(id);

            _context.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Ulaznice>(entity);
        }
        public Model.Ulaznice GetById(int id)
        {
            var entity = _context.Set<Database.Ulaznice>().Include(x => x.Projekcija).FirstOrDefault(x => x.UlaznicaID == id);
            return _mapper.Map<Model.Ulaznice>(entity);
        }
        public Model.Ulaznice Update(int id, UlazniceInsertRequest request)
        {
            var entity = _context.Ulaznice.Find(id);
            _context.Ulaznice.Attach(entity);
            _context.Ulaznice.Update(entity);

    

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Ulaznice>(entity);
        }
    }
}
