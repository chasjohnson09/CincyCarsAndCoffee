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
    public class EastsController : ControllerBase
    {
        private readonly CCaCDbContext _context;

        public EastsController(CCaCDbContext context)
        {
            _context = context;
        }

        // GET: api/Easts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<East>>> GetEast_1()
        {
            return await _context.East_1.ToListAsync();
        }

        // GET: api/Easts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<East>> GetEast(int id)
        {
            var east = await _context.East_1.FindAsync(id);

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
            _context.East_1.Add(east);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEast", new { id = east.Id }, east);
        }

        // DELETE: api/Easts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<East>> DeleteEast(int id)
        {
            var east = await _context.East_1.FindAsync(id);
            if (east == null)
            {
                return NotFound();
            }

            _context.East_1.Remove(east);
            await _context.SaveChangesAsync();

            return east;
        }

        private bool EastExists(int id)
        {
            return _context.East_1.Any(e => e.Id == id);
        }
    }
}
