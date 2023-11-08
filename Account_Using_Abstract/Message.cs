using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Using_Abstract
{
    class Message
    {
        public void wemail(double a, double Balance, string name)
        {
            Console.WriteLine("E-mail : Amount withdrawn : {0} new bal={1} name={2}", a, Balance, name);
        }

        public void wmobile(double a, double Balance, string name)
        {
            Console.WriteLine("Mobile : Amount withdrawn : {0} new bal={1} name={2}", a, Balance, name);
        }

        public void demail(double a, double Balance, string name)
        {
            Console.WriteLine("E-mail : Amount diposit : {0} new bal={1} name={2}", a, Balance, name);
        }

        public void dmobile(double a, double Balance, string name)
        {
            Console.WriteLine("Mobile : Amount diposit : {0}new bal={1} name={2}", a, Balance, name);
        }
    }
}
