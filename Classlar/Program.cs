using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.Izlenme_oranı = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.Izlenme_oranı = 20;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Muhammed Emin Akkaya";
            kurs3.Izlenme_oranı = 100;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (Kurs kurstek in kurslar)
            {
                Console.WriteLine(kurstek.KursAdı + " : " + kurstek.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int Izlenme_oranı { get; set; }
    }
}
