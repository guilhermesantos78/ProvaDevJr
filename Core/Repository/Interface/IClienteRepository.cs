using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IClienteRepository
    {
        public void Adicionar(Cliente cliente);
        public void Remover(int id);
        public void Editar(Cliente caminhao);
        public List<Cliente> Listar();
        public Cliente BuscarPorId(int id);
    }
}
