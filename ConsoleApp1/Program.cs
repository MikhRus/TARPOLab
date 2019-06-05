using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var hashTab = new HashTab<Wisdom>(10);
            // Создаем очередь

            // Временные переменные для хранения записей
            Proverb Pr_temp;
            Aphorism Ap_temp;

            // Имена входного и выходного файлов
            string i_filename, o_filename, tmp;
            // Обработка ошибок
            try
            {
                Console.WriteLine("Введите имя файла на вход: ");
                i_filename = Console.ReadLine();
                i_filename += ".txt";
                Console.WriteLine("Введите имя файла на выход: ");
                o_filename = Console.ReadLine();
                o_filename += ".txt";
                StreamReader inp = new StreamReader(i_filename, Encoding.GetEncoding("windows-1251"));
                while ((tmp = inp.ReadLine()) != null)
                {
                    if (tmp[0] == '1') // поговорки

                    {
                        //создаем и добавляем в очередь
                        Pr_temp = new Proverb(tmp);
                        hashTab.Add(Pr_temp);

                    }
                    if (tmp[0] == '2') // афоризмы
                    {
                        Ap_temp = new Aphorism(tmp);
                        hashTab.Add(Ap_temp);
                    }
                }
                // Вывод
                hashTab.Out(o_filename);
            }

            catch (Exception e)

            {
                // Обработка ошибок
                Console.Clear();
                Console.WriteLine("При выполнении программы возникла ошибка!\nПодробнее: {0}", e.Message);
                Console.ReadKey(true);
            }
        }
    }
}
