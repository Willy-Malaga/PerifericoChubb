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
    public class E271SolAutDetalleTieEspController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271SolAutDetalleTieEspController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271SolAutDetalleTieEsp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271SolAutDetalleTieEsp>>> GetE271SolAutDetalleTieEsp()
        {
            return await _context.E271SolAutDetalleTieEsp.ToListAsync();
        }

        // GET: api/E271SolAutDetalleTieEsp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271SolAutDetalleTieEsp>> GetE271SolAutDetalleTieEsp(string id)
        {
            var e271SolAutDetalleTieEsp = await _context.E271SolAutDetalleTieEsp.FindAsync(id);

            if (e271SolAutDetalleTieEsp == null)
            {
                return NotFound();
            }

            return e271SolAutDetalleTieEsp;
        }

        // PUT: api/E271SolAutDetalleTieEsp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271SolAutDetalleTieEsp(string id, E271SolAutDetalleTieEsp e271SolAutDetalleTieEsp)
        {
            if (id != e271SolAutDetalleTieEsp.idTiEspera)
            {
                return BadRequest();
            }

            _context.Entry(e271SolAutDetalleTieEsp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271SolAutDetalleTieEspExists(id))
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

        // POST: api/E271SolAutDetalleTieEsp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271SolAutDetalleTieEsp>> PostE271SolAutDetalleTieEsp(E271SolAutDetalleTieEsp e271SolAutDetalleTieEsp)
        {
            _context.E271SolAutDetalleTieEsp.Add(e271SolAutDetalleTieEsp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271SolAutDetalleTieEspExists(e271SolAutDetalleTieEsp.idTiEspera))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271SolAutDetalleTieEsp", new { id = e271SolAutDetalleTieEsp.idTiEspera }, e271SolAutDetalleTieEsp);
        }

        // DELETE: api/E271SolAutDetalleTieEsp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271SolAutDetalleTieEsp(string id)
        {
            var e271SolAutDetalleTieEsp = await _context.E271SolAutDetalleTieEsp.FindAsync(id);
            if (e271SolAutDetalleTieEsp == null)
            {
                return NotFound();
            }

            _context.E271SolAutDetalleTieEsp.Remove(e271SolAutDetalleTieEsp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271SolAutDetalleTieEspExists(string id)
        {
            return _context.E271SolAutDetalleTieEsp.Any(e => e.idTiEspera == id);
        }
    }
}
