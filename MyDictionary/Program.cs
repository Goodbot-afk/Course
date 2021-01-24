using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> persons = new MyDictionary<int, string>();
            persons.Add(01, "Muhammed");
            persons.Add(02, "Emin");
            persons.Add(03, "Rabia");
            persons.Add(04, "Mahmut");
            persons.Add(05, "Şükriye");


            foreach (var id in persons.Keys)
            {
                Console.WriteLine(id);
            }
            foreach (var name in persons.Values)
            {
                Console.WriteLine(name);
            }

        }	    
    }
}
