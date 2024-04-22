namespace Biblioteca;

class Program
{
	static void Main(string[] args)
	{
		Livro livro1 = new Livro();
		LivroDigital livroD1 = new LivroDigital();
		
		livroD1.AdicionarEstoque();
		livro1.AdicionarEstoque();
		
		Console.WriteLine(livro1.getEstoque());
	}
}
