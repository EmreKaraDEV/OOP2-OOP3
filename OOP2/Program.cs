using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer iCustomer1 = new IndividualCustomer();
            iCustomer1.Id = 1;
            iCustomer1.CustomerNum = "12345";
            iCustomer1.FirstName = "Engin";
            iCustomer1.LastName = "Demiroğ";
            iCustomer1.IdentityNum = "12345678910";

            CorporateCustomer cCustomer1 = new CorporateCustomer();
            cCustomer1.Id = 2;
            cCustomer1.CustomerNum = "54321";
            cCustomer1.CompanyName = "Kodlama.io";
            cCustomer1.TaxNum = "1234567890";

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
