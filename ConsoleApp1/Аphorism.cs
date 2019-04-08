using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aphorism : Wisdom
    {
        string author; // Название
        string quote; // Рыночная стоимость
        public override string Quote
        {
            get
            {
                return Quote;
            }
        }

        public Aphorism(string str)
        {
            string[] input_data = str.Split(' ');
            author = input_data[1];
            quote = input_data[2];
        }

        // Функция вывода

        public override string Print()
        {
            return String.Format("Автор: {0}\r\n Афоризм: {1}\r\n", author, quote);
        }
    }
}
