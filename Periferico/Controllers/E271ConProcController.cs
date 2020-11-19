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
    public class E271ConProcController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConProcController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConProc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConProc>>> GetE271ConProc()
        {
            return await _context.E271ConProc.ToListAsync();
        }

        // GET: api/E271ConProc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConProc>> GetE271ConProc(string id)
        {
            var e271ConProc = await _context.E271ConProc.FindAsync(id);

            if (e271ConProc == null)
            {
                return NotFound();
            }

            return e271ConProc;
        }

        // PUT: api/E271ConProc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConProc(string id, E271ConProc e271ConProc)
        {
            if (id != e271ConProc.idTransaccion)
            {
                return BadRequest();
            }

            _context.Entry(e271ConProc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConProcExists(id))
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

        // POST: api/E271ConProc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConProc>> PostE271ConProc(E271ConProc e271ConProc)
        {
            _context.E271ConProc.Add(e271ConProc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConProcExists(e271ConProc.idTransaccion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConProc", new { id = e271ConProc.idTransaccion }, e271ConProc);
        }

        // DELETE: api/E271ConProc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConProc(string id)
        {
            var e271ConProc = await _context.E271ConProc.FindAsync(id);
            if (e271ConProc == null)
            {
                return NotFound();
            }

            _context.E271ConProc.Remove(e271ConProc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConProcExists(string id)
        {
            return _context.E271ConProc.Any(e => e.idTransaccion == id);
        }
    }
}
