using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CCaC.Data;
using CCaC.Models;

namespace CCaC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WestsController : ControllerBase
    {
        private readonly CCaCDbContext _context;

        public WestsController(CCaCDbContext context)
        {
            _context = context;
        }

        // GET: api/Wests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<West>>> GetWest_1()
        {
            return await _context.West_1.ToListAsync();
        }

        // GET: api/Wests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<West>> GetWest(int id)
        {
            var west = await _context.West_1.FindAsync(id);

            if (west == null)
            {
                return NotFound();
            }

            return west;
        }

        // PUT: api/Wests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWest(int id, West west)
        {
            if (id != west.Id)
            {
                return BadRequest();
            }

            _context.Entry(west).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WestExists(id))
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

        // POST: api/Wests
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<West>> PostWest(West west)
        {
            _context.West_1.Add(west);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWest", new { id = west.Id }, west);
        }

        // DELETE: api/Wests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<West>> DeleteWest(int id)
        {
            var west = await _context.West_1.FindAsync(id);
            if (west == null)
            {
                return NotFound();
            }

            _context.West_1.Remove(west);
            await _context.SaveChangesAsync();

            return west;
        }

        private bool WestExists(int id)
        {
            return _context.West_1.Any(e => e.Id == id);
        }
    }
}
