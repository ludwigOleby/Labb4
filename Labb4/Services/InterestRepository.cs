using Labb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Labb4.Services
{
    public class InterestRepository : IInterestRepository<Interests>
    {
        private AppDbContext _interestRepo;
        public InterestRepository(AppDbContext interestContext)
        {
            _interestRepo = interestContext;
        }
        public async Task<Interests> GetInterest(int id)
        {
            return await _interestRepo.Interests.FirstOrDefaultAsync(i => i.interestID == id);
        }

        public async Task<Interests> updateInterest(Interests newInterest)
        {
            var result = await _interestRepo.Interests.FirstOrDefaultAsync(o => o.interestID == newInterest.interestID);
            if (result != null)
            {
                result.interestName = newInterest.interestName;
                result.details = newInterest.details;

                await _interestRepo.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
