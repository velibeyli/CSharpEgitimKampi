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
            // 2,4,6,8
            //sarı,kırmızı,beyaz,mavi
            // DeğişkenTürü[] diziAdı = new DeğişkenTürü[ElemanSayisi]

            //string[] colors = new string[4];
            //colors[0] = "Kirmizi";
            //colors[1] = "Mavi";
            //colors[2] = "Sari";
            //colors[3] = "Turuncu";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Uskup";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[9]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities.Length);



            #endregion

            #region Dizideki Tüm Elemanları Listele

            //string[] colors = { "Sari", "Kirmizi", "Beyaz", "Mavi", "Yesil", "Turuncu", "Pembe" };

            //foreach(string color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayse", "buse", "cem", "deniz" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("---------------------------------");

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotlar

            //string[] customers = {"ali","buse","merve","aysegul","merve","cinar","kaya"};

            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.Write("Dizinin en buyuk elemani: " + numbers.Max() + "\nDizinin en kucuk elemani: " + numbers.Min());



            #endregion

            #region Kullanicidan Deger Alma

            //Console.WriteLine("Kac elemanli dizi yazilacak? ");
            //int arraySize = int.Parse(Console.ReadLine());
            //string[] colors = new string[arraySize];

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    colors[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Dahil ettiyiniz eleman sayi: " + arraySize);
            //Console.WriteLine();

            //Console.WriteLine("Dahil ettiginiz elemanlar: ");

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 21,42,33,54,55,66,897,748,39,220 };

            //Console.WriteLine("Cift sayilar: ");

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("Tek sayilar: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
