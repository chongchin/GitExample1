using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample1
{
    class Customer
    {
        private string code;
        private string name;
        private string address;
        private List<Customer> customers = new List<Customer>();

        public Customer(string code, string name, string address)
        {
            this.code = code;
            this.name = name;
            this.address = address;
        }

        public List<Customer> CreateCustomers()
        {
            Customer c1 = new Customer("C1", "C1", "Address 1");
            Customer c2 = new Customer("C2", "C2", "Address 2");
            Customer c3 = new Customer("C3", "C3", "Address 3");
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            return customers;
        }

        public String GetAllCustomerNames()
        {
            String names = "";
           foreach (Customer customer in customers)
           {
               names += customer.name + "\n";
           }
           return names;
        }
    }
}
