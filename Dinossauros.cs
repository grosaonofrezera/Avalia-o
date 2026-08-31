public class Dinossauro

{
    private string? nome;

    private string? periodo;

    public string? Nome
    {
        get {return nome;}
        set {nome = value;}
    }

    public string? Periodo
    {
        get {return periodo;}
        set {periodo = value;}
    }

    public Dinossauro(string nome, string periodo)
    {
        this.nome = nome;
        this.periodo = periodo;
 
    }
    public override string ToString()
    {

        return "nome:" + Nome + "\nperiodo:" + periodo;

    }
    
}