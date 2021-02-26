﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }


            Console.WriteLine("********************************");

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName + "\t" + product.CategoryID);
            }
            
        }
    }
}