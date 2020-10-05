using hello_world_console_dotnet_core.Model;
using System;

namespace hello_world_console_dotnet_core {
    class Program {
        static void Main(string[] args) {


            while (true) {

                Console.WriteLine("Digite o nome da pessoa: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o telefone da pessoa: ");
                string telefone = Console.ReadLine();

                Console.Clear();

                Pessoa pessoa = new Pessoa(nome, telefone);

                Console.WriteLine($"1. {nome} - {telefone}");

                Console.WriteLine("\n\n\n----------------------\nVocê desesa adicionar outra pessoa? (S/n)? ");
                string condicaoSaida = Console.ReadLine();

                if(condicaoSaida == "N" || condicaoSaida == "n") {
                    break;
                }

                Console.Clear();
               
            }
        }
    }
}
