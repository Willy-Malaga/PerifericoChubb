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
    public class E271ResDerivaController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ResDerivaController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ResDeriva
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ResDeriva>>> GetE271ResDeriva()
        {
            return await _context.E271ResDeriva.ToListAsync();
        }

        // GET: api/E271ResDeriva/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ResDeriva>> GetE271ResDeriva(string id)
        {
            var e271ResDeriva = await _context.E271ResDeriva.FindAsync(id);

            if (e271ResDeriva == null)
            {
                return NotFound();
            }

            return e271ResDeriva;
        }

        // PUT: api/E271ResDeriva/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ResDeriva(string id, E271ResDeriva e271ResDeriva)
        {
            if (id != e271ResDeriva.idReceptor)
            {
                return BadRequest();
            }

            _context.Entry(e271ResDeriva).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ResDerivaExists(id))
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

        // POST: api/E271ResDeriva
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ResDeriva>> PostE271ResDeriva(E271ResDeriva e271ResDeriva)
        {
            _context.E271ResDeriva.Add(e271ResDeriva);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ResDerivaExists(e271ResDeriva.idReceptor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ResDeriva", new { id = e271ResDeriva.idReceptor }, e271ResDeriva);
        }

        // DELETE: api/E271ResDeriva/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ResDeriva(string id)
        {
            var e271ResDeriva = await _context.E271ResDeriva.FindAsync(id);
            if (e271ResDeriva == null)
            {
                return NotFound();
            }

            _context.E271ResDeriva.Remove(e271ResDeriva);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ResDerivaExists(string id)
        {
            return _context.E271ResDeriva.Any(e => e.idReceptor == id);
        }
    }
}
