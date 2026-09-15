namespace SistemaBibliotecaMVC;

internal class LivroView
{
    public void MontarTela(int col, int lin, string titulo)
    {
        Tela telalivro = new  Tela();
        telalivro.MontarMoldura(col, lin, col + 30, lin + 8, "Cadstro de livros");
        Console.ReadKey();
    }
}