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
        Definition - What does Generics mean?
Generics refer to a feature in C# that allows defining a class or method with type as a parameter. 

Generics allow for designing a classes and methods whose types are specified only at the time of declaration and instantiation.
This enables development of universal classes and methods that help in improving performance, productivity and type-safety.

Generics are often used in creating collection classes for implementing concepts such as lists, hash tables, queues, etc. 
These classes manage a set of objects and encapsulate operations that are not specific to a particular data type.
            */
        public void Excute()
        {
            Console.WriteLine(   UtilityGeneric.Max(5,6));
            Console.WriteLine(UtilityGeneric.IsBetween(4,3,6));
            Console.WriteLine(UtilityGeneric.IsBetween(7, 3, 6));
            Book b1 = new Book() { Rank = 5 };
            Book b2 = new Book() { Rank = 7 };
            Book max = UtilityGeneric.Max<Book>(b1, b2);
            Console.WriteLine(UtilityGeneric.Max(b1,b2).Rank);

        }
    }
}
