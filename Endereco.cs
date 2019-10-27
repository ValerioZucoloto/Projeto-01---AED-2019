using System;

class Endereco {
        private string Cidade {get; set;}
        private string Bairro {get; set;}
        private string Rua {get; set;}
        private string Numero {get; set;} 
        private string Cep {get; set;} 

        public Endereco (string cidade, string bairro, string rua, string numero, string cep) {
                Cidade = cidade;
                Bairro = bairro;
                Rua = rua;
                Numero = numero;
                Cep = cep;
        }

		public Endereco () {
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

        public string getNumero() {
                return Numero;
        }

        public void SetNumero (string novoNumero) {
                Numero = novoNumero;
        }

        public string GetCep() {
                return Cep;
        }

        public void SetCep (string novoCep) {
                Cep = novoCep;
        }

		public override string ToString() {
			return "Cidade: " 
					+ Cidade 
					+ "\nBairro: "
					+ Bairro 
					+ "\nRua: "
					+ Rua 
					+ "\nNúmero: " 
					+ Numero
					+ "\nCEP: : "
					+ Cep;
    	}

}