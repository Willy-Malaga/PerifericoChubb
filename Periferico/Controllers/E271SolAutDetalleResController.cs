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
    public class E271SolAutDetalleResController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271SolAutDetalleResController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271SolAutDetalleRes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271SolAutDetalleRes>>> GetE271SolAutDetalleRes()
        {
            return await _context.E271SolAutDetalleRes.ToListAsync();
        }

        // GET: api/E271SolAutDetalleRes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271SolAutDetalleRes>> GetE271SolAutDetalleRes(string id)
        {
            var e271SolAutDetalleRes = await _context.E271SolAutDetalleRes.FindAsync(id);

            if (e271SolAutDetalleRes == null)
            {
                return NotFound();
            }

            return e271SolAutDetalleRes;
        }

        // PUT: api/E271SolAutDetalleRes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271SolAutDetalleRes(string id, E271SolAutDetalleRes e271SolAutDetalleRes)
        {
            if (id != e271SolAutDetalleRes.idRestricciones)
            {
                return BadRequest();
            }

            _context.Entry(e271SolAutDetalleRes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271SolAutDetalleResExists(id))
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

        // POST: api/E271SolAutDetalleRes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271SolAutDetalleRes>> PostE271SolAutDetalleRes(E271SolAutDetalleRes e271SolAutDetalleRes)
        {
            _context.E271SolAutDetalleRes.Add(e271SolAutDetalleRes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271SolAutDetalleResExists(e271SolAutDetalleRes.idRestricciones))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271SolAutDetalleRes", new { id = e271SolAutDetalleRes.idRestricciones }, e271SolAutDetalleRes);
        }

        // DELETE: api/E271SolAutDetalleRes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271SolAutDetalleRes(string id)
        {
            var e271SolAutDetalleRes = await _context.E271SolAutDetalleRes.FindAsync(id);
            if (e271SolAutDetalleRes == null)
            {
                return NotFound();
            }

            _context.E271SolAutDetalleRes.Remove(e271SolAutDetalleRes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271SolAutDetalleResExists(string id)
        {
            return _context.E271SolAutDetalleRes.Any(e => e.idRestricciones == id);
        }
    }
}
