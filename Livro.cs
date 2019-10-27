using System;

class Livro {

	private string CodLivro { get; set; }
	private string Titulo { get; set; }
	private string Autor { get; set; }
	private string Genero { get; set; }
        private DateTime DataRegistro {get; set;}

	//Construtor com parametros de inicialização
	public Livro(string codLivro, string titulo, string autor, string genero, DateTime dataregistro ){
		CodLivro = codLivro;
		Titulo = titulo;
		Autor = autor;
		Genero = genero;
                DataRegistro = dataregistro;
	}

	//Construtor Vazio 
	public Livro(){}

	public void SetCodLivro(string codLivro){
		CodLivro = codLivro;
	}

	public string getCodLivro(){
		return CodLivro;
	}

	public void SetTitulo(string titulo){
		Titulo = titulo;
	}

	public string getTitulo(){
		return Titulo;
	}

	public void SetAutor(string autor){
		Autor = autor;
	}

	public string getAutor(){
		return Autor;
	}

	public void SetGenero(string genero){
		Genero = genero;
	}

	public string getGenero(){
		return Genero;
	}

        public DateTime GetDataRegistro() {
                return DataRegistro;
        }

        public void SetDataRegistro (DateTime registro) {
                DataRegistro = registro;
        }

}