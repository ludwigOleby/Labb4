using Labb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Labb4.Services
{
    public class WebsiteRepository : IWebsiteRepository<Websites>
    {
        private AppDbContext _webRepo;
        public WebsiteRepository(AppDbContext websiteContext)
        {
            _webRepo = websiteContext;
        }

        public async Task<Websites> AddLinks(Websites newWeb)
        {
            var result = await _webRepo.websites.AddAsync(newWeb);
            await _webRepo.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Websites> GetWebsite(int id)
        {
            return await _webRepo.websites.Include(w => w.persons.website).FirstOrDefaultAsync(w => w.WebpageID == id);
        }
    }
}
