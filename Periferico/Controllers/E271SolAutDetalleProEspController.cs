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
    public class E271SolAutDetalleProEspController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271SolAutDetalleProEspController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271SolAutDetalleProEsp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271SolAutDetalleProEsp>>> GetE271SolAutDetalleProEsp()
        {
            return await _context.E271SolAutDetalleProEsp.ToListAsync();
        }

        // GET: api/E271SolAutDetalleProEsp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271SolAutDetalleProEsp>> GetE271SolAutDetalleProEsp(string id)
        {
            var e271SolAutDetalleProEsp = await _context.E271SolAutDetalleProEsp.FindAsync(id);

            if (e271SolAutDetalleProEsp == null)
            {
                return NotFound();
            }

            return e271SolAutDetalleProEsp;
        }

        // PUT: api/E271SolAutDetalleProEsp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271SolAutDetalleProEsp(string id, E271SolAutDetalleProEsp e271SolAutDetalleProEsp)
        {
            if (id != e271SolAutDetalleProEsp.coTiProConAmbulatoria)
            {
                return BadRequest();
            }

            _context.Entry(e271SolAutDetalleProEsp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271SolAutDetalleProEspExists(id))
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

        // POST: api/E271SolAutDetalleProEsp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271SolAutDetalleProEsp>> PostE271SolAutDetalleProEsp(E271SolAutDetalleProEsp e271SolAutDetalleProEsp)
        {
            _context.E271SolAutDetalleProEsp.Add(e271SolAutDetalleProEsp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271SolAutDetalleProEspExists(e271SolAutDetalleProEsp.coTiProConAmbulatoria))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271SolAutDetalleProEsp", new { id = e271SolAutDetalleProEsp.coTiProConAmbulatoria }, e271SolAutDetalleProEsp);
        }

        // DELETE: api/E271SolAutDetalleProEsp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271SolAutDetalleProEsp(string id)
        {
            var e271SolAutDetalleProEsp = await _context.E271SolAutDetalleProEsp.FindAsync(id);
            if (e271SolAutDetalleProEsp == null)
            {
                return NotFound();
            }

            _context.E271SolAutDetalleProEsp.Remove(e271SolAutDetalleProEsp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271SolAutDetalleProEspExists(string id)
        {
            return _context.E271SolAutDetalleProEsp.Any(e => e.coTiProConAmbulatoria == id);
        }
    }
}
