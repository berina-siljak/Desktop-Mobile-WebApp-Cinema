using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
   
        public interface IKorisniciService
        {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);

        Model.Korisnici GetById(int id);

        Model.Korisnici Insert(KorisniciInsertRequest request);

        Model.Korisnici Update(int id, KorisniciInsertRequest request);

        Model.Korisnici Login(KorisniciLoginRequest request);
        Model.Korisnici LoginKupca(KorisniciLoginRequest request);
    }
    
}
