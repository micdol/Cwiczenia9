using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia9
{
    class RestOfTheProgram
    {
        public static void ShowResult(DelegateTest.ReturnResult showMethod, string res)
        {
            showMethod(res);
        }

        public static void ShowResult(DelegateTest.ReturnResult showMethod, Func<double, double> calcFun, double d1)
        {
            showMethod("Result: " + calcFun(d1).ToString());            
        }

        public static void ShowResult(DelegateTest.ReturnResult showMethod, Func<double, double, double> calcFun, double d1, double d2)
        {
            showMethod("Result: " + calcFun(d1, d2).ToString());
        }
    }
}
