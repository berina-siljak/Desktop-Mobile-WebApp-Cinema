using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Services
{
    public interface IPreporukeService
    {
        List<Filmovi> GetPreporuka(int id);
    }
}
