
using System;

namespace ClassMethodDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1234567810;
            customer1.UserName = "Berkay";
            customer1.SurName = "Sazak";
            customer1.Password = "sifreburada123";

            Customer customer2 = new Customer();
            customer2.Id = 1784561230;
            customer2.UserName = "Elon";
            customer2.SurName = "Musk";
            customer2.Password = "teslaspacex2050";

            Customer customer3 = new Customer();
            customer3.Id = 1830541450;
            customer3.UserName = "Jeff";
            customer3.SurName = "Bezos";
            customer3.Password = "kingofamazons";

            Customer customer4 = new Customer();
            customer4.Id = 1830541450;
            customer4.UserName = "Ali";
            customer4.SurName = "Koç";
            customer4.Password = "fenerbahce";

            Customer[] customers = new Customer[] { customer1,customer2,customer3,customer4 };
           
            
            Console.WriteLine("---Hethod kullanarak ekleme---");
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            customerManager.CustomerAdd(customer4);


            // Console.WriteLine("---Method kullanarak listeleme---"); //1.yol uzun
            //CustomerManager customerlist = new CustomerManager();
            /* customerManager.CustomerList(customer1);
               customerManager.CustomerList(customer2);
               customerManager.CustomerList(customer3);
               customerManager.CustomerList(customer4); */


            Console.WriteLine("müşteri listeleme");
            customerManager.CustomerList(customers);

            Console.WriteLine("müşteri silme");
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerDelete(customer3);
            customerManager.CustomerDelete(customer4);

        }
    }
}
