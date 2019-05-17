using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Box
    {
        private readonly double Capacity;
        public double CurrentWeight { get; set; }
        public List<Item> Items { get; set; }

        public Box()
        {
            Capacity = 1;
            CurrentWeight = 0;
            Items = new List<Item>();
        }

        public bool CheckCapacity(Item item)
        {
            return (CurrentWeight + item.Weight) < Capacity ? true : false;
        }

        public void PutItem(Item item)
        {
            CurrentWeight += item.Weight;
            Items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Current weight {CurrentWeight} :");
            foreach(var item in Items)
            {
                str.Append($"Item weight {item.Weight};");
            }

            return str.ToString();
        }
    }
}
