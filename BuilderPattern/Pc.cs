using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Pc
    {
        public string Cpu { get; set; }
        public string Gpu { get; set; }
        public string Ram { get; set; }
        public string MotherBoard { get; set; }

        public void Show()
        {
            Console.WriteLine($"CPU: {Cpu}");
            Console.WriteLine($"GPU: {Gpu}");
            Console.WriteLine($"RAM: {Ram}");
            Console.WriteLine($"Motherboard: {MotherBoard}");
        }
    }
}
