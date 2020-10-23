using DNG.API.Entities;
using DNG.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DNG.API.Controllers.v1
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UnidadesController : ControllerBase
    {
        private readonly DNGDbContext _context;
        public UnidadesController(DNGDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var unidades = _context.Unidades.AsNoTracking().ToList();
            return Ok(unidades);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var unidade = _context.Unidades.Where(x => x.Id == id).FirstOrDefault();

            if( unidade == null )
                return NotFound();

            return Ok(unidade);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Unidade unidade)
        {
            _context.Unidades.Add(unidade);
            _context.SaveChanges();

            return NoContent();

        }
    }
}
