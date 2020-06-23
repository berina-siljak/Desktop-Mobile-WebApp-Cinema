using AutoMapper;
using Kino.Model.Requests;
using Kino.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public interface IKupciService
    {
        List<Model.Kupci> Get(KupciSearchRequest request);

        Model.Kupci GetById(int id);

        Model.Kupci Insert(KupciInsertRequest request);

        Model.Kupci Update(int id, KupciInsertRequest request);

        Model.Kupci AuthenticirajKupca(string username, string pass);

    }
}
