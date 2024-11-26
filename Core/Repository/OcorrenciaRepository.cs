using Dapper.Contrib.Extensions;
using Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class OcorrenciaRepository : IOcorrenciaRepository
    {
        private readonly string ConnectionString;
        public OcorrenciaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Ocorrencia ocorrencia)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Ocorrencia>(ocorrencia);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Ocorrencia ocorrencia = BuscarPorId(id);
            connection.Delete<Ocorrencia>(ocorrencia);
        }
        public void Editar(Ocorrencia ocorrencia)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Ocorrencia>(ocorrencia);
        }
        public List<Ocorrencia> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Ocorrencia>().ToList();
        }
        public Ocorrencia BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Ocorrencia>(id);
        }
    }
}
