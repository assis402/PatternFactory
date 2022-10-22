namespace FactoryMethod;

public class RJPizzaMussarela : Pizza
{
    public RJPizzaMussarela()
    {
        Nome = "Pizza de mussarela Carioca";
        Massa = "Massa tradicional carioca";
        Molho = "Molho de tomate italiano carioca";
        Ingredientes.Add("Queijo parmessão ralado");
        Ingredientes.Add("Azeitonas pretas");
    }
}