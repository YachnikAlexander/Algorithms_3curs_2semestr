using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var conv = new Conveyor();
            //conv.StartUsualConveyor();
            conv.StartModernConveyor();
        }
    }
}
