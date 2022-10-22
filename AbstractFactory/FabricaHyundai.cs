namespace AbstractFactory;

public class FabricaHyundai : IMontadora
{
    public ISedan CriarSedan()
    {
        return new HB20Hyundai();
    }

    public ISuv CriarSuv()
    {
        return new CretaHyundai();
    }
}
