using System;

namespace ClassMethodDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 862, Age = 25, Name = "Halil", Phone = 123456789 };
            Customer customer1 = new Customer() { Id = 546, Age = 30, Name = "Engin", Phone = 123456798 };
            Customer customer2 = new Customer() { Id = 987, Age = 56, Name = "Ali", Phone = 123456987 };

            Customer[] customers = new Customer[]{customer,customer1,customer2 };


            foreach (var cst in customers)
            {
                Console.WriteLine("İsim : " + cst.Name + " --- " + "Yaş : "  + cst.Age +" --- "+"Telefon : " +cst.Phone);
               
            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd();
            customerManager.CustomerDelete();


            
            
            
        }
    }
}
