using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Conveyor
    {
        public List<Box> Boxes { get; set; }
        public List<Item> Items { get; set; }

        public Conveyor(List<Item> items)
        {
            Items = items;
            Boxes = new List<Box>();
        }

        public Conveyor()
        {
            Boxes = new List<Box>();
            Items = new List<Item>();
        }

        public void StartUsualConveyor()
        {
            Boxes.Add(new Box());
            var boxIndex = 0;

            while (true)
            {
                double weight;

                Item item;
                if (Items.Count == 0)
                {
                    weight = FractionUI.EnterFraction();
                    item = new Item(weight);
                }
                else
                {
                    item = new Item(Items[0].Weight);
                    Items.RemoveAt(0);
                }

                bool check = Boxes[boxIndex].CheckCapacity(item);

                if (!check)
                {
                    Boxes.Add(new Box());
                    boxIndex++;
                }

                Boxes[boxIndex].PutItem(item);

                foreach(var box in Boxes)
                {
                    Console.WriteLine(box.ToString());
                }
            }
        }

        public void StartModernConveyor()
        {
            Boxes.Add(new Box());

            while (true)
            {
                double weight;

                Item item;
                if (Items.Count == 0)
                {
                    weight = FractionUI.EnterFraction();
                    item = new Item(weight);
                }
                else
                {
                    item = new Item(Items[0].Weight);
                    Items.RemoveAt(0);
                }

                bool checkBox = false;
                foreach(var box in Boxes)
                {
                    checkBox = box.CheckCapacity(item);
                    if (checkBox)
                    {
                        box.PutItem(item);
                        break;
                    }
                }

                if (!checkBox)
                {
                    var box = new Box();
                    box.PutItem(item);
                    Boxes.Add(box);
                }

                foreach (var box in Boxes)
                {
                    Console.WriteLine(box.ToString());
                }

            }
        }
    }
}
