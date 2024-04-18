using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.CustomException
{
    public class NotSuitableDriverFound: Exception
    {
        public NotSuitableDriverFound(string msg) : base(msg)
        {
        }
    }
}
