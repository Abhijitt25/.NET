using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BOL;
using DAL;
using Org.BouncyCastle.Asn1.Misc;

IDBManager db = new DBManager();

bool status = true;



while (status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  Products");
    Console.WriteLine("2. Insert new Product");
   // Console.WriteLine("3. Update Product Details");
    Console.WriteLine("4. Delete the Product");
    Console.WriteLine("5. Exit");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                List<Product> products = db.GetAll();

                foreach (var prod in products)
                {
                    Console.WriteLine(" Id: {0}, Title: {1}, Description: {2}, Price:{3}",
                                        prod.Id, prod.Title, prod.Description, prod.Prize);
                }
            }
            break;
        case 2:
            var newProd = new Product();
            Console.WriteLine("Enter Id: ");
            newProd.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title: ");
            newProd.Title = Console.ReadLine();
            Console.WriteLine("Enter Description: ");
            newProd.Description = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            newProd.Prize = double.Parse(Console.ReadLine());
            db.Insert(newProd);
            break;

        case 3:

       

            var updtProd = new Product();
            Console.WriteLine("Enter Id: ");
            updtProd.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title: ");
            updtProd.Title = Console.ReadLine();
            Console.WriteLine("Enter Description: ");
            updtProd.Description = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            updtProd.Prize = double.Parse(Console.ReadLine());
            db.Update(updtProd);
            break;



        case 4:
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());
            db.Delete(id);
            break;



        case 5:
            status = false;
            break;
    }
}


