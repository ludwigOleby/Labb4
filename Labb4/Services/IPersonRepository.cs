using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb4.Models;

namespace Labb4.Services
{
    public interface IPersonRepository<T>
    {
        //Hämta alla personer i systemet
        Task<IEnumerable<T>> GetPersons();

        //Hämta alla intressen som är kopplade till en specifik person
        Task<IEnumerable<T>> GetPersonsInterests(int PersonID);

        //Hämta alla länkar som är kopplade till en specifik person
        Task<IEnumerable<T>> GetLinks(int personID);

       

    }
}
