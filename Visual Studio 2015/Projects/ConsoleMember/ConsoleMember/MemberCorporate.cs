using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMember
{
    class MemberCorporate : Customer
    {
        int corporateId;
        string corporateName;

        public int CorporateId
        {
            get { return corporateId; }
            set { corporateId = value; }
        }
        public string CorporateName
        {
            get { return corporateName; }
            set { corporateName = value; }
        }
        public int getDiscount(int disc)
        {
            int diskon = disc;
            return diskon;
        }
        public float getDiscount(float disc)
        {
            float diskon = disc;
            return diskon;
        }
        public override float Discount()
        {
            float Diskon;
            int Id = CustomerId;
            if (Id == 1)
            {
                Diskon = 50;
                return (Diskon);
            }
            else if (Id == 2)
            {
                Diskon = 30;
                return (Diskon);
            }
            else
            {
                return 0;
            }
        }
        public override void getInfo()
        {
            Console.WriteLine("Anda mendapat diskon");
        }
    }
}
