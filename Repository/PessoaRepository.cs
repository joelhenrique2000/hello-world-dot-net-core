using Dapper;
using hello_world_console_dotnet_core.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace hello_world_console_dotnet_core.Repository {
    class PessoaRepository {

        private readonly string _connectionString;

        public PessoaRepository() {
            _connectionString = "Server=localhost\\SQLEXPRESS; Database = ESTUDO1; Trusted_Connection = true";
        }

        public IEnumerable<Pessoa> ListALL() {

            using var connection = new SqlConnection(_connectionString);

            var pessoaData = connection.Query<Pessoa>("SELECT * FROM PESSOA");

            return pessoaData;
        }

        public int Insert(long id, string nome, string telefone) {
            using var connection = new SqlConnection(_connectionString);

            var query = "INSERT INTO PESSOA (id, nome, telefone) VALUES (@id, @nome, @telefone)";

            var result = connection.Execute(query, new { id = id, telefone = telefone, nome = nome });

            return result;
        }

        public int Update(long id, string nome, string telefone) {
            using var connection = new SqlConnection(_connectionString);

            var query = "UPDATE PESSOA SET nome = @nome, telefone = @telefone WHERE id = @id";

            var result = connection.Execute(query, new { id = id, telefone = telefone, nome = nome });

            return result;
        }

        public int Delete(long id) {
            using var connection = new SqlConnection(_connectionString);

            var query = "DELETE FROM PESSOA WHERE id = @id";

            var result = connection.Execute(query, new { id = id });

            return result;
        }

    }
}
