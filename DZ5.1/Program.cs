using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._1
{
    internal class Program
    {//Сформировать одномерный массив из 7 элементов. Заполнить массив числами,
     //вводимыми с клавиатуры, определить среднее арифметическое элементов.
        static void Main(string[] args)
        {
            int[] array = new int[8];
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            float S = array[0];
            for (int i = 1; i < 8; i++)
            {
                S += array[i];
                Console.Write("{0} ", S);
            }
            Console.WriteLine();

            Console.WriteLine("{0:f2} ", S / 7);
            Console.ReadKey();
        }
    }
}
