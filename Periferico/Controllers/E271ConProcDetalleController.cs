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
    public class E271ConProcDetalleController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConProcDetalleController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConProcDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConProcDetalle>>> GetE271ConProcDetalle()
        {
            return await _context.E271ConProcDetalle.ToListAsync();
        }

        // GET: api/E271ConProcDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConProcDetalle>> GetE271ConProcDetalle(string id)
        {
            var e271ConProcDetalle = await _context.E271ConProcDetalle.FindAsync(id);

            if (e271ConProcDetalle == null)
            {
                return NotFound();
            }

            return e271ConProcDetalle;
        }

        // PUT: api/E271ConProcDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConProcDetalle(string id, E271ConProcDetalle e271ConProcDetalle)
        {
            if (id != e271ConProcDetalle.idFuentePE)
            {
                return BadRequest();
            }

            _context.Entry(e271ConProcDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConProcDetalleExists(id))
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

        // POST: api/E271ConProcDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConProcDetalle>> PostE271ConProcDetalle(E271ConProcDetalle e271ConProcDetalle)
        {
            _context.E271ConProcDetalle.Add(e271ConProcDetalle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConProcDetalleExists(e271ConProcDetalle.idFuentePE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConProcDetalle", new { id = e271ConProcDetalle.idFuentePE }, e271ConProcDetalle);
        }

        // DELETE: api/E271ConProcDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConProcDetalle(string id)
        {
            var e271ConProcDetalle = await _context.E271ConProcDetalle.FindAsync(id);
            if (e271ConProcDetalle == null)
            {
                return NotFound();
            }

            _context.E271ConProcDetalle.Remove(e271ConProcDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConProcDetalleExists(string id)
        {
            return _context.E271ConProcDetalle.Any(e => e.idFuentePE == id);
        }
    }
}
