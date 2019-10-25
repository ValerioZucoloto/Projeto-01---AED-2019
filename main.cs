using System;

class MainClass {
    public static void Main(string[] args) {

		Usuario usuario = new Usuario();
		Reserva reserva = new Reserva();

        Console.WriteLine();

        Console.WriteLine("--------------- LOGIN ---------------");
        Console.Write("Usuário: ");
        string login = Console.ReadLine();
        Console.Write("Senha: ");
        int senha = int.Parse(Console.ReadLine());

        while(login != "usuario" && senha != 123 || login != "admin" && senha != 123) {

            Console.WriteLine();

            Console.WriteLine("Senha Inválida!");

            Console.WriteLine();

            Console.WriteLine("--------------- LOGIN ---------------");
            Console.Write("Usuário: ");
            login = Console.ReadLine();
            Console.Write("Senha: ");
            senha = int.Parse(Console.ReadLine());

        }

        	if(login == "usuario" && senha == 123) {

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

							Biblioteca.ExibirLivrosDisponiveis();

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

							usuario.SetNome(nomeUser);
							usuario.SetCpf(cpfUser);
							usuario.SetEmail(emailUser);

							reserva.SetUsuario(usuario);
							Biblioteca.verificaReserva(reserva, codLivro);

							Usuario.OpcoesDisponiveis();
							
							Console.Write("Escolha a opção: ");
                    		                        escolha = int.Parse(Console.ReadLine());

						break;

                                                case 2:
                                                        
                                                        Console.WriteLine();
                                                        Console.WriteLine ("Informe o CPF: ");
                                                        string Cpf = Console.ReadLine();
                                                        
                                                        bool valor = Biblioteca.HistoricoReservas(Cpf);

                                                        Usuario.OpcoesDisponiveis();
							Console.Write("Escolha a opção: ");
                    		                        escolha = int.Parse(Console.ReadLine());

                                                                                                             
                                                        
                                                break;
					}

                                                

				}

        	}
        	else if(login == "admin" && senha == 123) {

            	Biblioteca.OpcoesDisponiveis();

            	Console.Write("Escolha a opção: ");
            	int escolha = int.Parse(Console.ReadLine());

            	if(escolha < 1 || escolha > 5 && escolha != 6) {

                	Console.WriteLine();
                	Console.WriteLine("Opção Inválida");

                	Biblioteca.OpcoesDisponiveis();

                	Console.Write("Escolha a opção: ");
                	escolha = int.Parse(Console.ReadLine());

                	while(escolha < 1 || escolha > 5) {

                    	Console.WriteLine();
                    	Console.WriteLine("Opção Inválida");

                    	Biblioteca.OpcoesDisponiveis();

                    	Console.Write("Escolha a opção: ");
                    	escolha = int.Parse(Console.ReadLine());

                	}

            	}

			while(escolha != 6) {

                	switch(escolha) {
						case 1:

							Console.WriteLine();
							Biblioteca.ExibirLivrosDisponiveis();

							Biblioteca.OpcoesDisponiveis();
							Console.WriteLine();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 5) {

								Console.WriteLine();
								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());

							}
							break;

							break;
                    	case 2:
							Console.WriteLine();
							Console.Write("Nome: ");
							string nome = Console.ReadLine();
							Console.Write("CPF: ");
							string cpf = Console.ReadLine();
							Console.Write("E-mail: ");
							string email = Console.ReadLine();

							Usuario newUsuario = new Usuario();
							newUsuario.SetNome(nome);
							newUsuario.SetCpf(cpf);
							newUsuario.SetEmail(email);

							Biblioteca.CadastrarUsuario(newUsuario);

							Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 5) {

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

							Biblioteca.CadastrarLivro(livro);

							Biblioteca.OpcoesDisponiveis();

							Console.Write("Escolha a opção: ");
							escolha = int.Parse(Console.ReadLine());

							while(escolha < 1 || escolha > 5) {

								Console.WriteLine();
								Console.WriteLine("Opção Inválida");

								Biblioteca.OpcoesDisponiveis();

								Console.Write("Escolha a opção: ");
								escolha = int.Parse(Console.ReadLine());

							}
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

							while(escolha < 1 || escolha > 5) {

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

    }
}