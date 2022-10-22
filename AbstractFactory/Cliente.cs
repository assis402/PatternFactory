namespace AbstractFactory;

public class Cliente
{
    ISuv Suv;
    ISedan Sedan;

    public Cliente(IMontadora factory)
    {
        Suv = factory.CriarSuv();
        Sedan = factory.CriarSedan();
    }

    public string GetSuvDetalhes() => Suv.ExibeDetalhes();

    public string GetSedanDetalhes() => Sedan.ExibeDetalhes();
}
