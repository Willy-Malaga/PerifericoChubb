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
    public class E271ConCodController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConCodController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConCod
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConCod>>> GetE271ConCod()
        {
            return await _context.E271ConCod.ToListAsync();
        }

        // GET: api/E271ConCod/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConCod>> GetE271ConCod(string id)
        {
            var e271ConCod = await _context.E271ConCod.FindAsync(id);

            if (e271ConCod == null)
            {
                return NotFound();
            }

            return e271ConCod;
        }

        // PUT: api/E271ConCod/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConCod(string id, E271ConCod e271ConCod)
        {
            if (id != e271ConCod.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e271ConCod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConCodExists(id))
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

        // POST: api/E271ConCod
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConCod>> PostE271ConCod(E271ConCod e271ConCod)
        {
            _context.E271ConCod.Add(e271ConCod);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConCodExists(e271ConCod.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConCod", new { id = e271ConCod.idRemitente }, e271ConCod);
        }

        // DELETE: api/E271ConCod/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConCod(string id)
        {
            var e271ConCod = await _context.E271ConCod.FindAsync(id);
            if (e271ConCod == null)
            {
                return NotFound();
            }

            _context.E271ConCod.Remove(e271ConCod);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConCodExists(string id)
        {
            return _context.E271ConCod.Any(e => e.idRemitente == id);
        }
    }
}
