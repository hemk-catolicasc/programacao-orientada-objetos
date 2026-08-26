namespace CyberTime;

public class ClientModel
{
    private string _cpf;
    private string _name;
    private string _phone;

    public string Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }

    public ClientModel(string cpf, string name, string phone)
    {
        this.Cpf = cpf;
        this.Name = name;
        this.Phone = phone;
    }

    public ClientModel() : this(string.Empty, string.Empty, string.Empty)
    {
    }
}