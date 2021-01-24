using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name+" eklendi !");
            
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " Güncellendi !");
        }
        //public int Topla(int sayı1,int sayı2)
        //{
        //    return sayı1+sayı2
        //}
        //public void Topla2(int sayı1, int sayı2)
        //{
        //    Console.WriteLine(sayı1 + sayı2);
        //}
    }
}
