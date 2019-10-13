using System;

class Usuario {
        private string Nome {get; set;}
        private int CodUsuario {get; private set;}
        private string Cpf {get; private set;}
        private string Email {get; set;}
        private Endereco MeuEndereco {get; set;}

        // Construtor com paramêtros de entrada
        public Usuario (string nome, int cod, string cpf, string email, Endereco meuEndereco) {
                Nome = nome;
                CodUsuario = cod;
                Cpf = cpf;
                Email = email;
                MeuEndereco = meuEndereco;
        }

        // Construtor vazio
        public Usuario() {

        }

        // Métodos Get / Set
        public string GetNome() {
                return Nome;
        }

        public void SetNome (string novoNome) {
                Nome = novoNome;
        }

        public int GetCodUsuario(){
                return CodUsuario;
        }

        public void SetCodUsuario (int novoCod) {
                CodUsuario = novoCod;
        }

        public string GetCpf() {
                return Cpf;
        }

        public void SetCpf (string novoCpf) {
                Cpf = novoCpf;
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

        // Métodos principais
        public void cadastrarEndereco(Endereco novoEndereco) {
                MeuEndereco = novoEndereco;
        }

        public void alterarEndereco (Endereco atualizarEndereco) {
                MeuEndereco = atualizarEndereco;
        }

        // Método para exibir as informações da classe Usuario
        public string Exibe() {
                return "Nome: " 
                + Nome 
                + "\nCodigo usuário: " 
                + CodUsuario 
                + "\nCPF: "
                + Cpf 
                + "\nEmail: " 
                + Email 
                + "Endereço: "
                + MeuEndereco;
        }




        

}