using DNG.API.Entities;
using DNG.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DNG.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly DNGDbContext _context;
        public AlunosController(DNGDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var alunos = _context.Alunos.AsNoTracking().ToList();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var aluno = _context.Alunos.Where(x => x.Id == id).FirstOrDefault();

            if( aluno == null )
                return NotFound();

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return NoContent();

        }

    }
}
