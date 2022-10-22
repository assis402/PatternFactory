namespace FactoryMethod;

public class RJPizzaCalabresa : Pizza
{
    public RJPizzaCalabresa()
    {
        Nome = "Pizza de calabreza Carioca com cebola";
        Massa = "Massa tradicional carioca";
        Molho = "Molho de tomate italiano carioca";
        Ingredientes.Add("Fatias de calabreza especial");
        Ingredientes.Add("Queijo parmessão italiano tradicional");
    }
}