using Labb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Services
{
    public interface IWebsiteRepository<T>
    {
        //Lägga in nya länkar för en specifik person och ett specifikt intresse
        Task<T> AddLinks(Websites newWeb);
        Task<T> GetWebsite(int id);
    }
}
