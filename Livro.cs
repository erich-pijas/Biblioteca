public class Livro
{
	public string titulo;
	public string autor;
	public int isbn;
	private int estoque;
	
	public void AdicionarEstoque(int quantidade)
	{
		quantidade = estoque;
		quantidade = quantidade + 1;
	}
	public int getEstoque(int quantidade)
	{
		quantidade = estoque;
		return quantidade;
	}
}