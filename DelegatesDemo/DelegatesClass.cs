using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //a  refernce type variable that hold the referce type to a method
    //we are uing events and triggers for delegates.
    //when you work on delegate we need a return type.
    //whenever we work on Multiple delegate we don't need return tyoe we use void
    //the return type of delegate should be same as method return type

    public class DelegatesClass
    {
        public int FirstMethod(int x,int y)
        {
            return x + y;
        }
        public int SecondMethod(int x,int y)
        {
            return x - y;
        }
    }
}
