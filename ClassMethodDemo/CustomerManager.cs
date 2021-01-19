using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer musteriler)
        {
            Console.WriteLine("Müşteri Eklendi : {0}  {1}  {2} ",musteriler.Id,musteriler.UserName,musteriler.SurName);
        }
        public void CustomerDelete(Customer musterisilme) //array list olmadığı için arrayden silinmez ama siliyormuş gibi gösterelim
        {
            Console.WriteLine("{0}  {1}  {2}  {3} Silindi!",musterisilme.Id, musterisilme.UserName, musterisilme.SurName, musterisilme.Password);
        }

        public void CustomerList(Customer[] listeleme)
        {
            foreach (Customer customers in listeleme)
            {
                Console.WriteLine("Müşteri : {0}  {1}  {2} ",customers.UserName,customers.SurName,customers.Id);
            }
        }
    }
   
}
