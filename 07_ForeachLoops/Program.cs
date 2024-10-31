using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "Atina", "Ankara", "Prag" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //******************************************

            //int[] numbsers = { 43, 6, 43, 646, 63, 87, 24, 768, 644, 7674, 2423, 42, 678 };
            //foreach (int number in numbsers)
            //{
            //    Console.WriteLine(number);
            //}

            //*****************************************

            //int[] numbsers = { 43, 6, 43, 646, 63, 87, 24, 768, 644, 7674, 2423, 42, 678 };
            //foreach (int number in numbsers)
            //{
            //    if (number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //******************************************

            //int[] numbsers = { 43, 6, 43, 646, 63, 87, 24, 768, 644, 7674, 2423, 42, 678 };
            //int total = 0;

            //foreach (int num in numbsers)
            //{
            //    total += num;
            //}
            //Console.WriteLine(total);

            //*********************************************

            //List<int> numbers = new List<int>()
            //{
            //    1,2,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //*********************************************

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziller
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi
                for(int j = 0;j<3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult /3;
            }
            //Sınav ortalamarı
            for(int i = 0;i < studentCount;i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50) 
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-----------------------");
            }
            #endregion
            Console.Read();
        }
    }
}
