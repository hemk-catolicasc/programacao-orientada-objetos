namespace SistemaBibliotecaMVC;

internal class LivroModel
{   
    // Propriedades
    private string _id;
    private string _titulo;
    private string _autor;
    private string _genero;
    
    // Atributos
    public string Id {  get => _id; set => _id = value; }
    public string Titulo {  get => _titulo; set => _id = value; }
    public string Autor {  get => _autor; set => _id = value; }
    public string Genero {  get => _genero; set => _id = value; }
    
    // Métodos
    public LivroModel(string id, string titulo, string autor, string genero)
    {
        this.Id = id;
        this.Titulo = titulo;
        this.Autor = autor;
        this.Genero = genero;
    }

    public LivroModel()
    {
        this.Id = "";
        this.Titulo = "";
        this.Autor = "";
        this.Genero = "";
    }
}