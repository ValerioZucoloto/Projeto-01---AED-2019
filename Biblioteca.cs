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

        public void SetCNPJ (string cnjp) {
                CNPJ = cnpj;
        }

        public Endereco GetenderecoBiblioteca() {
                return enderecoBiblioteca;
        }

        public void SetEnderecoBiblioteca (Endereco novoEndereco) {
                enderecoBiblioteca = novoEndereco;
        }

        //Métodos principais





        



}