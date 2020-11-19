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
    public class E271ConNomController : ControllerBase
    {
        private readonly APIDBContext _context;

        public E271ConNomController(APIDBContext context)
        {
            _context = context;
        }

        // GET: api/E271ConNom
        [HttpGet]
        public async Task<ActionResult<IEnumerable<E271ConNom>>> GetE271ConNom()
        {
            return await _context.E271ConNom.ToListAsync();
        }

        // GET: api/E271ConNom/5
        [HttpGet("{id}")]
        public async Task<ActionResult<E271ConNom>> GetE271ConNom(string id)
        {
            var e271ConNom = await _context.E271ConNom.FindAsync(id);

            if (e271ConNom == null)
            {
                return NotFound();
            }

            return e271ConNom;
        }

        // PUT: api/E271ConNom/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutE271ConNom(string id, E271ConNom e271ConNom)
        {
            if (id != e271ConNom.idRemitente)
            {
                return BadRequest();
            }

            _context.Entry(e271ConNom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E271ConNomExists(id))
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

        // POST: api/E271ConNom
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<E271ConNom>> PostE271ConNom(E271ConNom e271ConNom)
        {
            _context.E271ConNom.Add(e271ConNom);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (E271ConNomExists(e271ConNom.idRemitente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetE271ConNom", new { id = e271ConNom.idRemitente }, e271ConNom);
        }

        // DELETE: api/E271ConNom/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteE271ConNom(string id)
        {
            var e271ConNom = await _context.E271ConNom.FindAsync(id);
            if (e271ConNom == null)
            {
                return NotFound();
            }

            _context.E271ConNom.Remove(e271ConNom);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool E271ConNomExists(string id)
        {
            return _context.E271ConNom.Any(e => e.idRemitente == id);
        }
    }
}
