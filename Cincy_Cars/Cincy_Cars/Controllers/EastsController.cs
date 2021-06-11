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
    public class EastsController : ControllerBase
    {
        private readonly CCACDbContext _context;

        public EastsController(CCACDbContext context)
        {
            _context = context;
        }

        // GET: api/Easts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<East>>> GetEast()
        {
            return await _context.East.ToListAsync();
        }

        // GET: api/Easts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<East>> GetEast(int id)
        {
            var east = await _context.East.FindAsync(id);

            if (east == null)
            {
                return NotFound();
            }

            return east;
        }

        // PUT: api/Easts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEast(int id, East east)
        {
            if (id != east.Id)
            {
                return BadRequest();
            }

            _context.Entry(east).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EastExists(id))
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

        // POST: api/Easts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<East>> PostEast(East east)
        {
            _context.East.Add(east);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEast", new { id = east.Id }, east);
        }

        // DELETE: api/Easts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<East>> DeleteEast(int id)
        {
            var east = await _context.East.FindAsync(id);
            if (east == null)
            {
                return NotFound();
            }

            _context.East.Remove(east);
            await _context.SaveChangesAsync();

            return east;
        }

        private bool EastExists(int id)
        {
            return _context.East.Any(e => e.Id == id);
        }
    }
}
