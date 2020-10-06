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
        //public IEnumerable<Pessoa> ListALL() {
            
        //    using var connection = new SqlConnection("Server=localhost; Database = ESTUDO1; Trusted_Connection = true");

        //    var pessoaData = connection.Query<Pessoa>("SELECT * FROM PESSOA");

        //    return pessoaData;
        //}

        public int Insert(long id, string nome, string telefone) {
            using var connection = new SqlConnection("Server=localhost\\SQLEXPRESS; Database = ESTUDO1; Trusted_Connection = true");
            var pessoaData = connection.Query<Pessoa>("SELECT * FROM PESSOA").ToList();

            pessoaData.ForEach(el => Console.WriteLine(el.Nome));
            return 9;
        }

    }
}
