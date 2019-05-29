using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Generic
{
    class GenericTopic : ICommandTopic
    {
        /*
     allow you to define the specification of the data type of programming elements in a class or a method, until it is actually used in the program. In other words, generics allow you to write a class or method that can work with any data type.

You write the specifications for the class or the method, with substitute parameters for data types. When the compiler encounters a constructor for the class or a function call for the method, it generates code to handle the specific data type. A simple example would help understanding the concept
*/
        public void Excute()
        {

           // GenericArray<string> strarr = new GenericArray<string>(5);

            
            Console.WriteLine(   UtilityGeneric.Max<int>(5,6));
            Console.WriteLine(UtilityGeneric.IsBetween(4,3,6));
            //Console.WriteLine(UtilityGeneric.IsBetween(7, 3, 6));
            //Book b1 = new Book() { Rank = 5 };
            //Book b2 = new Book() { Rank = 7 };
            //Book max = UtilityGeneric.Max<Book>(b1, b2);
            //Console.WriteLine(UtilityGeneric.Max(b1,b2).Rank);

        }
    }
}
