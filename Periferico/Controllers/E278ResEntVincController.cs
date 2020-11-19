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
    public class E278ResEntVincController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E278ResEntVincController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E278ResEntVinc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E278ResEntVinc>>> GetE278ResEntVinc()
        {
            return await _context.E278ResEntVinc.ToListAsync();
        }

        // GET: api/E278ResEntVinc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E278ResEntVinc>> GetE278ResEntVinc(string id)
        {
            var e278ResEntVinc = await _context.E278ResEntVinc.FindAsync(id);

            if (e278ResEntVinc == null)
            {
                return NotFound();
            }

            return e278ResEntVinc;
        }

        // PUT: api/E278ResEntVinc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE278ResEntVinc(string id, E278ResEntVinc e278ResEntVinc)
        {
            if (id != e278ResEntVinc.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e278ResEntVinc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E278ResEntVincExists(id))
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

        // POST: api/E278ResEntVinc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E278ResEntVinc>> PostE278ResEntVinc(E278ResEntVinc e278ResEntVinc)
        {
            _context.E278ResEntVinc.Add(e278ResEntVinc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E278ResEntVincExists(e278ResEntVinc.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE278ResEntVinc", new { id = e278ResEntVinc.idRemitente }, e278ResEntVinc);
        }

        // DELETE: api/E278ResEntVinc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE278ResEntVinc(string id)
        {
            var e278ResEntVinc = await _context.E278ResEntVinc.FindAsync(id);
            if (e278ResEntVinc == null)
            {
                return NotFound();
            }

            _context.E278ResEntVinc.Remove(e278ResEntVinc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E278ResEntVincExists(string id)
        {
            return _context.E278ResEntVinc.Any(e => e.idRemitente == id);
        }
    }
}
