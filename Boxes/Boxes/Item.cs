using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Item
    {
        public double Weight { get; set; }

        public Item(double weight)
        {
            Random rand = new Random();
            Weight = weight;
        }
    }
}
