using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Wisdom
    {
        // Содержит общее свойство "сам текст"

        public abstract void InData(StreamReader input);
        public abstract void Out(StreamWriter output);
        public abstract int GetHash(int a);
    }

    public abstract class WisdomFactory
    {
        public WisdomFactory(int m)
        {
            this.next = top;
            top = this;
        }

        public static Wisdom Make(int key)
        {
            Wisdom w = null;
            WisdomFactory tmp = top;
            while (tmp!=null)
            {
                w = tmp.Create(key);
                if (w!=null) return w;
                tmp = tmp.next;
            }
            return null;
        }

        public abstract Wisdom Create(int key);

        protected int mark;
        protected static WisdomFactory top;
        protected WisdomFactory next;
    }
}
