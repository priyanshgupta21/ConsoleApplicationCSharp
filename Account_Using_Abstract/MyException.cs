using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Using_Abstract
{
    internal class MyException:SystemException
    {
        public MyException(string mess) 
        { 
            Message = mess;
        }
        public string Message { get; set; }
    }
}
