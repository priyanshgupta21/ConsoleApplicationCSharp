using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Account_Using_Abstract
{
    class Saviing_account : Account
    {
        public Saviing_account(string nm, double balence):base(nm,balence)
        {
                Name = nm;
                Balence = balence;
        }
        public override void withdraw(double amount)
        {
            const float minbal = 1000;
            double bal = Balence - amount;
            if (bal < minbal)
            {
                throw new Exception($"please maintain Minimum balence {minbal}");
            }
            Balence -= amount;
            OnWithdraw(amount, Balence, Name);
        }
        public override string ToString()
        {
            return $"id: {Id}\t name:{Name}\t Intrest earned :{Intrest} \t Balence:{Balence} ";
        }
    }
}
