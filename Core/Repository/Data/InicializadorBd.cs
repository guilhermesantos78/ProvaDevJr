using Dapper;
using System;
using System.Data.SQLite;

namespace Core
{
    public static class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Enterprise.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string commandoSQLClientes = @"
                    CREATE TABLE IF NOT EXISTS Clientes(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT,
                        Telefone TEXT,
                        Email TEXT,
                        EnderecoDeContato TEXT
                    );";

                string commandoSQLOcorrencias = @"
                    CREATE TABLE IF NOT EXISTS Ocorrencias(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        DataAbertura DATE,
                        DataDaOcorrencia DATE,
                        Descricao TEXT,
                        ClienteId1 INTEGER,
                        ClienteId2 INTEGER,
                        Conclusao TEXT
                    );";

                connection.Execute(commandoSQLClientes);
                connection.Execute(commandoSQLOcorrencias);
            }
        }
    }
}
