using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IClienteService
    {
        public void Adicionar(Cliente cliente);
        public void Remover(int id);
        public List<Cliente> Listar();
        public Cliente BuscarPorId(int id);
        public void Editar(Cliente editCliente);
    }
}
