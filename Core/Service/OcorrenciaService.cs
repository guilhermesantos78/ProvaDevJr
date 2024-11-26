using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class OcorrenciaService : IOcorrenciaService
    {
        public readonly IOcorrenciaRepository repository;
        public OcorrenciaService(IOcorrenciaRepository clienteRepository)
        {
            repository = clienteRepository;
        }
        public void Adicionar(Ocorrencia ocorrencia)
        {
            repository.Adicionar(ocorrencia);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Ocorrencia> Listar()
        {
            return repository.Listar();
        }
        public Ocorrencia BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Ocorrencia editOcorrencia)
        {
            repository.Editar(editOcorrencia);
        }
    }
}
