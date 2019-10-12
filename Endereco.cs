using System;

class Endereco {
        public string Cidade {get; set;}
        public string Bairro {get; set;}
        public string Rua {get; set;}
        public int Numero {get; set;} // É possivel alterar o N° da casa
        public int Cep {get; set} // É possivel alterar o CEP da rua

        public Endereco (string cidade, string bairro, string rua, int numero, int cep) {
                Cidade = cidade;
                Bairro = bairro;
                Rua = rua;
                Numero = numero;
                Cep = cep;
        }

        public string GetCidadeBairro() {
                return Cidade + ", " + Bairro;
        }

        public string GetCidade() {
                return Cidade;
        }

        public string GetCidadeBairroRua() {
                return Cidade + ", " + Bairro + ", " + Rua;
        }
}