using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMember
{
    class Customer
    {
        int customerId;
        string name;
        string email;
        string password;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Customer()
        {

        }
        public Customer(int Id)
        {
            customerId = Id;
        }
        public virtual float Discount()
        {
            float Diskon;
            int Id = CustomerId;
            if (Id == 1)
            {
                Diskon = 50;
                return (Diskon);
            }
            else if(Id == 2)
            {
                Diskon = 30;
                return (Diskon);
            }
            else
            {
                return 0;
            }
        }
        public virtual void getInfo()
        {
            Console.WriteLine("Anda mendapat diskon");
        }
    }
}
