using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMember
{
    class MemberCustomer : Customer
    {
        int memberId;
        string dateBegin;

        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        public string DateBegin
        {
            get { return dateBegin; }
            set { dateBegin = value; }
        }
    }
}
