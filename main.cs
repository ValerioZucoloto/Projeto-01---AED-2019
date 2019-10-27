using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

class MainClass {
    public static void Main(string[] args) {

		Console.Clear();

		Usuario usuario = new Usuario();
		Endereco endereco = new Endereco();
		Reserva reserva = new Reserva();
                List <Livro> novosLivros = new List<Livro>();
		DateTime data = DateTime.Now;
                DateTime cadastro = DateTime.Now;
                DateTime registro = DateTime.Now;

        Console.WriteLine();

        Console.WriteLine("--------------- LOGIN ---------------");
        Console.Write("Usuário: ");
        string login = Console.ReadLine();

        while(login != "usuario" && login != "admin") {

            Console.WriteLine();

			Console.Clear();
            Console.WriteLine("Login inválido");

            Console.WriteLine();

            Console.WriteLine("--------------- LOGIN ---------------");
            Console.Write("Login: ");
            login = Console.ReadLine();

        }

        	if(login == "usuario") {

            	Usuario.OpcoesDisponiveis();

				Console.Write("Escolha a opção: ");
             	int escolha = int.Parse(Console.ReadLine());

			if(escolha < 1 || escolha > 3) {

                	Console.WriteLine();
                	Console.WriteLine("Opção Inválida");

                	Usuario.OpcoesDisponiveis();

                	Console.Write("Escolha a opção: ");
                	escolha = int.Parse(Console.ReadLine());

                	while(escolha < 1 || escolha > 3) {

                    	Console.WriteLine();
                    	Console.WriteLine("Opção Inválida");

                    	Usuario.OpcoesDisponiveis();

                    	Console.Write("Escolha a opção: ");
                    	escolha = int.Parse(Console.ReadLine());
                	}

            	}

				while(escolha != 3) {

					switch(escolha){
						case 1:
							Console.WriteLine();

								if(Biblioteca.ExibirLivrosDisponiveis()){
									Console.WriteLine();
									
									Console.Write("Deseja Reservar [S/N]: ");
									char resp = char.Parse(Console.ReadLine());

									if(resp == 'S' || resp == 's'){
										Console.WriteLine();
										Console.Write("Código do livro: ");
										string codLivro = Console.ReadLine();

										Console.WriteLine();
										Console.Write("Nome Usuário: ");
										string nomeUser = Console.ReadLine();
										Console.Write("CPF Usuário: ");
										string cpfUser = Console.ReadLine();
										Console.Write("Email Usuário: ");
										string emailUser = Console.ReadLine();
										Console.Write("Por quantos dias deseja ler o livro: ");
										int devolucao = int.Parse(Console.ReadLine());

										usuario.SetNome(nomeUser);
										usuario.SetCpf(cpfUser);
										usuario.SetEmail(emailUser);

										reserva.SetUsuario(usuario);
										reserva.SetDataRecebimento(data);
										DateTime dataDevolucao = data.AddDays(devolucao);
										reserva.SetDataDevolucao(dataDevolucao);

										Console.WriteLine();
										Biblioteca.verificaReserva(reserva, codLivro);
										
										Usuario.OpcoesDisponiveis();
										
										Console.Write("Escolha a opção: ");
										escolha = int.Parse(Console.ReadLine());

										while(escolha < 1 || escolha > 3) {

											Console.WriteLine();
											Console.WriteLine("Opção Inválida");

											Usuario.OpcoesDisponiveis();

											Console.Write("Escolha a opção: ");
											escolha = int.Parse(Console.ReadLine());
										}	
									}else{
										Usuario.OpcoesDisponiveis();

										Console.Write("Escolha a opção: ");
										escolha = int.Parse(Console.ReadLine());

										while(escolha < 1 || escolha > 3) {

											Console.WriteLine();
											Console.WriteLine("Opção Inválida");

											Usuario.OpcoesDisponiveis();

											Console.Write("Escolha a opção: ");
											escolha = int.Parse(Console.ReadLine());
										}
									}

								}else{
									Usuario.OpcoesDisponiveis();

										Console.Write("Escolha a opção: ");
										escolha = int.Parse(Console.ReadLine());

										while(escolha < 1 || escolha > 3) {

											Console.WriteLine();
											Console.WriteLine("Opção Inválida");

											Usuario.OpcoesDisponiveis();

											Console.Write("Escolha a opção: ");
											escolha = int.Parse(Console.ReadLine());
										}
								}
									
							break;

                            case 2:

								Console.WriteLine();
								Console.Write ("Informe o CPF: ");
								string cpf = Console.ReadLine();

								if(File.Exists("Reservas/" + cpf + ".txt")){
									Console.WriteLine();
									Biblioteca.HistoricoReservas(cpf);
                                                                        Usuario.OpcoesDisponiveis();
									Console.Write("Escolha a opção: ");
									escolha = int.Parse(Console.ReadLine());

									while(escolha < 1 || escolha > 3) {

										Console.WriteLine();
										Console.WriteLine("Opção Inválida");

										Usuario.OpcoesDisponiveis();

										Console.Write("Escolha a opção: ");
										escolha = int.Parse(Console.ReadLine());
									}
								}else{

									Console.WriteLine();
									Console.WriteLine("CPF inválido ou não tem histórico");

									Usuario.OpcoesDisponiveis();
									Console.Write("Escolha a opção: ");
									escolha = int.Parse(Console.ReadLine());

									while(escolha < 1 || escolha > 3) {

										Console.WriteLine();
										Console.WriteLine("Opção Inválida");

										Usuario.OpcoesDisponiveis();

										Console.Write("Escolha a opção: ");
										escolha = int.Parse(Console.ReadLine());
									}

								}
								break;

					}                          

				}

        	}
        	else if(login == "admin") {

            	Biblioteca.OpcoesDisponiveis();

            	Console.Write("Escolha a opção: ");
            	int escolha = int.Parse(Console.ReadLine());

            	if(escolha < 1 || escolha > 7) {

                	Console.WriteLine();
                	Console.WriteLine("Opção Inválida");

                	Biblioteca.OpcoesDisponiveis();

                	Console.Write("Escolha a opção: ");
                	escolha = int.Parse(Console.ReadLine());

                	while(escolha < 1 || escolha > 7) {

                    	Console.WriteLine();
                    	Console.WriteLine("Opção Inválida");

                    	Biblioteca.OpcoesDisponiveis();

                    	Console.Write("Escolha a opção: ");
                    	escolha = int.Parse(Console.ReadLine());

                	}

            	}

			while(escolha != 7) {

                	switch(escolha) {
						case 1:

							Console.WriteLine();

							Console.Clear();
							Biblioteca.ExibirLivrosDisponiveis();
							
							Biblioteca.OpcoesDisponiveis();
							Console.WriteLine();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							
							while(escolha < 1 || escolha > 7) {
								Console.Clear();

								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());
							}
							break;
                    	case 2:
							Console.WriteLine();
							Console.Write("Nome: ");
							string nome = Console.ReadLine();
							Console.Write("CPF: ");
							string cpf = Console.ReadLine();
							Console.Write("E-mail: ");
							string email = Console.ReadLine();

							Console.WriteLine();
							Console.Write("Endereço: ");
							string rua = Console.ReadLine();
							Console.Write("Bairro: ");
							string bairro = Console.ReadLine();
							Console.Write("Cidade: ");
							string cidade = Console.ReadLine();
							Console.Write("Número: ");
							string numero = Console.ReadLine();
							Console.Write("CEP: ");
							string cep = Console.ReadLine();

							endereco.SetCidade(cidade);
							endereco.SetBairro(bairro);
							endereco.SetRua(rua);
							endereco.SetNumero(numero);
							endereco.SetCep(cep);

							usuario.SetNome(nome);
							usuario.SetCpf(cpf);
							usuario.SetEmail(email);
							usuario.cadastrarEndereco(endereco);

                                                        usuario.SetDataCadastro(cadastro);

							if(!File.Exists("Usuarios")){
								Directory.CreateDirectory("Usuarios");
								Biblioteca.CadastrarUsuario(usuario);
							}else{
								Biblioteca.CadastrarUsuario(usuario);
							}

							Console.Clear();

							Console.WriteLine("Cadastro efetuado com sucesso!");

							Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 7) {

								Console.WriteLine();
								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());

							}
							break;
						case 3:

							Console.WriteLine();
							Console.Write("Código: ");
							string codigo = Console.ReadLine();
							Console.Write("Titulo: ");
							string titulo = Console.ReadLine();
							Console.Write("Autor: ");
							string autor = Console.ReadLine();
							Console.Write("Genero: ");
							string genero = Console.ReadLine();

							Livro livro = new Livro();
							livro.SetCodLivro(codigo);
							livro.SetTitulo(titulo);
							livro.SetAutor(autor);
							livro.SetGenero(genero);

                                                        livro.SetDataRegistro(registro);

							novosLivros.Add (livro);

							Console.WriteLine();
							Console.Write ("Deseja cadastrar um novo livro [S/N]: ");
							char opcoes = char.Parse(Console.ReadLine());

							while(opcoes == 'S' || opcoes == 's') {

								Console.WriteLine();
								Console.Write("Código: ");
								codigo = Console.ReadLine();
								Console.Write("Titulo: ");
								titulo = Console.ReadLine();
								Console.Write("Autor: ");
								autor = Console.ReadLine();
								Console.Write("Genero: ");
								genero = Console.ReadLine();
								Console.WriteLine();

								livro = new Livro();
								livro.SetCodLivro(codigo);
								livro.SetTitulo(titulo);
								livro.SetAutor(autor);
								livro.SetGenero(genero);
								
								novosLivros.Add (livro);

								Console.Write ("Deseja cadastrar um novo livro ? (S/N)");
								opcoes = char.Parse(Console.ReadLine());
							}

							Biblioteca.CadastrarLivro(novosLivros);
							novosLivros.Clear();

                            Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());
                                                        
