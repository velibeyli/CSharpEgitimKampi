using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye deger dondurmeyen metotlar
            //Customer-Listele,ekle, sil, guncelle
            //Void

            //CustomerList();

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yilmaz");
            //    Console.WriteLine("Ayse Yildiz");
            //    Console.WriteLine("Hakan Ozturk");
            //    Console.WriteLine("Merve Cinar");
            //}

            //Sum();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}




            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Merve Cinar");

            //void CustomerCard(string Name, string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + Name + " " + Surname);
            //}

            //CustomerCard("Mehmet", "Yildirim");
            //CustomerCard("Aysegul", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(15 , 20 , 30);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yildiz";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string Name = "ALI";
            //    string Surname = "Kaya";

            //    return Name + " " + Surname;
            //}

            //Console.WriteLine(StudentCard()) ;

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string country, countryCapital, countryFlag;
            //Console.Write("Ülke Adını Giriniz: ");
            //country = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //countryCapital = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //countryFlag = Console.ReadLine();

            //Console.WriteLine(CountryCard(country,countryCapital,countryFlag));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(15,26));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return "Öğrenci - " + student + " sınavı geçti";
                }
                else
                {
                    return "Öğrenci - " + student + " başarısız oldu";
                }
            }

            Console.WriteLine(ExamResult("Ali",25,41,55));
            Console.WriteLine(ExamResult("Ayşe",36,88,33));

            #endregion

            Console.Read();
        }
    }
}
