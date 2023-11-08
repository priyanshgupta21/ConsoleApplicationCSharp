using System.Security.Principal;

namespace Account_Using_Abstract
{
    internal class Program
    {
      static void Main(string[] args)
        {
            Account[] a = new Account[4];
            a[0] = null;
            a[1] = null;
            a[2] = null;
            a[3] = null;
          try
            {
                a[0] = new Saviing_account("PRIYANSH", 8000);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try { 
                     a[1] = new Saviing_account("VAIBHAV", 4000);
                  }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try { 
                    a[2] = new Current_account("SID", 6000);               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                a[3] = new Current_account("RITIK", 7000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i].wdevent += (a, balence, name) => { Console.WriteLine("E-mail : Amount withdrawn : {0} new bal={1} name={2}", a, balence, name); };
                a[i].wdevent += (a, balence, name) => { Console.WriteLine("Message : Amount withdrawn : {0} new bal={1} name={2}", a, balence, name); };
                a[i].dipevent += (a, balence, name) => { Console.WriteLine("E-mail : Amount diposited : {0} new bal={1} name={2}", a, balence, name); };
                a[i].dipevent += (a, balence, name) => { Console.WriteLine("Message : Amount withdrawn : {0} new bal={1} name={2}", a, balence, name); };
            }
            a[0].deposit(200);
            Console.WriteLine("***************************************************************");
            a[0].GetName();
            a[0].withdraw(1000);
            Console.WriteLine("***************************************************************");
            Console.WriteLine(a[0]);
            Console.WriteLine("***************************************************************");
             a[1].withdraw(2200);
            Console.WriteLine("***************************************************************");
            Console.WriteLine(a[1]);
            Console.WriteLine("***************************************************************");
            a[2].withdraw(6200);
             Console.WriteLine("***************************************************************");
            Console.WriteLine(a[2]);
            Console.WriteLine("***************************************************************");
            a[3].withdraw(2000);
            Console.WriteLine("****************************************************************");
            Console.WriteLine(a[3]);
            Console.WriteLine("****************************************************************");
            a[0].intrest();
            Console.WriteLine(a[0]);         
        }
    }
}