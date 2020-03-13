using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using transpositionAPI.Context;
using transpositionAPI.Models;

namespace transpositionAPI.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcordesController : ControllerBase
    {
        private readonly DBContexto _context;

        public AcordesController(DBContexto context)
        {
            _context = context;
        }

        // GET: api/Acordes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAcordes>>> Getacordes()
        {
            return await _context.acordes.ToListAsync();
        }

        // GET: api/Acordes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAcordes>> GetAcordes(int id)
        {
            var acordes = await _context.acordes.FindAsync(id);

            if (acordes == null)
            {
                return NotFound();
            }

            return acordes;
        }

        // PUT: api/Acordes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcordes(int id, TAcordes acordes)
        {
            if (id != acordes.Id)
            {
                return BadRequest();
            }

            _context.Entry(acordes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcordesExists(id))
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

        // POST: api/Acordes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TAcordes>> PostAcordes(TAcordes acordes)
        {
            _context.acordes.Add(acordes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcordes", new { id = acordes.Id }, acordes);
        }

        // DELETE: api/Acordes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TAcordes>> DeleteAcordes(int id)
        {
            var acordes = await _context.acordes.FindAsync(id);
            if (acordes == null)
            {
                return NotFound();
            }

            _context.acordes.Remove(acordes);
            await _context.SaveChangesAsync();

            return acordes;
        }

        private bool AcordesExists(int id)
        {
            return _context.acordes.Any(e => e.Id == id);
        }
    }
}
