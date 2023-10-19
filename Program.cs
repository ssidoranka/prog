using System;
using lab2.construction;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var constructions = new Constructions(25, 33, 45, 66, "Brick");
            Console.WriteLine(constructions.BuildMaterial);

        }
    }
}
