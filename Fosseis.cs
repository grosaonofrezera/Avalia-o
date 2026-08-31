public class Fossil
{
    private string? animal;

    private string? localizacao;

    public string? Animal
    {
        get {return animal;}
        set {animal = value;}
    }

    public string? Localizacao
    {
        get {return localizacao;}
        set {localizacao = value;}
    }

    public Fossil(string animal, string localizacao)
    {
        this.animal = animal;
        this.localizacao = localizacao;
 
    }
    public override string ToString()
    {

        return "animal:" + animal + "\nlocalizacao:" + localizacao;

    }
}