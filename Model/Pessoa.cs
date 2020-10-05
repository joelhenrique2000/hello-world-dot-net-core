using System;
using System.Collections.Generic;
using System.Text;

namespace hello_world_console_dotnet_core.Model {
    class Pessoa {

        public Pessoa() {

        }

        public Pessoa(string nome, string telefone) {
            Nome = nome;
            Telefone = telefone;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }

    }
}
