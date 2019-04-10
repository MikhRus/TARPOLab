using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Wisdom
    {
        // Содержит общее свойство "сам текст"

        public abstract string Quote { get; }
        public abstract string Print();
    }
}
