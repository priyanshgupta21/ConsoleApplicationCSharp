using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Using_Abstract
{
    delegate void wd(double x, double bal, string nm);

    abstract class Account
    {
        public event wd wdevent;
        public event wd dipevent;
        int id;
        string name;
        double balence;
        static int getid;
        static float intrestrate = 0.07f;

        static Account()
        {
            Console.WriteLine("Wellcome to BANK OF INDIA");
        }
        public Account()
        {
            Id = ++getid;
        }
        public Account(string nm, double balence)
        {
            if (nm.Length < 5)
            {
                throw new MyException("enter valid name");
            }
            if (balence < 1000)
            {
                throw new MyException("account opening ammount must be 1000 or more");
            }
            else
            {
                Id = ++getid;
            }
        }
        public int Id { get; }
        public double Intrest { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balence
        {
            get { return balence; }
            set
            {
                balence = value;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public void deposit(double amount)
        {
            Balence = Balence + amount;
            dipevent(amount, Balence, Name);
        }
        public abstract void withdraw(double amount);
        public void intrest()
        {
            double intrest = Balence * intrestrate;
            Balence += intrest;
            Intrest += intrest;
        }
        public void OnWithdraw(double x, double bal, string nm)
        {
            wdevent(x, bal, nm);
        }
    }
}
