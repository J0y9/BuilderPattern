using BuilderPattern;

// Director Class
public class PcShop
{
    public Pc BuildPc(IPcBuilder builder)
    {
        builder.SetCpu();
        builder.SetGpu();
        builder.SetMotherBoard();
        builder.SetRam();
        return builder.Build();
    }
}