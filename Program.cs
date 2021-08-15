using System;

namespace While_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ") ;
            int sayi =int.Parse(Console.ReadLine()) ;
            int sayac = 1 ;
            int toplam = 0 ;
            while (sayac <= sayi)
            {
                toplam += sayac ;
                sayac ++ ;
            }
            Console.WriteLine("Toplam: " +toplam) ;
            Console.WriteLine("Ortalama: " +(toplam/sayi)) ;

            char c='a' ;
            while(c <'z')
            {
               Console.WriteLine(c) ;
               c ++ ;
            }
              
            string[] arabalar= { "BMW","Ford","Toyota","Nissan"} ;
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba) ;
            }
        }
    }
}
