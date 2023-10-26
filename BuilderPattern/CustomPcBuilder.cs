namespace BuilderPattern;

public class CustomPcBuilder 
{
    private readonly Pc _pc;

    public CustomPcBuilder()
    {
        _pc = new Pc();
    }
    public Pc Build()
    {
        return _pc;
    }

    public void SetCpu(string value)
    {
        _pc.Cpu = value;
    }

    public void SetGpu(string value)
    {
        _pc.Gpu = value;
    }

    public void SetMotherBoard(string value)
    {
        _pc.MotherBoard = value;
    }

    public void SetRam(string value)
    {
        _pc.Ram = value;
    }
}