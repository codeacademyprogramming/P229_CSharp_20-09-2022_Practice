using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Product product = new Product("Zavod Coreyi");
            //product.Price = 0.75;
            //product.Count = 10;

            //Console.WriteLine($"{product.Count} {product.TotalIncome}");
            //Console.WriteLine($"============Before {product.Name} Sell============");
            //product.Sell();
            //product.Sell();
            //product.Sell();
            //Console.WriteLine($"============After {product.Name} Sell=============");
            //Console.WriteLine($"{product.Count} {product.TotalIncome}");

            //Product product1 = new Product("Haribo");
            //product1.Price = 0.8;
            //product1.Count = 15;

            //Console.WriteLine($"{product1.Count} {product1.TotalIncome}");
            //Console.WriteLine($"============Before {product1.Name} Sell============");
            //product1.Sell();
            //product1.Sell();
            //product1.Sell();
            //Console.WriteLine($"============After {product1.Name} Sell=============");
            //Console.WriteLine($"{product1.Count} {product1.TotalIncome}");
            #endregion

            #region Task 2
            Console.WriteLine("User name Daxil Et:");
            string username = Console.ReadLine();
            User user = new User(username);
            Console.WriteLine("Passwordu Daxil Et");
            user.Password = Console.ReadLine();

            Console.WriteLine($"UserName: {user.UserName}\nPassword: {user.Password}");
            #endregion

            //PascalCase - CustomType Adlarin- public ve Protected olana class Memmberlerinde ve Methodlarin Adlarinda
            //chamalCase - Methodlarin parametrlerinde
            //underlying - variable adlandirmasi Misal: username || user_name
            //kebab-case - variable
            //private fiel - _field || _chemacCase
        }
    }
}
