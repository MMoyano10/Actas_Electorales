using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Votaciones.Context;
using Votaciones.Models;

namespace Votaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActaController : Controller
    {
        //Create a new instance of the ApplicationDbContext class
        private readonly ApplicationDbContext _context;
        public ActaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Actas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acta>>> GetActas()
        {
            return await _context.Actas.ToListAsync();
        }

        // GET: api/Actas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acta>> GetActa(int id)
        {
            var acta = await _context.Actas.FindAsync(id);

            if (acta == null)
            {
                return NotFound();
            }

            return acta;
        }

        // PUT: api/Actas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActa(int id, Acta acta)
        {
            if (id != acta.IdActa)
            {
                return BadRequest();
            }

            _context.Entry(acta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActaExists(id))
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

        // POST: api/Actas
        [HttpPost]
        public async Task<ActionResult<Acta>> PostActa(Acta acta)
        {
            _context.Actas.Add(acta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActa", new { id = acta.IdActa }, acta);
        }

        // DELETE: api/Actas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActa(int id)
        {
            var acta = await _context.Actas.FindAsync(id);
            if (acta == null)
            {
                return NotFound();
            }

            _context.Actas.Remove(acta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActaExists(int id)
        {
            return _context.Actas.Any(e => e.IdActa == id);
        }
    }
}
