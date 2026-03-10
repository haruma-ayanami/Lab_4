using System;
using Lab_4;

class Program
{
    static void Main()
    {
        // Builder
        var pc = new ComputerBuilder()
            .WithCPU("Intel i7")
            .WithRAM(16)
            .WithGPU("RTX 3060")
            .WithComponent("SSD 1TB")
            .Build();

        pc.Display("Custom PC");

        // Factory
        IComputerFactory factory = new GamingComputerFactory();
        var gaming = factory.Construct();
        gaming.Display("Gaming PC");

        // Prototype
        var shallow = gaming.ShallowCopy();
        shallow.AdditionalComponents.Add("Extra RGB");

        gaming.Display("Original after shallow copy");
        shallow.Display("Shallow Copy");

        // Singleton Registry
        var registry = PrototypeRegistry.Instance;

        var proto = registry.GetPrototype("gaming");
        proto.RAM = 64;

        proto.Display("Modified prototype");

        var proto2 = registry.GetPrototype("gaming");
        proto2.Display("Original prototype again");

        Console.WriteLine(
            ReferenceEquals(
                PrototypeRegistry.Instance,
                PrototypeRegistry.Instance
            )
        );
    }
}