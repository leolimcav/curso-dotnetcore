using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AlunoController : ControllerBase
  {
    public List<Aluno> Alunos = new List<Aluno>() {
      new Aluno() {
        Id= 1,
        Nome = "Marcos",
        Telefone = "123321"
      },
      new Aluno() {
        Id= 2,
        Nome = "Lucas",
        Telefone = "123321"
      },
      new Aluno() {
        Id= 3,
        Nome = "Pedro",
        Telefone = "123321"
      }
    };
    public AlunoController() { }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(Alunos);
    }

    [HttpGet("byId")]
    public IActionResult GetById(int Id)
    {
      var aluno = Alunos.FirstOrDefault(alu => alu.Id == Id);
      if (aluno == null) return BadRequest("Aluno não encontrado!");
      return Ok(Alunos.Find(Aluno => Aluno.Id == Id));
    }
  }
}