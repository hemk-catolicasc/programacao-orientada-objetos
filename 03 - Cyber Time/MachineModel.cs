namespace CyberTime;

public class MachineModel
{
    public int Id { get; private set; } 
    private MachineStatus _status;
    private MachineType _type;
    private string _description;
    private static int _seq = 0;

    public enum MachineStatus 
    { 
        Received,
        UnderAnalysis,
        InMaintenance,
        Ready,
        Delivered
    }
    public enum MachineType
    {
        Pc,
        Notebook,
        Other
    }
    
    // Não pode voltar na sequencia, máquina enviada não pode virar recebida por exemplo
    // Regra vive em Model devido a reutilização em diferentes telas, é aqui ode mora a classe do objeto
    public MachineStatus Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public MachineType Type
    {
        get { return _type; }
        set { _type = value; }
    }
    
    //Não pode ser nulo e nem com vazio, deve haver pelo menos 1 caracter
    //Regra vive em Model devido a reutilização em diferentes telas, é aqui ode mora a classe do objeto
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public MachineModel(MachineStatus status, MachineType type, string description)
    {
        this.Id = _seq + 1;
        _seq = Id;
        this.Status =  status;
        this.Type = type;
        this.Description = description;
    }

    public MachineModel() : this(MachineStatus.Received, MachineType.Other, "") {} 
    
}