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
    public class E271ConObsController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConObsController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConObs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConObs>>> GetE271ConObs()
        {
            return await _context.E271ConObs.ToListAsync();
        }

        // GET: api/E271ConObs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConObs>> GetE271ConObs(string id)
        {
            var e271ConObs = await _context.E271ConObs.FindAsync(id);

            if (e271ConObs == null)
            {
                return NotFound();
            }

            return e271ConObs;
        }

        // PUT: api/E271ConObs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConObs(string id, E271ConObs e271ConObs)
        {
            if (id != e271ConObs.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e271ConObs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConObsExists(id))
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

        // POST: api/E271ConObs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConObs>> PostE271ConObs(E271ConObs e271ConObs)
        {
            _context.E271ConObs.Add(e271ConObs);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConObsExists(e271ConObs.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConObs", new { id = e271ConObs.idRemitente }, e271ConObs);
        }

        // DELETE: api/E271ConObs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConObs(string id)
        {
            var e271ConObs = await _context.E271ConObs.FindAsync(id);
            if (e271ConObs == null)
            {
                return NotFound();
            }

            _context.E271ConObs.Remove(e271ConObs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConObsExists(string id)
        {
            return _context.E271ConObs.Any(e => e.idRemitente == id);
        }
    }
}
