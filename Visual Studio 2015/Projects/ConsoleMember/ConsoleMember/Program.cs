using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMember
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            Console.WriteLine("\n[ S e l a m a t  D a t a n g ] \n");
            Console.WriteLine("Masukkan Data: ");
            Console.WriteLine("Nomor Id \t: ");
            int Id; Id = int.Parse(Console.ReadLine());
            int choose;
            choose = int.Parse(Console.ReadLine());
            if(choose == 1)
            {
                Console.WriteLine("Anda memilih Retail");
            }
            else if (choose == 2)
            {
                Console.WriteLine("Anda memilih Corporate");
            }
            else
            {
                Console.WriteLine("Input salah");
            }
            /** xCustomer.Name = "WildanIfqie";
            xCustomer.Email = "wildanspg@gmail.com";







     
            Console.WriteLine("Customer Id \t= {0}", xCustomer.CustomerId);
            Console.WriteLine("Name \t\t= {0}", xCustomer.Name);
            Console.WriteLine("E-mail \t\t= {0}", xCustomer.Email);
            Console.WriteLine("Diskon \t\t= {0}%", xCustomer.Discount());
            **/

            /** MemberCustomer newMember = new MemberCustomer();
            Console.WriteLine("\n[ Member Customer ]");
            newMember.MemberId = 1529032016;
            newMember.DateBegin = "29 Maret 2016";
            Console.WriteLine("Id Member \t= {0}", newMember.MemberId);
            Console.WriteLine("Tanggal \t= {0}", newMember.DateBegin);
            newMember.getInfo();
            **/
            Console.ReadLine();
        }
    }
}
