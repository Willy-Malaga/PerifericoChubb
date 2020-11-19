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
    public class E270ConAseAccController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E270ConAseAccController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E270ConAseAcc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E270ConAseAcc>>> GetE270ConAseAcc()
        {
            return await _context.E270ConAseAcc.ToListAsync();
        }

        // GET: api/E270ConAseAcc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E270ConAseAcc>> GetE270ConAseAcc(string id)
        {
            var e270ConAseAcc = await _context.E270ConAseAcc.FindAsync(id);

            if (e270ConAseAcc == null)
            {
                return NotFound();
            }

            return e270ConAseAcc;
        }

        // PUT: api/E270ConAseAcc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE270ConAseAcc(string id, E270ConAseAcc e270ConAseAcc)
        {
            if (id != e270ConAseAcc.noTransaccion)
            {
                return BadRequest();
            }

            _context.Entry(e270ConAseAcc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E270ConAseAccExists(id))
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

        // POST: api/E270ConAseAcc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E270ConAseAcc>> PostE270ConAseAcc(E270ConAseAcc e270ConAseAcc)
        {
            _context.E270ConAseAcc.Add(e270ConAseAcc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E270ConAseAccExists(e270ConAseAcc.noTransaccion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE270ConAseAcc", new { id = e270ConAseAcc.noTransaccion }, e270ConAseAcc);
        }

        // DELETE: api/E270ConAseAcc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE270ConAseAcc(string id)
        {
            var e270ConAseAcc = await _context.E270ConAseAcc.FindAsync(id);
            if (e270ConAseAcc == null)
            {
                return NotFound();
            }

            _context.E270ConAseAcc.Remove(e270ConAseAcc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E270ConAseAccExists(string id)
        {
            return _context.E270ConAseAcc.Any(e => e.noTransaccion == id);
        }
    }
}
