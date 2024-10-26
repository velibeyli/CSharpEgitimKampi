using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturmak

            //for(int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturmak

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma, her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik üçken

            //string star = "*";
            //string result = "*";

            //for(int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine(result);
            //    result += star;
            //}

            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 10; j >=i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 10; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region simmetrik dik üçken

            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 9; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region romb 

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine();

            //for(int i = 1; i <= n; i++)
            //{
            //    for (int k = 10; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int a = 2; a <= i; a++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n-1; i >= 1; i--)
            //{
            //    for (int k = 10; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int a = 2; a <= i; a++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramida

            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine();

            //for(int i = 1; i <= number; i++)
            //{
            //    for(int j = 10; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for(int l = 2; l <= i; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramida

            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = number; i >= 1; i--)
            //{
            //    for (int k = number; k >= i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
