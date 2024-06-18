using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Repositorios
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;

        public DbConexao()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=theredfusca;Database=cadastro_pessoas";
            connection = new NpgsqlConnection(connectionString);
        }

        public IDbConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public void Dispose()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();

            connection.Dispose();
        }
    }

}

