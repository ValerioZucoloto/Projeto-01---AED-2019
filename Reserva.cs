using System;

class Reserva {

	private string CodReserva { get; set; }
        private DateTime DataRecebimento { get; set; }
        private DateTime DataDevolucao { get; set; }
        private Livro LivroObj { get; set; }
        private Usuario UsuarioObj { get; set; }
		private bool Status { get; set; } 

        //Construtor com parâmetros de inicialização
        public Reserva(string codReserva, DateTime dataRecebimento, DateTime dataDevolucao, Livro livroObj, Usuario usuarioObj) {
            CodReserva = codReserva;
            DataRecebimento = dataRecebimento;
            DataDevolucao = dataDevolucao;
            LivroObj = livroObj;
            UsuarioObj = usuarioObj;
			Status = true;
        }

        //Construtor Vazio
        public Reserva() {
        }

		/*************** METODOS PRINCIPAIS ***************/

		public void CancelarReserva(bool status){
			Status = status;
		}

		public void ProlongarReserva(DateTime dataDevolucao){
			DataDevolucao = dataDevolucao;
		}

		public void GetReserva(){
			Console.WriteLine(GetInformacoesReserva());
		}

		public string GetInformacoesReserva(){
			return "Código Reserva: " 
				+ CodReserva 
				+ "\nData do recebimento: "
				+ DataRecebimento
				+ "\nData da Devolução: "
				+ DataDevolucao
				+ "\nLivro: "
				+ LivroObj.getTitulo()
				+ "\nUsuário: " 
				+ UsuarioObj.GetNome();
		}

		/*************** METODOS GET AND SET ***************/

		public string GetCodReserva() {
            return CodReserva;
        }

        public void SetCodReserva(string codReserva) {
            CodReserva = codReserva;
        }

		public DateTime GetDataRecebimento() {
            return DataRecebimento;
        }

		public void SetDataRecebimento(DateTime dataRecebimento) {
            DataRecebimento = dataRecebimento;
        }

		public DateTime GetDataDevolucao() {
            return DataDevolucao;
        }

		public void SetDataDevolucao(DateTime dataDevolucao) {
            DataDevolucao = dataDevolucao;
        }

		public Livro GetLivro() {
            return LivroObj;
        }

		public void SetLivro(Livro livro) {
            LivroObj = livro;
        }

		public Usuario GetUsuarioObj() {
            return UsuarioObj;
        }

		public void SetUsuario(Usuario usuario) {
            UsuarioObj = usuario;
        }

}