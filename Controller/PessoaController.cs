using hello_world_console_dotnet_core.Model;
using hello_world_console_dotnet_core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace hello_world_console_dotnet_core.Controller {
    class PessoaController {
        private readonly PessoaRepository _repository;

        public PessoaController() {
            _repository = new PessoaRepository();
        }

        public IEnumerable<Pessoa> GetAll() {
            return _repository.ListALL();
        }

        public int Create(long id, string nome, string telefone) {
            return _repository.Insert(id, nome, telefone);
        }

        public int Update(long id, string nome, string telefone) {
            return _repository.Update(id, nome, telefone);
        }

        public int Delete(long id) {
            return _repository.Delete(id);
        }
    }
}
