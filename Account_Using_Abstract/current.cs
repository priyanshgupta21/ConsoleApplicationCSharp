using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Account_Using_Abstract
{
    class Current_account : Account
    {
        public Current_account(string nm, double balence) 
        {
            Name = nm;
            Balence = balence;
        }
        public override string ToString()
        {
            return $"id: {Id}\t name:{Name}\t Intrest earned :{Intrest} \t Balence:{Balence} ";
        }

        public override void withdraw(double amount)
        {
            Balence = Balence-amount;
            OnWithdraw(amount, Balence, Name);
        }
    }
}
