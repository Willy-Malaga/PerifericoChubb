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
    public class E271SolAutController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271SolAutController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271SolAut
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271SolAut>>> GetE271SolAut()
        {
            return await _context.E271SolAut.ToListAsync();
        }

        // GET: api/E271SolAut/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271SolAut>> GetE271SolAut(string id)
        {
            var e271SolAut = await _context.E271SolAut.FindAsync(id);

            if (e271SolAut == null)
            {
                return NotFound();
            }

            return e271SolAut;
        }

        // PUT: api/E271SolAut/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271SolAut(string id, E271SolAut e271SolAut)
        {
            if (id != e271SolAut.noMaTitular)
            {
                return BadRequest();
            }

            _context.Entry(e271SolAut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271SolAutExists(id))
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

        // POST: api/E271SolAut
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271SolAut>> PostE271SolAut(E271SolAut e271SolAut)
        {
            _context.E271SolAut.Add(e271SolAut);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271SolAutExists(e271SolAut.noMaTitular))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271SolAut", new { id = e271SolAut.noMaTitular }, e271SolAut);
        }

        // DELETE: api/E271SolAut/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271SolAut(string id)
        {
            var e271SolAut = await _context.E271SolAut.FindAsync(id);
            if (e271SolAut == null)
            {
                return NotFound();
            }

            _context.E271SolAut.Remove(e271SolAut);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271SolAutExists(string id)
        {
            return _context.E271SolAut.Any(e => e.noMaTitular == id);
        }
    }
}
