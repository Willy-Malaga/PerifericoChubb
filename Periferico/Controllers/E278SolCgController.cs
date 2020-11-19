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
    public class E278SolCgController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E278SolCgController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E278SolCg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E278SolCg>>> GetE278SolCg()
        {
            return await _context.E278SolCg.ToListAsync();
        }

        // GET: api/E278SolCg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E278SolCg>> GetE278SolCg(string id)
        {
            var e278SolCg = await _context.E278SolCg.FindAsync(id);

            if (e278SolCg == null)
            {
                return NotFound();
            }

            return e278SolCg;
        }

        // PUT: api/E278SolCg/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE278SolCg(string id, E278SolCg e278SolCg)
        {
            if (id != e278SolCg.idCorrelativo)
            {
                return BadRequest();
            }

            _context.Entry(e278SolCg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E278SolCgExists(id))
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

        // POST: api/E278SolCg
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E278SolCg>> PostE278SolCg(E278SolCg e278SolCg)
        {
            _context.E278SolCg.Add(e278SolCg);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E278SolCgExists(e278SolCg.idCorrelativo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE278SolCg", new { id = e278SolCg.idCorrelativo }, e278SolCg);
        }

        // DELETE: api/E278SolCg/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE278SolCg(string id)
        {
            var e278SolCg = await _context.E278SolCg.FindAsync(id);
            if (e278SolCg == null)
            {
                return NotFound();
            }

            _context.E278SolCg.Remove(e278SolCg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E278SolCgExists(string id)
        {
            return _context.E278SolCg.Any(e => e.idCorrelativo == id);
        }
    }
}
