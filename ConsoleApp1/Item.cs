using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item<T>
    {
        public int Key { get; set; }
        public List<Wisdom> Nodes { get; set; }

        public Item(int key)
        {
            Key = key;
            Nodes = new List<Wisdom>();
        }
        /*public string PrintItem()
        {
            return (string)Nodes.Value;
        }*/
    }
}
