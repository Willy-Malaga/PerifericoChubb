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
    public class E271ResCgController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ResCgController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ResCg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ResCg>>> GetE271ResCg()
        {
            return await _context.E271ResCg.ToListAsync();
        }

        // GET: api/E271ResCg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ResCg>> GetE271ResCg(string id)
        {
            var e271ResCg = await _context.E271ResCg.FindAsync(id);

            if (e271ResCg == null)
            {
                return NotFound();
            }

            return e271ResCg;
        }

        // PUT: api/E271ResCg/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ResCg(string id, E271ResCg e271ResCg)
        {
            if (id != e271ResCg.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e271ResCg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ResCgExists(id))
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

        // POST: api/E271ResCg
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ResCg>> PostE271ResCg(E271ResCg e271ResCg)
        {
            _context.E271ResCg.Add(e271ResCg);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ResCgExists(e271ResCg.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ResCg", new { id = e271ResCg.idRemitente }, e271ResCg);
        }

        // DELETE: api/E271ResCg/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ResCg(string id)
        {
            var e271ResCg = await _context.E271ResCg.FindAsync(id);
            if (e271ResCg == null)
            {
                return NotFound();
            }

            _context.E271ResCg.Remove(e271ResCg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ResCgExists(string id)
        {
            return _context.E271ResCg.Any(e => e.idRemitente == id);
        }
    }
}
