using Labb4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Services
{
    public class PersonRepository : IPersonRepository<Person>
    {
        private AppDbContext _personRepo;
        public PersonRepository(AppDbContext personContext)
        {
            _personRepo = personContext;
        }

        public async Task<IEnumerable<Person>> GetLinks(int id)
        {
            return (IEnumerable<Person>)await _personRepo.Persons
                .Include(p => p.website)
                .Where(p => p.PersonID == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Person>> GetPersons()
        {
            return await _personRepo.Persons.ToListAsync();
        }

        public async Task<IEnumerable<Person>> GetPersonsInterests(int id)
        {
            return await _personRepo.Persons
                .Include(p => p.interests)
                .Where(p => p.PersonID == id)
                .ToListAsync();
        }

    }
}
