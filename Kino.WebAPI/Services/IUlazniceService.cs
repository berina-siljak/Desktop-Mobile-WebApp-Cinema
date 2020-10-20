using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public interface IUlazniceService
    {
    
        List<Model.Ulaznice> Get(UlazniceSearchRequest request);
        Model.Ulaznice Insert(UlazniceInsertRequest request, string baseUrl);
        Model.Ulaznice ProvjeraUlaznice(int ulaznicaID);
        Model.Ulaznice Delete(int id);
        Model.Ulaznice GetById(int id);

        Model.Ulaznice Update(int id, UlazniceInsertRequest request);


    }
}
