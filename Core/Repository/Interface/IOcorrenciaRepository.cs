using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IOcorrenciaRepository
    {
        public void Adicionar(Ocorrencia ocorrencia);
        public void Remover(int id);
        public void Editar(Ocorrencia ocorrencia);
        public List<Ocorrencia> Listar();
        public Ocorrencia BuscarPorId(int id);
    }
}
