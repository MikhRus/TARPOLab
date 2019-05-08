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
        public abstract int GetHash(int a);
    }

    public abstract class WisdomFactory
    {
        //static 
        public WisdomFactory(int m)
        {
            this.next = top;
            top = this;
        }
        static Wisdom Make(int key)
        {
            Wisdom wisdom = null;
            WisdomFactory tmp = top;

            while (tmp)
            {
                wisdom = tmp.Create(key);
                if (wisdom) return wisdom;
                tmp = tmp.next;
            }
        }
        Wisdom In()
        {
            Wisdom ws = null;
            int k;
            ifst >> k;
            ws = Make(k);
            if (ws)
                ws.InData(ifst);
            return ws;

        }
        virtual Wisdom Create(int key) = 0;

        protected int mark;
        protected static WisdomFactory top = null;
        protected WisdomFactory next;
    }
}
