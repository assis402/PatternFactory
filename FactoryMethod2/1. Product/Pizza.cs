using System.Collections;

namespace FactoryMethod2;

public abstract class Pizza
{
    public abstract string Nome { get; }

    public ArrayList Ingredientes = new ArrayList();
}
