namespace SistemaBibliotecaMVC;

internal class LivroController
{   
    // Atributos
    private LivroModel _livro;
    private LivroView _telalivro;
    private List<LivroModel> _livros;
    
    // Construtor
    public LivroController()
    {
        this._livro =  new LivroModel();
        this._telalivro = new LivroView();
        this._livros = new List<LivroModel>();
    }

    public void ExecutarCRUD()
    {
        this._telalivro.MontarTela(10, 5, "Cadastro");
        
    }
}