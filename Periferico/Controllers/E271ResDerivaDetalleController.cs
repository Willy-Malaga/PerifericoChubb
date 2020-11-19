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
    public class E271ResDerivaDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ResDerivaDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ResDerivaDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ResDerivaDetalle>>> GetE271ResDerivaDetalle()
        {
            return await _context.E271ResDerivaDetalle.ToListAsync();
        }

        // GET: api/E271ResDerivaDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ResDerivaDetalle>> GetE271ResDerivaDetalle(string id)
        {
            var e271ResDerivaDetalle = await _context.E271ResDerivaDetalle.FindAsync(id);

            if (e271ResDerivaDetalle == null)
            {
                return NotFound();
            }

            return e271ResDerivaDetalle;
        }

        // PUT: api/E271ResDerivaDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ResDerivaDetalle(string id, E271ResDerivaDetalle e271ResDerivaDetalle)
        {
            if (id != e271ResDerivaDetalle.idCaReferencia)
            {
                return BadRequest();
            }

            _context.Entry(e271ResDerivaDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ResDerivaDetalleExists(id))
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

        // POST: api/E271ResDerivaDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ResDerivaDetalle>> PostE271ResDerivaDetalle(E271ResDerivaDetalle e271ResDerivaDetalle)
        {
            _context.E271ResDerivaDetalle.Add(e271ResDerivaDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ResDerivaDetalleExists(e271ResDerivaDetalle.idCaReferencia))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ResDerivaDetalle", new { id = e271ResDerivaDetalle.idCaReferencia }, e271ResDerivaDetalle);
        }

        // DELETE: api/E271ResDerivaDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ResDerivaDetalle(string id)
        {
            var e271ResDerivaDetalle = await _context.E271ResDerivaDetalle.FindAsync(id);
            if (e271ResDerivaDetalle == null)
            {
                return NotFound();
            }

            _context.E271ResDerivaDetalle.Remove(e271ResDerivaDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ResDerivaDetalleExists(string id)
        {
            return _context.E271ResDerivaDetalle.Any(e => e.idCaReferencia == id);
        }
    }
}
