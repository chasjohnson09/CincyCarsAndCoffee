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
    public class DowntownsController : ControllerBase
    {
        private readonly CCaCDbContext _context;

        public DowntownsController(CCaCDbContext context)
        {
            _context = context;
        }

        // GET: api/Downtowns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Downtown>>> GetDowntown()
        {
            return await _context.Downtown.ToListAsync();
        }

        // GET: api/Downtowns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Downtown>> GetDowntown(int id)
        {
            var downtown = await _context.Downtown.FindAsync(id);

            if (downtown == null)
            {
                return NotFound();
            }

            return downtown;
        }

        // PUT: api/Downtowns/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDowntown(int id, Downtown downtown)
        {
            if (id != downtown.Id)
            {
                return BadRequest();
            }

            _context.Entry(downtown).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DowntownExists(id))
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

        // POST: api/Downtowns
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Downtown>> PostDowntown(Downtown downtown)
        {
            _context.Downtown.Add(downtown);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDowntown", new { id = downtown.Id }, downtown);
        }

        // DELETE: api/Downtowns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Downtown>> DeleteDowntown(int id)
        {
            var downtown = await _context.Downtown.FindAsync(id);
            if (downtown == null)
            {
                return NotFound();
            }

            _context.Downtown.Remove(downtown);
            await _context.SaveChangesAsync();

            return downtown;
        }

        private bool DowntownExists(int id)
        {
            return _context.Downtown.Any(e => e.Id == id);
        }
    }
}
