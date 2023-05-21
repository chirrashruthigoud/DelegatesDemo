using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate int DelegateDemo(int x, int y);
    public delegate void MultiDelegateDemo(int x, int y);

    public class Program
    {
        public static void Main(string[] args)
        {
            DelegatesClass Class = new DelegatesClass();

            DelegateDemo del = new DelegateDemo(Class.FirstMethod);
            Console.WriteLine(del(25, 5));
            DelegateDemo dele = new DelegateDemo(Class.SecondMethod);
            Console.WriteLine(del(25, 50));
            //Console.WriteLine(Class.FirstMethod(50,63));
            //Console.WriteLine(Class.SecondMethod(20,30));

            //MultipleDelegates multiple = new MultipleDelegates();
            //MultiDelegateDemo multipleDelegates = new MultiDelegateDemo(MultipleDelegates.FirstMethods);
            //MultiDelegateDemo multipleDelegates = MultipleDelegates.FirstMethods;
            MultiDelegateDemo multiDelegate = MultipleDelegates.FirstMethods;
            multiDelegate += MultipleDelegates.SecondMethods;
           // multiDelegate += MultipleDelegates.FirstMethods;
            multiDelegate(20, 3);
            Console.ReadLine();
        }
    }
}
