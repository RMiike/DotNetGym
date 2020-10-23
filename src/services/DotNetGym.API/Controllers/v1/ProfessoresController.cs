using DNG.API.Entities;
using DNG.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DNG.API.Controllers.v1
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly DNGDbContext _context;
        public ProfessoresController(DNGDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var professores = _context.Professores.AsNoTracking().ToList();
            return Ok(professores);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var professor = _context.Professores.Where(x => x.Id == id).FirstOrDefault();

            if( professor == null )
                return NotFound();

            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Professor professor)
        {
            _context.Professores.Add(professor);
            _context.SaveChanges();

            return NoContent();

        }
    }
}
