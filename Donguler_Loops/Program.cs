using System;

namespace Donguler_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Kurslar = new string[] { "yazılım geliştirme kursu", "temeller", "java","python" , "C#"};

            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            };
            Console.WriteLine("Sayfa sonu");
            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }
        }   
    }
}
