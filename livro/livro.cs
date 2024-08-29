class Livro
{
  public string titulo;
  public string autor;
  public int paginas;

  public int ano;

  public void ExibirInformacoes()
  {
    Console.WriteLine($"titulo: {titulo}, autor: {autor}, paginas: {paginas}, ano {ano}");
  }

  public bool VerificarTrezentos()
  {
    if(paginas > 300)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
