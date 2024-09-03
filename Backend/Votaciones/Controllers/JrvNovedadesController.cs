using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Votaciones.Context;
using Votaciones.Models;
using Votaciones.Models.DTOs;

namespace Votaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JrvNovedadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JrvNovedadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JrvNovedades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JrvNovedade>>> GetJrvs()
        {
            var jrvs = await _context.Jrv_Novedades
                .Select(j => new JrvNovedadesDto
                {
                    IdNovedades = j.IdNovedades,
                    DescripcionNovedad = j.DescripcionNovedad,
                    Referencia1Novedades = j.Referencia1Novedades,
                    Referencia2Novedades = j.Referencia2Novedades,
                    NombreJrv = j.IdJrv,
                    NombreRegion = j.IdRegion,
                    NombreProvincia = j.IdProvincia,
                    NombreCanton = j.IdCanton,
                    NombreParroquia = j.IdParroquia,
                    NombreRecinto = j.IdRecinto
                }).ToListAsync();

            return Ok(jrvs);
        }

        // GET: Jrv/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JrvNovedade>> GetJrv(long id)
        {
            var jrv = await _context.Jrv_Novedades.FindAsync(id);

            if (jrv == null)
            {
                return NotFound();
            }

            return jrv;
        }

        // PUT: Jrv/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJrv(long id, JrvNovedade jrv)
        {
            if (id != jrv.IdNovedades)
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
            return _context.Jrv_Novedades.Any(e => e.IdNovedades == id);
        }

        //POST: Jrv/Create
        [HttpPost]
        public async Task<ActionResult<JrvNovedade>> PostJrv(JrvNovedade jrv)
        {
            _context.Jrv_Novedades.Add(jrv);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJrv", new { id = jrv.IdNovedades }, jrv);
        }

        // DELETE: Jrv/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJrv(long id)
        {
            var jrv = await _context.Jrv_Novedades.FindAsync(id);
            if (jrv == null)
            {
                return NotFound();
            }

            _context.Jrv_Novedades.Remove(jrv);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
