using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsManagementMicroService.Data;
using NewsManagementMicroService.Models;

namespace NewsManagementMicroService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsGroupsController : ControllerBase
    {
        private readonly NewsManagementMicroServiceContext _context;

        public NewsGroupsController(NewsManagementMicroServiceContext context)
        {
            _context = context;
        }

        // GET: api/NewsGroups/GetNewsGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsGroup>>> GetNewsGroups()
        {
            return await _context.NewsGroups.ToListAsync();
        }

        // GET: api/NewsGroups/GetNewsGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewsGroup>> GetNewsGroupById(int id)
        {
            var newsGroup = await _context.NewsGroups.FindAsync(id);

            if (newsGroup == null)
            {
                return NotFound();
            }

            return newsGroup;
        }

        // GET: api/NewsGroups/GetNewsGroupByName/5
        [HttpGet("{name}")]
        public async Task<ActionResult<NewsGroup>> GetNewsGroupByName(string name)
        {
            var newsGroup = await _context.NewsGroups.FirstOrDefaultAsync(a => a.GroupTitle.Equals(name));

            if (newsGroup == null)
            {
                return NotFound();
            }

            return newsGroup;
        }

        // PUT: api/NewsGroups/PutNewsGroup/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewsGroup(int id, NewsGroup newsGroup)
        {
            if (id != newsGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(newsGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsGroupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/NewsGroups/PostNewsGroup
        [HttpPost]
        public async Task<ActionResult<NewsGroup>> PostNewsGroup(NewsGroup newsGroup)
        {
            _context.NewsGroups.Add(newsGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewsGroup", new { id = newsGroup.Id }, newsGroup);
        }

        // DELETE: api/NewsGroups/DeleteNewsGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NewsGroup>> DeleteNewsGroup(int id)
        {
            var newsGroup = await _context.NewsGroups.FindAsync(id);
            if (newsGroup == null)
            {
                return NotFound();
            }

            _context.NewsGroups.Remove(newsGroup);
            await _context.SaveChangesAsync();

            return newsGroup;
        }

        private bool NewsGroupExists(int id)
        {
            return _context.NewsGroups.Any(e => e.Id == id);
        }
    }
}
