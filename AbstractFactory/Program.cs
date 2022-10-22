using AbstractFactory;

IMontadora fabrica = new FabricaHonda();
Cliente cliente = new Cliente(fabrica);
Console.WriteLine("*************** HONDA ****************");
ExibeDetalhes(cliente);

fabrica = new FabricaHyundai();
cliente = new Cliente(fabrica);
Console.WriteLine("************** HYUNDAI ***************");
ExibeDetalhes(cliente);

Console.ReadKey();

void ExibeDetalhes(Cliente cliente)
{
    Console.WriteLine(cliente.GetSedanDetalhes());
    Console.WriteLine(cliente.GetSuvDetalhes());
}