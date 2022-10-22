namespace FactoryMethod;

public class SPPizzaCalabresa : Pizza
{
    public SPPizzaCalabresa()
    {
        Nome = "Pizza de calabreza Paulista com muita calabreza";
        Massa = "Massa fina crocante";
        Molho = "Molho de tomate italiano";
        Ingredientes.Add("Fatias de calabreza defumada especial");
        Ingredientes.Add("Queijo parmessão italiano tradicional");
    }
}
