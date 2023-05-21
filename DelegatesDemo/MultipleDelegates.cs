using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class MultipleDelegates
    {
        public static void FirstMethods(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public static void SecondMethods(int x, int y)
        {
            Console.WriteLine(x-y);
        }
    }
}
