using System;
using System.Collections.Generic;

namespace Lab_4;

public class Computer
{
    public string CPU { get; set; } = string.Empty;
    public int RAM { get; set; }
    public string GPU { get; set; } = string.Empty;
    public List<string> AdditionalComponents { get; set; } = new();

    public void Display(string title)
    {
        Console.WriteLine($"--- {title} ---");
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine("Components: " + string.Join(", ", AdditionalComponents));
        Console.WriteLine();
    }

    public Computer ShallowCopy()
    {
        return (Computer)this.MemberwiseClone();
    }

    public Computer DeepCopy()
    {
        var copy = (Computer)this.MemberwiseClone();
        copy.AdditionalComponents = new List<string>(AdditionalComponents);
        return copy;
    }
}