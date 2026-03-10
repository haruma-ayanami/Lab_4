namespace Lab_4;

public class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder WithCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder WithRAM(int ram)
    {
        computer.RAM = ram;
        return this;
    }

    public ComputerBuilder WithGPU(string gpu)
    {
        computer.GPU = gpu;
        return this;
    }

    public ComputerBuilder WithComponent(string component)
    {
        computer.AdditionalComponents.Add(component);
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}