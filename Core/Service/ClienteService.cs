using Core.Repository;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ClienteService : IClienteService
    {
        public readonly IClienteRepository repository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            repository = clienteRepository;
        }
        public void Adicionar(Cliente cliente)
        {
            repository.Adicionar(cliente);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Cliente> Listar()
        {
            return repository.Listar();
        }
        public Cliente BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Cliente editCliente)
        {
            repository.Editar(editCliente);
        }
    }
}
