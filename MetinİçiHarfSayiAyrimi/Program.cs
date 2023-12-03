using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinİçiHarfSayiAyrimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin giriniz: ");
            string girdi = Console.ReadLine();

            List<char> harfler = new List<char>();
            List<int> sayilar = new List<int>();

            foreach (char karakter in girdi)
            {
                if (char.IsLetter(karakter)) // IsLetter : Bir karakterin harf olup olmadığını kontrol eder.
                {
                    if (!harfler.Contains(karakter))
                    {
                        harfler.Add(karakter);
                    }
                }
                else if (char.IsDigit(karakter)) // IsDigit: Bir karakterin bir rakamı (0-9) temsil edip etmediğini kontrol eder .
                {
                    int sayi = int.Parse(karakter.ToString());
                    if (!sayilar.Contains(sayi))
                    {
                        sayilar.Add(sayi);
                    }
                }
            }

            harfler.Sort();
            sayilar.Sort();

            Console.WriteLine("Harfler = " + string.Join(",", harfler));
            Console.WriteLine("Sayılar = " + string.Join(",", sayilar));

            Console.ReadLine();
        }
    }
}
