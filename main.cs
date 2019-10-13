using System;

class MainClass {
  public static void Main (string[] args) {
        //Classe Usuário
        //Atributos:
                // Nome
                // CodUsuario
                // CPF
                // Email
                // Endereco
        //Metodos:
                //GetEmail -> Return string 
                //SetEmail -> Void (Argumento: string)
                //GetEndereco -> Return Endereco
                //CadastrarEndereco -> Void (Argumento: Endereco)
                //AlterarEndereco -> Void (Argumento: Endereco)
        
        //Classe Livro
        //Atributos:
                // CodLivro
                // Titulo
                // Autor
                // Genero

        //Metedos:
                //GetTitulo -> return string
                //GetAutor -> Return string
                //GetGenero -> Return string

        //Classe Reserva
                //CodReserva
                //DataRecebimento
                //DataDevolucao
                //Livro
                //Usuario
				//Status

        //Metodos:
                //CancelarReserva -> Void (Argumento: Booleano)
                //ProlongarReserva -> Void (Argumento: NovaData)
                // GetReserva (Retorna informações sobre a reserva) 


        //Classe Biblioteca
        //Atributos:
                // Nome
                // List <Livros>
                // List <usuario>
                // CNPJ
                // Endereco
                // Reserva
        //Metodos:
                //CadastrarLivro -> Void (Argumentos: List<Livro>)
                //CadastrarUsuario -> Void (Argumento: Usuario)
                //CancelarCadastro -> Void (Argumento: Usuario)
                
        

        //Classe Endereco
        //Atributos:
                // Cidade
                // Bairro
                // Rua
                // Numero
                // CEP
        //Metodos:
                // GetCidadeBairro -> Return string
                // GetCidade -> Return String
                // GetCidadeBairroRua -> Return String



  }
}