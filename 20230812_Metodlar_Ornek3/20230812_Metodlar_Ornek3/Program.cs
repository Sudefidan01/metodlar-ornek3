using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir string değer talep edelim
            //Kullanıcı boş bir değer girdiği sürece odeğeri kullanıcıdan tekrar talep edelim
            //Kullanıcıdan değer talep etme işlemlerini metod ile yapalım
            Metod m=new Metod();

            string deger = m.StringIste("Bir Değer Giriniz ");

            Console.WriteLine("Girilen Değer = " + deger);

            //Console.WriteLine(m.StringIste("Bir Değer Girin"));

            Console.ReadKey();

        }
    }
}
