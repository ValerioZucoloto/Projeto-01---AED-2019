using System;

class Usuario {
        private string Nome {get; set;}
        private string Cpf {get; set;}
        private string Email {get; set;}
        private Endereco MeuEndereco {get; set;}
        private DateTime DataCadastro {get; set;}

        // Construtor com paramêtros de entrada
        public Usuario (string nome, string cpf, string email, Endereco meuEndereco, DateTime datacadastro) {
			Nome = nome;
			Cpf = cpf;
			Email = email;
			MeuEndereco = meuEndereco;
                        DataCadastro = datacadastro;
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

        public DateTime GetDataCadastro() {
                return DataCadastro;
        }

        public void SetDataCadastro (DateTime data) {
                DataCadastro = data;
        }

        // Métodos principais
        public void cadastrarEndereco(Endereco novoEndereco) {
                MeuEndereco = novoEndereco;
        }

        public void alterarEndereco (Endereco atualizarEndereco) {
                MeuEndereco = atualizarEndereco;
        }

	public static void OpcoesDisponiveis(){
		Console.WriteLine();
		Console.WriteLine("[1] - Ver livros disponíveis");
		Console.WriteLine("[2] - Ver histórico");
		Console.WriteLine("[3] - Sair");
		Console.WriteLine();
	}

        // Método para exibir as informações da classe Usuario
    public string Exibe() {
		return "Nome: " 
		+ Nome 
		+ "\nCodigo usuário: " 
		+ "\nCPF: "
		+ Cpf 
		+ "\nEmail: " 
		+ Email 
		+ "Endereço: "
		+ MeuEndereco;
    }  

}