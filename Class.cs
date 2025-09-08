using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class
    {
    }
}

public class Class
{
    //field
    private string _name;

    //property
    public string Name { get; set; }

    //конструктор_без_параметрів
    public Class()
    {
        _name = "Default _name";
        Name = "Default NAMe";
    }

    //конструктор_з_параметром
    public Class(string name)
    {
        _name = name;
        Name = name;
    }

    //публічний_метод
    public void PublicMethod()
    {
        Console.WriteLine($"PublicMethod: Name = {Name}");
        PrivateMethod();
    }

    //приватний_метод
    private void PrivateMethod()
    {
        Console.WriteLine("приватний метод");
    }
}
