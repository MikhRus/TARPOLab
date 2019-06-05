using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Riddle : Wisdom
    {
        string answer, quote;

        public override void InData(StreamReader input)
        {
            string[] inputData = input.ReadLine().Split(';');
            quote = Convert.ToString(inputData[1]);
            answer = Convert.ToString(inputData[2]);
        }

        public override void Out(StreamWriter output)
        {
            output.WriteLine("Загадка:\r\n Загадка: {0}\r\n Ответ: \r\n", quote, answer);
        }

        //функция получения хэша
        public override int GetHash(int a)
        {
            return this.GetHashCode() % a;
        }
    }
    public class RiddleFactory : WisdomFactory
    {
        //RiddleFactory(): WisdomFactory(3) { }
        public override Wisdom Create(int key)
        {
            if (key == mark)
                return new Riddle();
            else
                return null;
        }
    }
}
