namespace BuilderPattern;

public class LowEndPcBuilder : IPcBuilder
{
    private readonly Pc _pc;
    public Pc Build()
    {
        return _pc;
    }

    public void SetCpu()
    {
        _pc.Cpu = "I5-4500K";
    }

    public void SetGpu()
    {
        _pc.Gpu = "GTX 1650";
    }

    public void SetMotherBoard()
    {
        _pc.MotherBoard = "Gigabyte A100";
    }

    public void SetRam()
    {
        _pc.Ram = "8GB 2300MHZ";
    }
}