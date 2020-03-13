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
    public class NotasController : ControllerBase
    {
        private readonly DBContexto _context;

        public NotasController(DBContexto context)
        {
            _context = context;
        }

        // GET: api/Notas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TNotas>>> Getnotas()
        {
            return await _context.notas.ToListAsync();
        }

        // GET: api/Notas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TNotas>> GetNotas(int id)
        {
            var notas = await _context.notas.FindAsync(id);

            if (notas == null)
            {
                return NotFound();
            }

            return notas;
        }

        // PUT: api/Notas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotas(int id, TNotas notas)
        {
            if (id != notas.Id)
            {
                return BadRequest();
            }

            _context.Entry(notas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotasExists(id))
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

        // POST: api/Notas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TNotas>> PostNotas(TNotas notas)
        {
            _context.notas.Add(notas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNotas", new { id = notas.Id }, notas);
        }

        // DELETE: api/Notas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TNotas>> DeleteNotas(int id)
        {
            var notas = await _context.notas.FindAsync(id);
            if (notas == null)
            {
                return NotFound();
            }

            _context.notas.Remove(notas);
            await _context.SaveChangesAsync();

            return notas;
        }

        private bool NotasExists(int id)
        {
            return _context.notas.Any(e => e.Id == id);
        }
    }
}
