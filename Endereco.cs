using System;

class Endereco {
        private string Cidade {get; set;}
        private string Bairro {get; set;}
        private string Rua {get; set;}
        private int Numero {get; set;} 
        private int Cep {get; set;} 

        public Endereco (string cidade, string bairro, string rua, int numero, int cep) {
                Cidade = cidade;
                Bairro = bairro;
                Rua = rua;
                Numero = numero;
                Cep = cep;
        }

        public string GetCidade() {
                return Cidade;
        }

        public void SetCidade(string novaCidade) {
                Cidade = novaCidade;
        }

        public string GetBairro() {
                return Bairro;
        }

        public void SetBairro(string novoBairro) {
                Bairro = novoBairro;
        }

        public string GetRua() {
                return Rua;
        }

        public void SetRua (string novaRua) {
                Rua = novaRua;
        }

        public int getNumero() {
                return Numero;
        }

        public void SetNumero (int novoNumero) {
                Numero = novoNumero;
        }

        public int GetCep() {
                return Cep;
        }

        public void SetCep (int novoCep) {
                Cep = novoCep;
        }
}