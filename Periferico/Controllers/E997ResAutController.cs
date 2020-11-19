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
    public class E997ResAutController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E997ResAutController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E997ResAut
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E997ResAut>>> GetE997ResAut()
        {
            return await _context.E997ResAut.ToListAsync();
        }

        // GET: api/E997ResAut/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E997ResAut>> GetE997ResAut(string id)
        {
            var e997ResAut = await _context.E997ResAut.FindAsync(id);

            if (e997ResAut == null)
            {
                return NotFound();
            }

            return e997ResAut;
        }

        // PUT: api/E997ResAut/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE997ResAut(string id, E997ResAut e997ResAut)
        {
            if (id != e997ResAut.idReceptor)
            {
                return BadRequest();
            }

            _context.Entry(e997ResAut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E997ResAutExists(id))
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

        // POST: api/E997ResAut
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E997ResAut>> PostE997ResAut(E997ResAut e997ResAut)
        {
            _context.E997ResAut.Add(e997ResAut);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E997ResAutExists(e997ResAut.idReceptor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE997ResAut", new { id = e997ResAut.idReceptor }, e997ResAut);
        }

        // DELETE: api/E997ResAut/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE997ResAut(string id)
        {
            var e997ResAut = await _context.E997ResAut.FindAsync(id);
            if (e997ResAut == null)
            {
                return NotFound();
            }

            _context.E997ResAut.Remove(e997ResAut);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E997ResAutExists(string id)
        {
            return _context.E997ResAut.Any(e => e.idReceptor == id);
        }
    }
}
