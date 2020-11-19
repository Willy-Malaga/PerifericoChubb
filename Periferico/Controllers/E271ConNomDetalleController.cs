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
    public class E271ConNomDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConNomDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConNomDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConNomDetalle>>> GetE271ConNomDetalle()
        {
            return await _context.E271ConNomDetalle.ToListAsync();
        }

        // GET: api/E271ConNomDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConNomDetalle>> GetE271ConNomDetalle(string id)
        {
            var e271ConNomDetalle = await _context.E271ConNomDetalle.FindAsync(id);

            if (e271ConNomDetalle == null)
            {
                return NotFound();
            }

            return e271ConNomDetalle;
        }

        // PUT: api/E271ConNomDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConNomDetalle(string id, E271ConNomDetalle e271ConNomDetalle)
        {
            if (id != e271ConNomDetalle.noPaciente)
            {
                return BadRequest();
            }

            _context.Entry(e271ConNomDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConNomDetalleExists(id))
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

        // POST: api/E271ConNomDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConNomDetalle>> PostE271ConNomDetalle(E271ConNomDetalle e271ConNomDetalle)
        {
            _context.E271ConNomDetalle.Add(e271ConNomDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConNomDetalleExists(e271ConNomDetalle.noPaciente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConNomDetalle", new { id = e271ConNomDetalle.noPaciente }, e271ConNomDetalle);
        }

        // DELETE: api/E271ConNomDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConNomDetalle(string id)
        {
            var e271ConNomDetalle = await _context.E271ConNomDetalle.FindAsync(id);
            if (e271ConNomDetalle == null)
            {
                return NotFound();
            }

            _context.E271ConNomDetalle.Remove(e271ConNomDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConNomDetalleExists(string id)
        {
            return _context.E271ConNomDetalle.Any(e => e.noPaciente == id);
        }
    }
}
