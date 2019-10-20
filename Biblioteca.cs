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

        public static string CadastroLivro = "Livros.txt";
        public static string CadastroUsuario = "Usuarios.txt";
		private static string reservas = "Reservas";

		//elementos responsavel pelo método de exibir os livros livrosDisponiveis
		//private static string livrosDisponiveis = "livros.txt";
		static string[] vet = new string[3];

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
		public static void ExibirLivrosDisponiveis(){
			try{
				using(StreamReader sr = File.OpenText(CadastroLivro)){
					while(!sr.EndOfStream) {
                        string line = sr.ReadLine(); ;
                        Console.WriteLine(line);
                    }
				}
			}catch(IOException e) {
                Console.WriteLine(e.Message);
            }
		}

		public static void verificaReserva(Reserva reserva, string codLivro) {
			try {
                using(StreamReader sr = File.OpenText(CadastroLivro)) {
                    while(!sr.EndOfStream) {
                        string line = sr.ReadLine(); ;
                        if(line.Equals(codLivro)) {
							for(int i = 0; i < vet.Length; i++) {
                               vet[i] = sr.ReadLine();
                            }
							ReservarLivro(reserva, codLivro, vet);
							break;
                        }else{
							Console.WriteLine();
                            Console.WriteLine("Código do livro não encontrado.");
							break;
						}
                    }
                }
            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }

		private static void ReservarLivro(Reserva reserva, string codLivro, string[] vet){

			Livro livro = new Livro();
			livro.SetCodLivro(codLivro);
			livro.SetTitulo(vet[0]);
			livro.SetAutor(vet[1]);
			livro.SetGenero(vet[2]);

			reserva.SetLivro(livro);

			try {

            //Caminho da pasta Reservas
            Directory.CreateDirectory(reservas);

			//Cria do arquivo do usuario
			string minhaReserva = reserva.GetUsuarioObj().GetCpf().Replace(".", "").Replace("-", "") + ".txt";

            using(StreamWriter sw = File.AppendText(reservas + "/" + minhaReserva)) {
                sw.WriteLine("*************** INFORMAÇÕES DO LIVRO ****************");
                sw.WriteLine("Código Livro: " + reserva.GetLivro().getCodLivro());
                sw.WriteLine("Nome Livro: " + reserva.GetLivro().getTitulo());
                sw.WriteLine("Autor Livro: " + reserva.GetLivro().getAutor());
                sw.WriteLine("Genero: " + reserva.GetLivro().getGenero());
                sw.WriteLine("*************** INFORMAÇÕES DO USUÁRIO ****************");
                sw.WriteLine("Nome Usuário: " + reserva.GetUsuarioObj().GetNome());
                sw.WriteLine("CPF: " + reserva.GetUsuarioObj().GetCpf());
                sw.WriteLine("E-mail: " + reserva.GetUsuarioObj().GetEmail());
				sw.WriteLine();
            }

        }
        catch(IOException e) {
            Console.WriteLine(e.Message);
        }
			
		}

		public static void CadastrarLivro(Livro novoLivro){
                        try {
                                using (StreamWriter escrita = File.AppendText (CadastroLivro)) {
                                        escrita.WriteLine (novoLivro.getCodLivro());
                                        escrita.WriteLine (novoLivro.getTitulo());
                                        escrita.WriteLine (novoLivro.getAutor());
                                        escrita.WriteLine (novoLivro.getGenero());
										escrita.WriteLine();
                                }
                        }
                        catch (IOException e) {
                                Console.WriteLine ("Ocorreu um erro !");
                                Console.WriteLine (e.Message);
                        }
			
		}

		public static void CadastrarUsuario(Usuario novoUsuario){
                        try {
                                using (StreamWriter sw = File.AppendText (CadastroUsuario)) {
                                        sw.WriteLine (novoUsuario.GetNome());
                                        sw.WriteLine (novoUsuario.GetCpf());
                                        sw.WriteLine (novoUsuario.GetEmail());
                                        sw.WriteLine (novoUsuario.GetEndereco());
                                        sw.WriteLine (novoUsuario.GetStatus());
										sw.WriteLine();
                                }
                        }  
                        catch (IOException e) {
                                Console.WriteLine ("Ocorreu um erro !");
                                Console.WriteLine (e.Message);
                        }                      
		}

		public static void ReservarLivros() {

        }

		public static void OpcoesDisponiveis(){
			Console.WriteLine();
			Console.WriteLine("[1] - Ver livros Cadastrados");
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