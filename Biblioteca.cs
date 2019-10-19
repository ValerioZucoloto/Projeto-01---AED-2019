using System;
using System.IO;
using System.Collections.Generic; // Namespace da classe List

class Biblioteca {
        // Atributos
        private string Nome {get; set;}
        private List <Livro> listaLivros;
        private List <Usuario> listaUsuarios;
        private string CNPJ {get; set;}
        private Endereco enderecoBiblioteca {get; set;}
        private Reserva reservarLivros {get; set;}
		private Usuario UsuarioObj { get; set; }

        // Contrutor com parametros de entrada
        public Biblioteca (string nome, List <Livro> livros, List <Usuario> usuario, string cnpj, Endereco endereco) {
                Nome = nome;
                listaLivros = livros;
                listaUsuarios = usuario;
                CNPJ = cnpj;
                enderecoBiblioteca = endereco;
        }

        // Construtor vazio
        public Biblioteca () {

        }

		//Métodos principais
		public static void CadastrarLivro(){
			
		}

		public static void CadastrarUsuario(){
			
		}

		public static void ReservarLivros() {

        }

		public static void OpcoesDisponiveis(){
			Console.WriteLine();
			Console.WriteLine("[1] - Ver livros disponíveis");
			Console.WriteLine("[2] - Cadastrar Usuários");
			Console.WriteLine("[3] - Cadastrar livros");
			Console.WriteLine("[4] - Cancelar Usuários");
			Console.WriteLine("[5] - Sair");
			Console.WriteLine();
		}

		public void CancelarCadastro(){
			
		}

        // Métodos GET / SET

        public string GetNome() {
                return Nome;
        }

        public void SetNome(string nome) {
                Nome = nome;
        }

        public string GetCnpj() {
                return CNPJ;
        }

        public void SetCNPJ (string cnpj) {
                CNPJ = cnpj;
        }

        public Endereco GetenderecoBiblioteca() {
                return enderecoBiblioteca;
        }

        public void SetEnderecoBiblioteca (Endereco novoEndereco) {
                enderecoBiblioteca = novoEndereco;
        }


}