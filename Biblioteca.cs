using System;
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

		private string livros = "livros.txt"

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
		public void CadastrarLivro(Livro livro){
			try {
                using(StreamWriter sw = File.AppendText(livros)) {

                    foreach(Livro obj in listaLivros) {
                        sw.WriteLine("Código Livro: " + obj.getCodLivro());
                        sw.WriteLine("Titulo: " + obj.getTitulo());
						sw.WriteLine("Autor: " + obj.getAutor());
						sw.WriteLine("Gênero: " + obj.getGenero());
                        sw.WriteLine();
                    }

                }

            }catch(IOException e) {
                Console.WriteLine(e.Message);
            }
		}

		public void CadastrarUsuario(Usuario usuario){
			UsuarioObj.SetStatus("Cancelado");
		}

		public void CancelarCadastro(Usuario usuario){
			listaUsuarios.Add(usuario);
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