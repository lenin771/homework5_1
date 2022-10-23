// программf, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mas1 = new string[3,1];
            mas1[0,0] = "hello";
            mas1[1,0] = "2";
            mas1[2,0] = "world";
            string[] mas2 = new string [3];
            for (int i=0; i<=2; i++)
            {
                mas2[i] = mas1 [i,0];
            }
            
            Console.Write($"{mas2[0]}, {mas2[1]}, {mas2[2]}");
            Console.WriteLine();
        }
    }
}

