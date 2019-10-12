using System;

class Usuario {
        public string Nome {get; set;}
        public int CodUsuario {get; private set;}
        public string Cpf {get; private set;}
        public string Email {get; set;}
        public Endereco MeuEndereco {get; set;}

        public Usuario (string nome, int cod, string cpf, string email) {
                Nome = nome;
                CodUsuario = cod;
                Cpf = cpf;
                Email = email;
        }

        public Usuario() {

        }

        public string GetEmail() {
                return Email;
        }

        public void SetEmail (string email) {
                Email = email
        }
        
        public Endereco GetEndereco() {
                return MeuEndereco;
        }

        public void cadastrarEndereco(Endereco novoEndereco) {
                MeuEndereco = novoEndereco;
        }

        public void alterarEndereco (Endereco atualizarEndereco) {
                MeuEndereco = atualizarEndereco;
        }


        

}