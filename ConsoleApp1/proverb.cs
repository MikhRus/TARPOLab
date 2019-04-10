using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Proverb:Wisdom
    {
        string country; // Название
        string quote; // Рыночная стоимость
        public override string Quote
        {
            get
            {
                return quote;
            }
        }

        public Proverb (string str)
        {
            string[] input_data = str.Split(' ');
            country = Convert.ToString(input_data[1]);
            quote = Convert.ToString(input_data[2]);
        }

        // Функция вывода

        public override string Print()
        {
            return String.Format("Поговорка:\r\n Страна: {0}\r\n Афоризм: {1}\r\n", country, quote);
        }
    }
}
