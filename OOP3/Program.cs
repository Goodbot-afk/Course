using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyacKrediManager);
            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager, tasıtKrediManager ,konutKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
