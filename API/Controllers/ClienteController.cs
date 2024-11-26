using Core;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService service;

        public ClienteController(IClienteService Service)
        {
            service = Service;
        }

        [HttpPost("adicionar-cliente")]
        public void Adicionar(Cliente cliente)
        {
            service.Adicionar(cliente);
        }

        [HttpGet("listar-cliente")]
        public List<Cliente> Listar()
        {
            return service.Listar();
        }

        [HttpPut("editar-cliente")]
        public void Editar(Cliente cliente)
        {
            service.Editar(cliente);
        }

        [HttpDelete("remover-cliente")]
        public void Remover(int id)
        {
            service.Remover(id);
        }
    }
}
