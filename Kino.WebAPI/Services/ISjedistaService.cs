using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public interface ISjedistaService
    {
        List<Model.Sjedista> Insert(SjedistaInsertRequest request);
        List<Model.Sjedista> Get(SjedistaSearchRequest request);

        //Model.Sjedista GetById(int id);

        //Model.Sjedista Insert(SjedistaInsertRequest request);

        //Model.Sjedista Update(int id, SjedistaInsertRequest request);
    }
}
