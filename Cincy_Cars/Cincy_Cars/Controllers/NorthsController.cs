using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cincy_Cars;
using Cincy_Cars.Models;

namespace Cincy_Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthsController : ControllerBase
    {
        private readonly CCACDbContext _context;

        public NorthsController(CCACDbContext context)
        {
            _context = context;
        }

        // GET: api/Norths
        [HttpGet]
        public async Task<ActionResult<IEnumerable<North>>> GetNorth()
        {
            return await _context.North.ToListAsync();
        }

        // GET: api/Norths/5
        [HttpGet("{id}")]
        public async Task<ActionResult<North>> GetNorth(int id)
        {
            var north = await _context.North.FindAsync(id);

            if (north == null)
            {
                return NotFound();
            }

            return north;
        }

        // PUT: api/Norths/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNorth(int id, North north)
        {
            if (id != north.Id)
            {
                return BadRequest();
            }

            _context.Entry(north).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NorthExists(id))
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

        // POST: api/Norths
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<North>> PostNorth(North north)
        {
            _context.North.Add(north);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNorth", new { id = north.Id }, north);
        }

        // DELETE: api/Norths/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<North>> DeleteNorth(int id)
        {
            var north = await _context.North.FindAsync(id);
            if (north == null)
            {
                return NotFound();
            }

            _context.North.Remove(north);
            await _context.SaveChangesAsync();

            return north;
        }

        private bool NorthExists(int id)
        {
            return _context.North.Any(e => e.Id == id);
        }
    }
}
