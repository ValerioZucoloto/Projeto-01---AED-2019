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

        //public static string CadastroLivro = "Livros.txt";
                public static string CadastroUsuario = "Usuarios";
		private static string reservas = "Reservas";
		private static string Livros = "Livros";
        

		//elementos responsavel pelo método de exibir os livros livrosDisponiveis
		//private static string livrosDisponiveis = "livros.txt";
		static string[] vet;
		static string[] line = new string[3];

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
		public static bool ExibirLivrosDisponiveis(){
			bool verifica = false;
			Directory.CreateDirectory("Livros");
			if(Directory.GetFiles("Livros").Length == 0) {
				Console.WriteLine("Nenhum livro cadastrado");
                                
			}else{		
				string[] arquivos = Directory.GetFiles("Livros");
				foreach(string dir in arquivos) {
                	try{
						using(StreamReader sr = File.OpenText(dir)){
							while(!sr.EndOfStream){
								string line = sr.ReadLine();
								Console.WriteLine(line);
							}
						}
					}catch(IOException e){
						Console.WriteLine(e.Message);
					}
            	}

				verifica = true;
			}
			
			return verifica;
		}

		public static void verificaReserva(Reserva reserva, string codLivro) {
			try {
                if(File.Exists("Usuarios/" + reserva.GetUsuarioObj().GetCpf() + ".txt")){
					if(File.Exists("Livros/" + codLivro + ".txt")){
						Console.WriteLine();
						Console.WriteLine("Reserva efetuada com sucesso!");
						using(StreamReader sr = File.OpenText("Livros/" + codLivro + ".txt")) {
							string[] line = File.ReadAllLines("Livros/" + codLivro + ".txt");
							vet = new string[line.Length];
							for(int i = 0; i < line.Length - 1; i++){
								vet[i] = sr.ReadLine();
							}
                		}
						ReservarLivro(reserva);
					}else{
						Console.WriteLine("Código do livro inválido");
					}
				}else{
						Console.WriteLine();
						Console.WriteLine("CPF inválido ou não cadastrado");
					}
            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }

		private static void ReservarLivro(Reserva reserva){

			Livro livro = new Livro();
			livro.SetCodLivro(vet[0]);
			livro.SetTitulo(vet[1]);
			livro.SetAutor(vet[2]);
			livro.SetGenero(vet[3]);

			reserva.SetLivro(livro);

			try {

				//Caminho da pasta Reservas
				Directory.CreateDirectory(reservas);

				//Cria do arquivo do usuario
				string minhaReserva = reserva.GetUsuarioObj().GetCpf().Replace(".", "").Replace("-", "") + ".txt";

				using(StreamWriter sw = File.AppendText(reservas + "/" + minhaReserva)) {
					sw.WriteLine("*************** INFORMAÇÕES DO LIVRO ****************");
					sw.WriteLine(reserva.GetLivro().getCodLivro());
					sw.WriteLine(reserva.GetLivro().getTitulo());
					sw.WriteLine(reserva.GetLivro().getAutor());
					sw.WriteLine(reserva.GetLivro().getGenero());
					sw.WriteLine("*************** INFORMAÇÕES DO USUÁRIO ****************");
					sw.WriteLine("Nome Usuário: " + reserva.GetUsuarioObj().GetNome());
					sw.WriteLine("CPF: " + reserva.GetUsuarioObj().GetCpf());
					sw.WriteLine("E-mail: " + reserva.GetUsuarioObj().GetEmail());
					sw.WriteLine("*************** INFORMAÇÕES DO RESERVA ****************");
					sw.WriteLine("Data: " + reserva.GetDataRecebimento());
					sw.WriteLine("Devolução: " + reserva.GetDataDevolucao());
					sw.WriteLine();
				}

			}
			catch(IOException e) {
				Console.WriteLine(e.Message);
			}
			
		}

		public static void CadastrarLivro(List<Livro> listaLivros){
			Directory.CreateDirectory("Livros");
			foreach(Livro L in listaLivros){
				string cod = L.getCodLivro();
				try{
					using(StreamWriter sw = File.AppendText("Livros/" + cod + ".txt")){
						sw.WriteLine("Código: " + L.getCodLivro());
						sw.WriteLine("Titulo: " + L.getTitulo());
						sw.WriteLine("Autor: " + L.getAutor());
						sw.WriteLine("Genero: " + L.getGenero());
                                                sw.WriteLine ("Cadastro realizado em: " + L.GetDataRegistro());
						sw.WriteLine();
					}
				}catch(IOException e){
					Console.WriteLine(e.Message);
				}
			}
			listaLivros.Clear();
		}

		public static void CadastrarUsuario(Usuario novoUsuario){
				try {
				
				string meuUsuario = novoUsuario.GetCpf().Replace(".", "").Replace("-", "") + ".txt";               
							using (StreamWriter sw = File.AppendText ("Usuarios/" + meuUsuario)) {                                                      
								sw.WriteLine ("********** INFORMAÇÕES DE PERFIL **********");
								sw.WriteLine ("Nome: " + novoUsuario.GetNome());
								sw.WriteLine ("CPF: " + novoUsuario.GetCpf());
								sw.WriteLine ("E-mail: " + novoUsuario.GetEmail());
								sw.WriteLine ("********** INFORMAÇÕES DO ENDEREÇO **********");
								sw.WriteLine (novoUsuario.GetEndereco());
                                                                sw.WriteLine ("Cadastro realizado em: " + novoUsuario.GetDataCadastro());
							}	
				
				}
					catch (IOException e) {
							Console.WriteLine ("Ocorreu um erro !");
							Console.WriteLine (e.Message);
			}                      
		}

		public static void OpcoesDisponiveis(){
			Console.WriteLine();
			Console.WriteLine("[1] - Ver livros Cadastrados");
			Console.WriteLine("[2] - Cadastrar Usuários");
			Console.WriteLine("[3] - Cadastrar livros");
			Console.WriteLine("[4] - Exibir cadastro do usuário");
                        Console.WriteLine ("[5] - Excluir usuários");
                        Console.WriteLine ("[6] - Excluir livros");
			Console.WriteLine("[7] - Sair");
			Console.WriteLine();
		}

        // Método para ver histórico de reservas
        public static void HistoricoReservas(string Cpf) {
                try{
			using(StreamReader sr = File.OpenText("Reservas/" + Cpf + ".txt")){
				while(!sr.EndOfStream) {
                                        string line = sr.ReadLine(); ;
                                        Console.WriteLine(line);
                                }
			}

		}
                catch(IOException e) {
                    Console.WriteLine("CPF INVÁLIDO !");
                }

                               
        }

        public static void ExibirCadastroUsuario(string cpf) {
			if(File.Exists("Usuarios/" + cpf + ".txt")){
				try{
					using(StreamReader sr = File.OpenText(CadastroUsuario + "/" + cpf + ".txt")){
						while(!sr.EndOfStream) {
							string line = sr.ReadLine();
							Console.WriteLine(line);
						}
					}                   
				}catch(IOException e) {
					Console.WriteLine(e.Message);	
				} 
			}else{
				Console.WriteLine ("CPF inválido ou não cadastrado");
			}
        }

                //Método para deletar usuário registrado
                public static void DeletarUsuario(string cpf){
                        if(File.Exists(CadastroUsuario + "/" + cpf + ".txt")) {
                                try {
                                 File.Delete("Usuarios/" + cpf + ".txt");
                                        Console.WriteLine();
                                        Console.WriteLine("Usuário excluído!");
                        }
                                catch(IOException e) {
                                        Console.WriteLine(e.Message);
                                }
                }
                        else {
                        Console.WriteLine("CPF inválido, digite novamente: ");
                        }
                }

                //Método para deletar livro registrado
                public static void DeletarLivro(string codigo){
                        if(File.Exists(Livros + "/" + codigo + ".txt")) {
                                try {
                                 File.Delete("Livros/" + codigo + ".txt");
                                        Console.WriteLine();
                                        Console.WriteLine("Livro excluído!");
                        }
                                catch(IOException e) {
                                        Console.WriteLine(e.Message);
                                }
                }
                        else {
                        Console.WriteLine("Código inválido, digite novamente: ");
                        }
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