                            break;

							case 4:
							Console.WriteLine();	

							Console.Write("Informe o CPF: ");
							cpf = Console.ReadLine();

							Console.WriteLine();
							Biblioteca.ExibirCadastroUsuario(cpf);

							Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 7) {

								Console.WriteLine();
								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());
								Usuario.OpcoesDisponiveis();
								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());

							}
							break;

							case 5:

							Console.WriteLine();
							Console.Write("Digite o CPF: ");
           					        cpf = Console.ReadLine().Replace(".", "").Replace("-", "").Trim();

							Biblioteca.DeletarUsuario(cpf);

							Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 7) {

								Console.WriteLine();
								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());
                                                                Usuario.OpcoesDisponiveis();
								Console.Write("Escolha a opção: ");
                    		                                escolha = int.Parse(Console.ReadLine());

							}

							break;

                                                        case 6:

							Console.WriteLine();
							Console.Write("Digite o código: ");
           					        codigo = Console.ReadLine();

							Biblioteca.DeletarLivro(codigo);

							Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 7) {

								Console.WriteLine();
								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());
                                                                Usuario.OpcoesDisponiveis();
								Console.Write("Escolha a opção: ");
                    		                                escolha = int.Parse(Console.ReadLine());

							}

							break;

                		}
            	}

        	}

			Console.WriteLine();
			Console.WriteLine("Volte sempre!");

    }
}