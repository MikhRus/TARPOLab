using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Proverb : Wisdom
    {
        string country; // страна
        string quote; // цитата
        public override string Quote
        {
            get
            {
                return quote;
            }
        }

        public Proverb(string str)
        {
            string[] input_data = str.Split(';');
            country = Convert.ToString(input_data[1]);
            quote = Convert.ToString(input_data[2]);
        }

        // Функция вывода

        public override string Out()
        {
            return String.Format("Поговорка:\r\n Страна: {0}\r\n Афоризм: {1}\r\n", country, quote);
        }

        //функция получения хэша
        public override int GetHash(int a)
        {
            return this.GetHashCode() % a;
        }
    }
}
