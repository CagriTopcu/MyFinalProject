﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach(var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
