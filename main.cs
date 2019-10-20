using System;
using System.IO;

class MainClass {
    public static void Main(string[] args) {

            Usuario Valerio = new Usuario ("Valério");
            Biblioteca.CadastrarUsuario (Valerio);

            Livro meuLivro = new Livro ("156", "TARZAN", "LINCON", "AVENTURA");
            Biblioteca.CadastrarLivro (meuLivro);


        /*Console.WriteLine();

        string usuario = "usuario";
        int senhaUsuario = 123;

        string admin = "admin";
        int senhaAdmin = 123;

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

            

        }
        else if(login == "admin" && senha == 123) {

            Biblioteca.OpcoesDisponiveis();

            Console.Write("Escolha a opção: ");
            int escolha = int.Parse(Console.ReadLine());

            if(escolha < 1 || escolha > 5) {

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

            while(escolha != 5) {

                //Console.WriteLine();
                //Console.WriteLine("Opção Inválida");

                //Biblioteca.OpcoesDisponiveis();

                //Console.Write("Escolha a opção: ");
                //escolha = int.Parse(Console.ReadLine());

                switch(escolha) {
                    case 2:
                        
			//Aqui ficará a chamada para o método

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

			//Aqui ficará a chamada para o método
                        
                        break;
                }

            }

        }
        Console.WriteLine();
        Console.WriteLine("Programa encerrado!");
        Console.WriteLine();*/

    }
}