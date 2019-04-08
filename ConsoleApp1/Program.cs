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
            // Создаем очередь
            Vector input = new Vector();
            // Временные переменные для хранения записей
            fuel Cr_temp;
            gems Cl_temp;
            metals F_temp;
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
                StreamReader inp = new StreamReader(i_filename);
                while ((tmp = inp.ReadLine()) != null)
                {
                    if (tmp[0] == '1') // Драгоценные камни

                    {
                        //создаем и добавляем в очередь
                        Cl_temp = new gems(tmp);

                    }
                    if (tmp[0] == '2') // Металлы
                    {
                        F_temp = new metals(tmp);
                        input.Add(F_temp);
                    }

                    if (tmp[0] == '3') // Горючее
                    {
                        Cr_temp = new fuel(tmp);
                        input.Add(Cr_temp);
                    }
                }
                // Сортировка
                input.Sort();
                // Вывод
                input.Print(o_filename);
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
