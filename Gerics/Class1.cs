using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerics
{
    public class Class1
    {
       public static void  Main(string[] args)
        {
            dispaly<int>(1, 2);
            dispaly<string>("Test", "jsdfj");

        }
         public static T dispaly<T>(T v1 ,T v2)
        {
              dynamic result = v1;
               result += (dynamic)v2;
               Console.WriteLine(result);
               return result;
        }
    }
}
