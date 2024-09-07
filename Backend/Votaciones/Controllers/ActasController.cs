using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Votaciones.Context;
using Votaciones.Models;
using Votaciones.Models.DTOs;

namespace Votaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActasController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Actas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActaDto>>> GetActas()
        {
            var actas = await _context.Actas
    .Select(a => new Acta
    {
        IdActa = a.IdActa,
        DescripcionActa = a.DescripcionActa,
        IdRegion = a.IdRegion,
        IdProvincia = a.IdProvincia,
        IdCanton = a.IdCanton,
        IdParroquia = a.IdParroquia,
        IdRecinto = a.IdRecinto,
        IdJrv = a.IdJrv,
        Candidato1Jrv = a.Candidato1Jrv,
        Candidato2Jrv = a.Candidato2Jrv,
        Candidato3Jrv = a.Candidato3Jrv,
        Candidato4Jrv = a.Candidato4Jrv,
        Candidato5Jrv = a.Candidato5Jrv,
        Candidato6Jrv = a.Candidato6Jrv,
        Candidato7Jrv = a.Candidato7Jrv,
        Candidato8Jrv = a.Candidato8Jrv,
        Candidato9Jrv = a.Candidato9Jrv,
        Candidato10Jrv = a.Candidato10Jrv,
        Candidato11Jrv = a.Candidato11Jrv,
        Candidato12Jrv = a.Candidato12Jrv,
        Candidato13Jrv = a.Candidato13Jrv,
        Candidato14Jrv = a.Candidato14Jrv,
        Candidato15Jrv = a.Candidato15Jrv,
        Candidato16Jrv = a.Candidato16Jrv,
        Candidato17Jrv = a.Candidato17Jrv,
        Candidato18Jrv = a.Candidato18Jrv,
        Candidato19Jrv = a.Candidato19Jrv,
        Candidato20Jrv = a.Candidato20Jrv,
        NulosJrv = a.NulosJrv,
        BlancosJrv = a.BlancosJrv,
        ObservacionecsJrv = a.ObservacionecsJrv,
        TotalPadronJrv = a.TotalPadronJrv,
        TotalEleccionJrv = a.TotalEleccionJrv
    })
    .ToListAsync();


            return Ok(actas);
        }

        //Get: Actas/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acta>> GetActa(long id)
        {
            var acta = await _context.Actas.FindAsync(id);

            if (acta == null)
            {
                return NotFound();
            }

            return acta;
        }

        // POST: Actas/Create
        [HttpPost]
        public async Task<ActionResult<Acta>> PostActa(Acta acta)
        {
            _context.Actas.Add(acta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActa", new { id = acta.IdActa }, acta);
        }

        // PUT: Actas/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActa(long id, Acta acta)
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

        private bool ActaExists(long id)
        {
            return _context.Actas.Any(e => e.IdActa == id);
        }

        // DELETE: Actas/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActa(long id)
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


    }
}
