using Labb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Services
{
    public interface IInterestRepository<T>
    {

        //Koppla en person till ett nytt intresse
        Task<T> updateInterest(Interests newInterest);

        // Get single för att kunna köra "Add interests" metoden
        Task<T> GetInterest(int id);

    }
}
