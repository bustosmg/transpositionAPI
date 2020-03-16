using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transpositionAPI.Context;
using transpositionAPI.Models;

namespace transpositionAPI.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly DBContexto _context;
        private readonly ILogger<NotasController> _logger;
        public NotasController(DBContexto context, ILogger<NotasController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("/GetTestLog")]
        public  ActionResult GetTestLog()
        {
            int interacion = 3;
            _logger.LogDebug($"Debug {interacion}");
            _logger.LogInformation($"LogInformation {interacion}");
            _logger.LogWarning($"LogWarning {interacion}");
            _logger.LogError($"LogError {interacion}");
            _logger.LogCritical($"LogCritical {interacion}");

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
            }
            return Ok("GetTestLog");
        }
        // GET: api/Notas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TNotas>>> Getnotas()
        {
            try
            {
                return await _context.notas.ToListAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
            }
            return Ok("Getnotas");
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
