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
    public class E271ConDtadController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConDtadController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConDtad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConDtad>>> GetE271ConDtad()
        {
            return await _context.E271ConDtad.ToListAsync();
        }

        // GET: api/E271ConDtad/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConDtad>> GetE271ConDtad(string id)
        {
            var e271ConDtad = await _context.E271ConDtad.FindAsync(id);

            if (e271ConDtad == null)
            {
                return NotFound();
            }

            return e271ConDtad;
        }

        // PUT: api/E271ConDtad/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConDtad(string id, E271ConDtad e271ConDtad)
        {
            if (id != e271ConDtad.idReceptor)
            {
                return BadRequest();
            }

            _context.Entry(e271ConDtad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConDtadExists(id))
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

        // POST: api/E271ConDtad
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConDtad>> PostE271ConDtad(E271ConDtad e271ConDtad)
        {
            _context.E271ConDtad.Add(e271ConDtad);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConDtadExists(e271ConDtad.idReceptor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConDtad", new { id = e271ConDtad.idReceptor }, e271ConDtad);
        }

        // DELETE: api/E271ConDtad/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConDtad(string id)
        {
            var e271ConDtad = await _context.E271ConDtad.FindAsync(id);
            if (e271ConDtad == null)
            {
                return NotFound();
            }

            _context.E271ConDtad.Remove(e271ConDtad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConDtadExists(string id)
        {
            return _context.E271ConDtad.Any(e => e.idReceptor == id);
        }
    }
}
