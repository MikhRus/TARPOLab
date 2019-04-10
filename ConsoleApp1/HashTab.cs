using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HashTab<T>
    {
        private Item<T>[] items;

        public HashTab(int size)
        {
            items = new Item<T>[size];
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }
        public void Add (T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }
        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
        public void Print(string o_filename)
        {
            //Открываем файл
            StreamWriter outp = new StreamWriter(File.OpenWrite(o_filename));
            //Пишем
            for (int i = 0; i < items.Length; i++)
            {
                if (!items[i].Nodes.Count.Equals(0))
                {
                    foreach (var node in items[i].Nodes)
                    {
                        outp.WriteLine(node.Print());
                    }               
                }
            }
            outp.Close();
        }
    }
}
