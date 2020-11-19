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
    public class E271ResSctrDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ResSctrDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ResSctrDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ResSctrDetalle>>> GetE271ResSctrDetalle()
        {
            return await _context.E271ResSctrDetalle.ToListAsync();
        }

        // GET: api/E271ResSctrDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ResSctrDetalle>> GetE271ResSctrDetalle(string id)
        {
            var e271ResSctrDetalle = await _context.E271ResSctrDetalle.FindAsync(id);

            if (e271ResSctrDetalle == null)
            {
                return NotFound();
            }

            return e271ResSctrDetalle;
        }

        // PUT: api/E271ResSctrDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ResSctrDetalle(string id, E271ResSctrDetalle e271ResSctrDetalle)
        {
            if (id != e271ResSctrDetalle.idCaReContratante)
            {
                return BadRequest();
            }

            _context.Entry(e271ResSctrDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ResSctrDetalleExists(id))
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

        // POST: api/E271ResSctrDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ResSctrDetalle>> PostE271ResSctrDetalle(E271ResSctrDetalle e271ResSctrDetalle)
        {
            _context.E271ResSctrDetalle.Add(e271ResSctrDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ResSctrDetalleExists(e271ResSctrDetalle.idCaReContratante))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ResSctrDetalle", new { id = e271ResSctrDetalle.idCaReContratante }, e271ResSctrDetalle);
        }

        // DELETE: api/E271ResSctrDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ResSctrDetalle(string id)
        {
            var e271ResSctrDetalle = await _context.E271ResSctrDetalle.FindAsync(id);
            if (e271ResSctrDetalle == null)
            {
                return NotFound();
            }

            _context.E271ResSctrDetalle.Remove(e271ResSctrDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ResSctrDetalleExists(string id)
        {
            return _context.E271ResSctrDetalle.Any(e => e.idCaReContratante == id);
        }
    }
}
