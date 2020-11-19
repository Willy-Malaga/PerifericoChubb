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
    public class E271ResSctrController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ResSctrController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ResSctr
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ResSctr>>> GetE271ResSctr()
        {
            return await _context.E271ResSctr.ToListAsync();
        }

        // GET: api/E271ResSctr/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ResSctr>> GetE271ResSctr(string id)
        {
            var e271ResSctr = await _context.E271ResSctr.FindAsync(id);

            if (e271ResSctr == null)
            {
                return NotFound();
            }

            return e271ResSctr;
        }

        // PUT: api/E271ResSctr/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ResSctr(string id, E271ResSctr e271ResSctr)
        {
            if (id != e271ResSctr.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e271ResSctr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ResSctrExists(id))
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

        // POST: api/E271ResSctr
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ResSctr>> PostE271ResSctr(E271ResSctr e271ResSctr)
        {
            _context.E271ResSctr.Add(e271ResSctr);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ResSctrExists(e271ResSctr.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ResSctr", new { id = e271ResSctr.idRemitente }, e271ResSctr);
        }

        // DELETE: api/E271ResSctr/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ResSctr(string id)
        {
            var e271ResSctr = await _context.E271ResSctr.FindAsync(id);
            if (e271ResSctr == null)
            {
                return NotFound();
            }

            _context.E271ResSctr.Remove(e271ResSctr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ResSctrExists(string id)
        {
            return _context.E271ResSctr.Any(e => e.idRemitente == id);
        }
    }
}
