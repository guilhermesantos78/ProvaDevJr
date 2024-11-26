using Core;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OcorrenciaController : ControllerBase
    {
        public readonly IOcorrenciaService service;

        public OcorrenciaController(IOcorrenciaService Service)
        {
            service = Service;
        }

        [HttpPost("adicionar-ocorrencia")]
        public void Adicionar(Ocorrencia ocorrencia)
        {
            service.Adicionar(ocorrencia);
        }

        [HttpGet("listar-ocorrencia")]
        public List<Ocorrencia> Listar()
        {
            return service.Listar();
        }

        [HttpPut("editar-ocorrencia")]
        public void Editar(Ocorrencia ocorrencia)
        {
            service.Editar(ocorrencia);
        }

        [HttpDelete("remover-ocorrencia")]
        public void Remover(int id)
        {
            service.Remover(id);
        }
    }
}
