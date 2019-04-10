using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aphorism : Wisdom
    {
        string author; // автор
        string quote; // цитата
        public override string Quote
        {
            get
            {
                return quote;
            }
        }

        public Aphorism(string str)
        {
            string[] input_data = str.Split(' ');
            author = Convert.ToString(input_data[1]);
            quote = Convert.ToString(input_data[2]);
        }

        // Функция вывода

        public override string Print()
        {
            return String.Format("Афоризм:\r\n Автор: {0}\r\n Афоризм: {1}\r\n", author, quote);
        }
    }
}
