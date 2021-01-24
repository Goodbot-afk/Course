using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Muhammed", "Murat" };
            List<string> isimler2 = new List<string>() { "Engin", "Muhammed", "Murat" };
            isimler2.Add("Rabia");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
        }
    }
}
