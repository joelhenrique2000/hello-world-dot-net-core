
using hello_world_console_dotnet_core.Model;
using hello_world_console_dotnet_core.Repository;
using System;
using System.Linq;

namespace hello_world_console_dotnet_core {
    class Program {
        static void Main(string[] args) {
            PessoaRepository rep = new PessoaRepository();

            // Criando
            rep.Insert(3, "9", "adjo");

            // Atualizando
            rep.Update(3, "atualizado", "00000000000");

            // Listando
            rep.ListALL()
                .ToList()
                .ForEach(pessoa => Console.WriteLine($"{pessoa.Id}. {pessoa.Nome} - {pessoa.Telefone}"));

            // Deletando
            rep.Delete(3);

            // Listando
            rep.ListALL()
                .ToList()
                .ForEach(pessoa => Console.WriteLine($"{pessoa.Id}. {pessoa.Nome} - {pessoa.Telefone}"));
        }
    }
}