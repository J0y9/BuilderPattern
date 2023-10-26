using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IPcBuilder
    {
        void SetCpu();
        
        void SetGpu();

        void SetRam();
        
        void SetMotherBoard();
        
        Pc Build();
    }
}
