using System;

class Usuario {
        private string Nome {get; set;}
        private int CodUsuario {get; set;}
        private string Cpf {get; set;}
        private string Email {get; set;}
        private Endereco MeuEndereco {get; set;}
	private string Status { get; set; }

        // Construtor com paramêtros de entrada
        public Usuario (string nome, int cod, string cpf, string email, Endereco meuEndereco) {
                Nome = nome;
                CodUsuario = cod;
                Cpf = cpf;
                Email = email;
                MeuEndereco = meuEndereco;
		Status = "Ativo";
        }

        public Usuario (string nome) {
                Nome = nome;
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
                Email = email;
        }
        
        public Endereco GetEndereco() {
                return MeuEndereco;
        }

		public void SetStatus(string status) {
                Status = status;
        }
        
        public string GetStatus() {
                return Status;
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