namespace FactoryMethod;

public class SPPizzaMussarela : Pizza
{
    public SPPizzaMussarela()
    {
        Nome = "Pizza de mussarela Paulista";
        Massa = "Massa fina crocante paulista";
        Molho = "Molho de tomate italiano paulista";
        Ingredientes.Add("Queijo parmessão");
        Ingredientes.Add("Azeitonas verdes");    
    }
}
