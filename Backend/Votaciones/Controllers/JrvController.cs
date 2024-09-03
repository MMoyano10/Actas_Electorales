using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Votaciones.Context;
using Votaciones.Models;
using Votaciones.Models.DTOs;

namespace Votaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JrvController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JrvController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Jrv
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JrvDto>>> GetJrvs()
        {
            var jrvs = await _context.Jrv
                .Select(j => new JrvDto
                {
                    IdJrv = j.IdJrv,
                    NombreRegion = j.IdRegionNavigation.NombreRegion,
                    NombreProvincia = j.IdProvinciaNavigation.NombreProvincia,
                    NombreCanton = j.IdCantonNavigation.NombreCanton,
                    NombreParroquia = j.IdParroquiaNavigation.NombreParroquia,
                    NombreRecinto = j.IdRecintoNavigation.NombreRecinto,
                    DescripcionJrv = j.DescripcionJrv,
                    VotantesmJrv = j.VotantesmJrv,
                    VotantesfJrv = j.VotantesfJrv,
                    CoordinadorJrv = j.CoordinadorJrv,
                    ObservacionesJrv = j.ObservacionesJrv,
                    AdicionalesJrv = j.AdicionalesJrv,
                    ArchivoJrv = j.ArchivoJrv,
                    ImagenJrv = j.ImagenJrv
                })
                .ToListAsync();

            return Ok(jrvs);
        }


        // GET: Jrv/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jrv>> GetJrv(long id)
        {
            var jrv = await _context.Jrv.FindAsync(id);

            if (jrv == null)
            {
                return NotFound();
            }

            return jrv;
        }

        // PUT: Jrv/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJrv(long id, Jrv jrv)
        {
            if (id != jrv.IdJrv)
            {
                return BadRequest();
            }

            _context.Entry(jrv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JrvExists(id))
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

        private bool JrvExists(long id)
        {
            return _context.Jrv.Any(e => e.IdJrv == id);
        }

        //POST: Jrv/Create
        [HttpPost]
        public async Task<ActionResult<Jrv>> PostJrv(Jrv jrv)
        {
            _context.Jrv.Add(jrv);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJrv", new { id = jrv.IdJrv }, jrv);
        }

        // DELETE: Jrv/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJrv(long id)
        {
            var jrv = await _context.Jrv.FindAsync(id);
            if (jrv == null)
            {
                return NotFound();
            }

            _context.Jrv.Remove(jrv);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
