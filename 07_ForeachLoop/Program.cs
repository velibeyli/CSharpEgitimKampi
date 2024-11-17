using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1, 2, 3, 4)

            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = {"milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach(int number in numbers)
            //{
            //    total+= number;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string hello = "Merhaba";

            //foreach(char c in hello)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulamasi

            //Console.WriteLine("***** C# Egitim Kampi Sinav Uygulamasi *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanicidan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sinifinizda Kac Ogrenci Var:");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            ////Öğrenci isimlerini ve not ortalamalarini saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı  öğrencinin {j+1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());

            //        totalExamResult += value;//notlari topluyoruz
            //    }

            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            ////Sinav ortalamalari
            //for(int i = 0; i<studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilerin ortalaması ve geçip  kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci  dersten kaldı");
            //    }
                


            //}

            #endregion

            Console.Read();
        }
    }
}
