using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Periferico.Models;

namespace Periferico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class E270ConAseController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E270ConAseController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E270ConAse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E270ConAse>>> GetE270ConAse()
        {
            return await _context.E270ConAse.ToListAsync();
        }

        // GET: api/E270ConAse/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E270ConAse>> GetE270ConAse(string id)
        {
            var e270ConAse = await _context.E270ConAse.FindAsync(id);

            if (e270ConAse == null)
            {
                return NotFound();
            }

            return e270ConAse;
        }

        // PUT: api/E270ConAse/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE270ConAse(string id, E270ConAse e270ConAse)
        {
            if (id != e270ConAse.noContratante)
            {
                return BadRequest();
            }

            _context.Entry(e270ConAse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E270ConAseExists(id))
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

        // POST: api/E270ConAse
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E270ConAse>> PostE270ConAse(E270ConAse e270ConAse)
        {
            _context.E270ConAse.Add(e270ConAse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E270ConAseExists(e270ConAse.noContratante))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE270ConAse", new { id = e270ConAse.noContratante }, e270ConAse);
        }

        // DELETE: api/E270ConAse/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE270ConAse(string id)
        {
            var e270ConAse = await _context.E270ConAse.FindAsync(id);
            if (e270ConAse == null)
            {
                return NotFound();
            }

            _context.E270ConAse.Remove(e270ConAse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E270ConAseExists(string id)
        {
            return _context.E270ConAse.Any(e => e.noContratante == id);
        }
    }
}
