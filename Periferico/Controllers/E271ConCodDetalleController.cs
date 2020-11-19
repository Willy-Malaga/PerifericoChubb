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
    public class E271ConCodDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConCodDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConCodDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConCodDetalle>>> GetE271ConCodDetalle()
        {
            return await _context.E271ConCodDetalle.ToListAsync();
        }

        // GET: api/E271ConCodDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConCodDetalle>> GetE271ConCodDetalle(string id)
        {
            var e271ConCodDetalle = await _context.E271ConCodDetalle.FindAsync(id);

            if (e271ConCodDetalle == null)
            {
                return NotFound();
            }

            return e271ConCodDetalle;
        }

        // PUT: api/E271ConCodDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConCodDetalle(string id, E271ConCodDetalle e271ConCodDetalle)
        {
            if (id != e271ConCodDetalle.idProducto)
            {
                return BadRequest();
            }

            _context.Entry(e271ConCodDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConCodDetalleExists(id))
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

        // POST: api/E271ConCodDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConCodDetalle>> PostE271ConCodDetalle(E271ConCodDetalle e271ConCodDetalle)
        {
            _context.E271ConCodDetalle.Add(e271ConCodDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConCodDetalleExists(e271ConCodDetalle.idProducto))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConCodDetalle", new { id = e271ConCodDetalle.idProducto }, e271ConCodDetalle);
        }

        // DELETE: api/E271ConCodDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConCodDetalle(string id)
        {
            var e271ConCodDetalle = await _context.E271ConCodDetalle.FindAsync(id);
            if (e271ConCodDetalle == null)
            {
                return NotFound();
            }

            _context.E271ConCodDetalle.Remove(e271ConCodDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConCodDetalleExists(string id)
        {
            return _context.E271ConCodDetalle.Any(e => e.idProducto == id);
        }
    }
}
