using System;
using System.Collections.Generic;

namespace Lab_4;

public sealed class PrototypeRegistry
{
    private static readonly Lazy<PrototypeRegistry> instance =
        new Lazy<PrototypeRegistry>(() => new PrototypeRegistry());

    public static PrototypeRegistry Instance => instance.Value;

    private Dictionary<string, Computer> prototypes;

    private PrototypeRegistry()
    {
        prototypes = new Dictionary<string, Computer>()
        {
            { "office", new OfficeComputerFactory().Construct() },
            { "gaming", new GamingComputerFactory().Construct() },
            { "home", new HomeComputerFactory().Construct() }
        };
    }

    public Computer GetPrototype(string key)
    {
        return prototypes[key].DeepCopy();
    }
}