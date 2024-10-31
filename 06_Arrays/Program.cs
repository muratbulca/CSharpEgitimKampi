using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Siyah";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[3]);

            //***************************************

            //string[] cities = new string[5];
            //cities[0] = "Madrid";
            //cities[1] = "Atina";
            //cities[2] = "Moskova";
            //cities[3] = "Tiran";
            //cities[4] = "Ankara";

            //Console.WriteLine(cities[4]);

            //***************************************

            //int[] numbers = new int[10];
            //numbers[0] = 54;
            //numbers[1] = 16;
            //numbers[2] = 34;
            //numbers[4] = 794;
            //numbers[8] = 921;

            //Console.WriteLine(numbers[8]);

            //***************************************

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[4]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Mavi", "Siyah", "Beyaz", "Kırmızı", "Truncu", "Yeşil" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //***************************************

            //int[] numbers = { 5, 9, 54, 83, 234, 532, 646, 982, 7846, 325, -27, 8664 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //***************************************

            //char[] symbols = { 'a', 'b', 'c', '*', '#', '&' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //***************************************

            //int[] myArray = { 3, 8, 76, 54, 81, 843, 548, 99, 7493, 633, 3342 };
            //int maxNumber = myArray[0];
            //for (int i = 0;  i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //***************************************

            //string[] persons = { "ali", "Fatma", "Kemal", "Zeynep", "Buse", "Cem", "Hakan" };
            //Console.WriteLine(persons.Length);

            //***************************************

            //int[] numbers = { 54, 64, 32, 11, 75, 643, 69, 434, 654, 98, 450, 8543 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //***************************************

            //int[] numbers = { 54, 64, 32, 11, 75, 643, 69, 434, 654, 98, 450, 8543 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları

            //string[] customers= { "ali", "Fatma", "Kemal", "Zeynep", "Buse", "Cem", "Hakan" };
            //int index = Array.IndexOf(customers, "Zeynep");
            //Console.WriteLine(index);

            //************************************************

            //int[] numbers = { 44, 65, 54, 77, 87, 22, 9, 74, 32, 107 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //*****************************************

            //int[] numbsers = { 10, 20, 30, 40, 50, 60 };
            //int sum = 0;
            //for(int i = 0; i < numbsers.Length; i++)
            //{ 
            //    sum += numbsers[i]; 
            //}
            //Console.WriteLine(sum);

            //*****************************************

            int[] numbers = { 21, 42, 63, 64, 875, 436, 357, 248, 449, 5310 };
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for(int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion
            Console.Read();
        }
    }
}
