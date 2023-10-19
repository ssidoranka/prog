using System;
using System.Collections.Generic;
using System.Text;

namespace lab2.construction
{
    class Constructions
    {
        public Constructions(double height, double width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }
        public double Height { get; set;  }
        public double Width { get; set;  }
        public int Entrances { get; set;  }
        public int HumanCapacity { get; set;  }
        public string BuildMaterial { get; set;  }
    }
}
/*1.Height typu zmiennoprzecinkowego
2. Width typu zmiennoprzecinkowego
3. Entrances typu liczba całkowita
4. HumanCapacity typu liczba całkowita
5. BuildMaterial typu tekstowego
*/
