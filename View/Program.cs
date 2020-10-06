
using hello_world_console_dotnet_core.Controller;
using hello_world_console_dotnet_core.Model;
using hello_world_console_dotnet_core.Repository;
using System;
using System.Linq;

namespace hello_world_console_dotnet_core {
    class Program {
        static void Main(string[] args) {
            PessoaController controller = new PessoaController();

            // Criando
            controller.Create(3, "Joel", "12345678910");

            // Atualizando
            controller.Update(3, "Joel Henrique", "87996698428");

            // Deletando
            controller.Delete(2);

            // Listando
            controller
                .GetAll()
                .ToList()
                .ForEach(pessoa => Console.WriteLine($"{pessoa.Id}. {pessoa.Nome} - {pessoa.Telefone}"));
        }
    }
}