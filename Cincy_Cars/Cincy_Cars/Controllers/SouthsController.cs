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
    public class SouthsController : ControllerBase
    {
        private readonly CCACDbContext _context;

        public SouthsController(CCACDbContext context)
        {
            _context = context;
        }

        // GET: api/Souths
        [HttpGet]
        public async Task<ActionResult<IEnumerable<South>>> GetSouth()
        {
            return await _context.South.ToListAsync();
        }

        // GET: api/Souths/5
        [HttpGet("{id}")]
        public async Task<ActionResult<South>> GetSouth(int id)
        {
            var south = await _context.South.FindAsync(id);

            if (south == null)
            {
                return NotFound();
            }

            return south;
        }

        // PUT: api/Souths/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSouth(int id, South south)
        {
            if (id != south.Id)
            {
                return BadRequest();
            }

            _context.Entry(south).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SouthExists(id))
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

        // POST: api/Souths
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<South>> PostSouth(South south)
        {
            _context.South.Add(south);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSouth", new { id = south.Id }, south);
        }

        // DELETE: api/Souths/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<South>> DeleteSouth(int id)
        {
            var south = await _context.South.FindAsync(id);
            if (south == null)
            {
                return NotFound();
            }

            _context.South.Remove(south);
            await _context.SaveChangesAsync();

            return south;
        }

        private bool SouthExists(int id)
        {
            return _context.South.Any(e => e.Id == id);
        }
    }
}
