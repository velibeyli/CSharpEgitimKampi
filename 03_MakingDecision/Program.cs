using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            //Console.Write("Lutfen shifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if(password == "abcd")
            //{
            //    Console.WriteLine("Shifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Shifre Yanlish");
            //}

            //string capital, country;

            //Console.Write("Bashkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "turkiye")
            //{
            //    Console.Write("veriler dogrulandi");
            //}
            //else 
            //{
            //    Console.Write("hatali bilgi");
            //}

            //int number;
            //Console.Write("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayi dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi hatali");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "Hata!";

            //Console.Write("Sinav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinavlarin ortalamasi: " + avarage);

            //if(avarage > 0 & avarage <= 50)
            //{
            //    result = "Sonuc vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuc orta";
            //}
            //if(avarage > 70 & avarage <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if(avarage > 84)
            //{
            //    result = "Sonuc Cok Iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lutfen shehir girishi yapiniz: ");
            //city = Console.ReadLine();

            //if(city == "adana" | city == "ankara" | city == "trabzon" | city == "izmir")
            //{
            //    Console.WriteLine("Shehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Shehir mevcut degildir");
            //}

            //string username;
            //Console.Write("Lutfen kullanici adi giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanici adi kullanilamaz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hosh geldiniz.");
            //}

            #endregion

            #region Modulus işlemleri

            //int number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);

            //Console.Write("Lutfen 1. sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}
            #endregion

            #region Char dehiskenler ile karar yapilari
            //char team;
            //Console.Write("Lutfen takim sembolunu giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beshiktash");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayini gormek istediginiz menu secimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma tabagi");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Firinda Somon");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Corbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Ezogelin Corbasi");
            //    Console.WriteLine("------------Corbalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Icecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Soda");
            //    Console.WriteLine("------------Icecekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlilar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilece");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sutlac");
            //    Console.WriteLine("------------Tatlilar------------");

            //    Console.WriteLine();
            //}



            #endregion

            #region Switch Case

            //int monthNumber;
            //Console.Write("Lutfen Ay Girisi Yapiniz: ");
            //monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //      Console.WriteLine("Ocak"); 
            //        break;
            //    case 2:
            //      Console.WriteLine("Şubat"); 
            //        break ;
            //    case 3:
            //      Console.WriteLine("Mart"); 
            //        break ;
            //    case 4:
            //      Console.WriteLine("Nisan"); 
            //        break ;
            //    case 5:
            //      Console.WriteLine("Mayıs"); 
            //        break ;
            //    case 6:
            //      Console.WriteLine("Haziran"); 
            //        break ;
            //    case 7:
            //      Console.WriteLine("Temmuz"); 
            //        break ;
            //    case 8:
            //      Console.WriteLine("Ağustos"); 
            //        break ;
            //    case 9:
            //      Console.WriteLine("Eylül"); 
            //        break ;
            //    case 10:
            //      Console.WriteLine("Ekim"); 
            //        break ;
            //    case 11:
            //      Console.WriteLine("Kasım"); 
            //        break ;
            //    case 12:
            //      Console.WriteLine("Aralık"); 
            //        break ;
            //    default:
            //      Console.WriteLine("Hatalı veri Girişi");
            //        break ;
            //}

            #endregion

            #region Switch Case hesab makinesi

            //int number1, number2 ,result;
            //char symbol;

            //Console.Write("Lutfen 1.Sayiyi giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2.Sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpim: " + result);
            //        break;
            //    case '%':
            //        result = number1 % number2;
            //        break;
            //    default:
            //        Console.WriteLine("hatali sembol girisi");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
