public class Museu
{
    private string? nome;

    private string? cidade;

    private int fosseis;

    public string? Nome
    {
        get {return nome;}
        set {nome = value;}
    }

    public string? Cidade
    {
        get {return cidade;}
        set {cidade = value;}
    }

    public int Fosseis
    {
        get {return fosseis;}
        set {fosseis = value;}
    }

    public Museu(string nome, string cidade, int fosseis)
    {
        this.nome = nome;
        this.cidade = cidade;
        this.fosseis = fosseis;
    }
    public override string ToString()
    {

        return "Nome: " + nome + "\nCidade: " + cidade + "\nFosseis: " + fosseis;

    }
}