namespace Lab_4;

public interface IComputerFactory
{
    Computer Construct();
}

public class OfficeComputerFactory : IComputerFactory
{
    public Computer Construct()
    {
        return new ComputerBuilder()
            .WithCPU("Intel i3")
            .WithRAM(8)
            .WithGPU("Integrated")
            .WithComponent("SSD 256GB")
            .Build();
    }
}

public class GamingComputerFactory : IComputerFactory
{
    public Computer Construct()
    {
        return new ComputerBuilder()
            .WithCPU("Ryzen 7")
            .WithRAM(32)
            .WithGPU("RTX 4070")
            .WithComponent("NVMe 1TB")
            .WithComponent("Liquid Cooling")
            .Build();
    }
}

public class HomeComputerFactory : IComputerFactory
{
    public Computer Construct()
    {
        return new ComputerBuilder()
            .WithCPU("Intel i5")
            .WithRAM(16)
            .WithGPU("RTX 3060")
            .WithComponent("SSD 512GB")
            .Build();
    }
}