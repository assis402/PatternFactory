namespace Builder;

public class Fabricante
{
    public void Build(ComputadorBuilder computadorBuilder)
    {
        computadorBuilder.BuildDispositivos();
        computadorBuilder.BuildSO();
    }
}
