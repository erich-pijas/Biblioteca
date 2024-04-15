public class Livro
{
	public string titulo;
	public string autor;
	public int isbn;
	public int estoque;
	
		public AdicionarEstoque(int X, int quantidade)
		{
			Console.WriteLine("O estoque aumentou em quantos livros?");
			Console.ReadLine(X);
			estoque + X = quantidade;
			Console.WriteLine("O estoque aumentou em", quantidade,"livros");
		}
		public Vender(int X, int quantidade)
		{
			Console.WriteLine("Quantos livros foram vendidos?");
			Console.ReadLine(X);
			estoque - X = quantidade;
			Console.WriteLine("O estoque reduziu para", quantidade,"livros");
		}
}