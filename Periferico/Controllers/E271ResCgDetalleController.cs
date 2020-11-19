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
    public class E271ResCgDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ResCgDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ResCgDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ResCgDetalle>>> GetE271ResCgDetalle()
        {
            return await _context.E271ResCgDetalle.ToListAsync();
        }

        // GET: api/E271ResCgDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ResCgDetalle>> GetE271ResCgDetalle(string id)
        {
            var e271ResCgDetalle = await _context.E271ResCgDetalle.FindAsync(id);

            if (e271ResCgDetalle == null)
            {
                return NotFound();
            }

            return e271ResCgDetalle;
        }

        // PUT: api/E271ResCgDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ResCgDetalle(string id, E271ResCgDetalle e271ResCgDetalle)
        {
            if (id != e271ResCgDetalle.noPaciente)
            {
                return BadRequest();
            }

            _context.Entry(e271ResCgDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ResCgDetalleExists(id))
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

        // POST: api/E271ResCgDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ResCgDetalle>> PostE271ResCgDetalle(E271ResCgDetalle e271ResCgDetalle)
        {
            _context.E271ResCgDetalle.Add(e271ResCgDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ResCgDetalleExists(e271ResCgDetalle.noPaciente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ResCgDetalle", new { id = e271ResCgDetalle.noPaciente }, e271ResCgDetalle);
        }

        // DELETE: api/E271ResCgDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ResCgDetalle(string id)
        {
            var e271ResCgDetalle = await _context.E271ResCgDetalle.FindAsync(id);
            if (e271ResCgDetalle == null)
            {
                return NotFound();
            }

            _context.E271ResCgDetalle.Remove(e271ResCgDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ResCgDetalleExists(string id)
        {
            return _context.E271ResCgDetalle.Any(e => e.noPaciente == id);
        }
    }
}
