namespace Prototype;

public class Soldado
{
    public string Nome { get; set; }
    public string Arma { get; set; }

    public Soldado() { }


    public object Clone()
    {
        return (Soldado)this.MemberwiseClone();
    }
}
