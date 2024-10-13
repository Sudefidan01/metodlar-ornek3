using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar_Ornek3
{
    internal class Metod
    {
        public string StringIste(string baslik)
        {
            string txt=String.Empty;
            bool hata = true;
            do
            {
                Console.WriteLine(baslik);
                txt= Console.ReadLine();
                if (txt.Length==0)
                {
                    hata = true;
                }
                else
                {
                    hata = false;
                }
                
            } while (hata);
            return txt;
        }
    }
}
