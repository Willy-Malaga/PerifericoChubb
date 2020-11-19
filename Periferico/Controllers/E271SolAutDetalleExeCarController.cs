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
    public class E271SolAutDetalleExeCarController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271SolAutDetalleExeCarController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271SolAutDetalleExeCar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271SolAutDetalleExeCar>>> GetE271SolAutDetalleExeCar()
        {
            return await _context.E271SolAutDetalleExeCar.ToListAsync();
        }

        // GET: api/E271SolAutDetalleExeCar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271SolAutDetalleExeCar>> GetE271SolAutDetalleExeCar(string id)
        {
            var e271SolAutDetalleExeCar = await _context.E271SolAutDetalleExeCar.FindAsync(id);

            if (e271SolAutDetalleExeCar == null)
            {
                return NotFound();
            }

            return e271SolAutDetalleExeCar;
        }

        // PUT: api/E271SolAutDetalleExeCar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271SolAutDetalleExeCar(string id, E271SolAutDetalleExeCar e271SolAutDetalleExeCar)
        {
            if (id != e271SolAutDetalleExeCar.idExCarencia)
            {
                return BadRequest();
            }

            _context.Entry(e271SolAutDetalleExeCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271SolAutDetalleExeCarExists(id))
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

        // POST: api/E271SolAutDetalleExeCar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271SolAutDetalleExeCar>> PostE271SolAutDetalleExeCar(E271SolAutDetalleExeCar e271SolAutDetalleExeCar)
        {
            _context.E271SolAutDetalleExeCar.Add(e271SolAutDetalleExeCar);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271SolAutDetalleExeCarExists(e271SolAutDetalleExeCar.idExCarencia))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271SolAutDetalleExeCar", new { id = e271SolAutDetalleExeCar.idExCarencia }, e271SolAutDetalleExeCar);
        }

        // DELETE: api/E271SolAutDetalleExeCar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271SolAutDetalleExeCar(string id)
        {
            var e271SolAutDetalleExeCar = await _context.E271SolAutDetalleExeCar.FindAsync(id);
            if (e271SolAutDetalleExeCar == null)
            {
                return NotFound();
            }

            _context.E271SolAutDetalleExeCar.Remove(e271SolAutDetalleExeCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271SolAutDetalleExeCarExists(string id)
        {
            return _context.E271SolAutDetalleExeCar.Any(e => e.idExCarencia == id);
        }
    }
}
