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
    public class E278ContEntVincController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E278ContEntVincController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E278ContEntVinc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E278ContEntVinc>>> GetE278ContEntVinc()
        {
            return await _context.E278ContEntVinc.ToListAsync();
        }

        // GET: api/E278ContEntVinc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E278ContEntVinc>> GetE278ContEntVinc(string id)
        {
            var e278ContEntVinc = await _context.E278ContEntVinc.FindAsync(id);

            if (e278ContEntVinc == null)
            {
                return NotFound();
            }

            return e278ContEntVinc;
        }

        // PUT: api/E278ContEntVinc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE278ContEntVinc(string id, E278ContEntVinc e278ContEntVinc)
        {
            if (id != e278ContEntVinc.idReceptor)
            {
                return BadRequest();
            }

            _context.Entry(e278ContEntVinc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E278ContEntVincExists(id))
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

        // POST: api/E278ContEntVinc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E278ContEntVinc>> PostE278ContEntVinc(E278ContEntVinc e278ContEntVinc)
        {
            _context.E278ContEntVinc.Add(e278ContEntVinc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E278ContEntVincExists(e278ContEntVinc.idReceptor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE278ContEntVinc", new { id = e278ContEntVinc.idReceptor }, e278ContEntVinc);
        }

        // DELETE: api/E278ContEntVinc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE278ContEntVinc(string id)
        {
            var e278ContEntVinc = await _context.E278ContEntVinc.FindAsync(id);
            if (e278ContEntVinc == null)
            {
                return NotFound();
            }

            _context.E278ContEntVinc.Remove(e278ContEntVinc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E278ContEntVincExists(string id)
        {
            return _context.E278ContEntVinc.Any(e => e.idReceptor == id);
        }
    }
}
