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
    public class E271ConMedController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConMedController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConMed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConMed>>> GetE271ConMed()
        {
            return await _context.E271ConMed.ToListAsync();
        }

        // GET: api/E271ConMed/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConMed>> GetE271ConMed(string id)
        {
            var e271ConMed = await _context.E271ConMed.FindAsync(id);

            if (e271ConMed == null)
            {
                return NotFound();
            }

            return e271ConMed;
        }

        // PUT: api/E271ConMed/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConMed(string id, E271ConMed e271ConMed)
        {
            if (id != e271ConMed.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e271ConMed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConMedExists(id))
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

        // POST: api/E271ConMed
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConMed>> PostE271ConMed(E271ConMed e271ConMed)
        {
            _context.E271ConMed.Add(e271ConMed);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConMedExists(e271ConMed.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConMed", new { id = e271ConMed.idRemitente }, e271ConMed);
        }

        // DELETE: api/E271ConMed/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConMed(string id)
        {
            var e271ConMed = await _context.E271ConMed.FindAsync(id);
            if (e271ConMed == null)
            {
                return NotFound();
            }

            _context.E271ConMed.Remove(e271ConMed);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConMedExists(string id)
        {
            return _context.E271ConMed.Any(e => e.idRemitente == id);
        }
    }
}
