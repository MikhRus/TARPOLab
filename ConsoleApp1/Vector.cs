using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {
        //minerals[] array;// Массив, который будем расширять
        //static int count; // Число эл-в
        //// Конструктор по умолчанию
        //public Vector()
        //{
        //    array = new minerals[0];
        //    count = 0;
        //}
        //// Свойство возвращает число эл-в списка
        //public int Count
        //{
        //    get { return count; }
        //}

        //// Добавление нового элемента
        //public void Add(minerals p)
        //{
        //    // Создаем массив на 1 больше
        //    minerals[] tempArray = new minerals[array.Length + 1];
        //    // Переписываем данные в массив array
        //    for (int i = 0; i < array.Length; i++)
        //        tempArray[i] = array[i];

        //    tempArray[array.Length] = p; // Записываем новый элемент
        //    array = tempArray;
        //    count++;
        //}

        //// Печать элементов
        //public void Print(string o_filename)
        //{
        //    // Открываем файл
        //    StreamWriter outp = new StreamWriter(File.OpenWrite(o_filename));
        //    // Пишем
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        outp.WriteLine(array[i].Print());
        //    }
        //    outp.Close();
        //}

        //// Сортировка вставками
        ///*public void Sort()

        //{
        //    minerals temp;
        //    int j = 0;
        //    int right = array.Length;
        //    for (int i = 1; i < right; i++)
        //    {
        //        temp = array[i];
        //        for (j = i - 1; j >= 0 && array[j].Cost > temp.Cost; j--)
        //        {
        //            array[j + 1] = array[j];
        //        }
        //        array[j + 1] = temp;
        //    }
        //}*/
    }
}
