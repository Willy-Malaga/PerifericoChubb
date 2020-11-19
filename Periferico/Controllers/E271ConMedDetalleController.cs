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
    public class E271ConMedDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConMedDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConMedDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConMedDetalle>>> GetE271ConMedDetalle()
        {
            return await _context.E271ConMedDetalle.ToListAsync();
        }

        // GET: api/E271ConMedDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConMedDetalle>> GetE271ConMedDetalle(string id)
        {
            var e271ConMedDetalle = await _context.E271ConMedDetalle.FindAsync(id);

            if (e271ConMedDetalle == null)
            {
                return NotFound();
            }

            return e271ConMedDetalle;
        }

        // PUT: api/E271ConMedDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConMedDetalle(string id, E271ConMedDetalle e271ConMedDetalle)
        {
            if (id != e271ConMedDetalle.idFuenteRE)
            {
                return BadRequest();
            }

            _context.Entry(e271ConMedDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConMedDetalleExists(id))
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

        // POST: api/E271ConMedDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConMedDetalle>> PostE271ConMedDetalle(E271ConMedDetalle e271ConMedDetalle)
        {
            _context.E271ConMedDetalle.Add(e271ConMedDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConMedDetalleExists(e271ConMedDetalle.idFuenteRE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConMedDetalle", new { id = e271ConMedDetalle.idFuenteRE }, e271ConMedDetalle);
        }

        // DELETE: api/E271ConMedDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConMedDetalle(string id)
        {
            var e271ConMedDetalle = await _context.E271ConMedDetalle.FindAsync(id);
            if (e271ConMedDetalle == null)
            {
                return NotFound();
            }

            _context.E271ConMedDetalle.Remove(e271ConMedDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConMedDetalleExists(string id)
        {
            return _context.E271ConMedDetalle.Any(e => e.idFuenteRE == id);
        }
    }
}
