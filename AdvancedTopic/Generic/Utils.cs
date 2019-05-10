using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Generic
{
    class GenericValu<T>
    {
        public T Value { get; set; }

        public T Get()
        {
            return Value;
        }
        public void GDisplay<AnotherType>(string msg, AnotherType type)
        {
            Console.WriteLine($"{msg}:{type}");
        }

    }
    class UtilityGeneric
    {
        public static T Max<T>(T first, T second) where T : IComparable
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else if (first.CompareTo(second) < 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
        public static bool IsBetween<T>(T test, T first, T last, bool inclusive = false) where T : IComparable
        {
            return inclusive ? (first.CompareTo(test) <= 0) && (test.CompareTo(last) <= 0) :
                               (first.CompareTo(test) <= 0) && (test.CompareTo(last) <= 0);
        }
    }
    class Book : IComparable
    {
        public int Rank { get; set; }


        public int CompareTo(object obj)
        {
            return this.Rank.CompareTo(((Book)obj).Rank);
        }
    }
    class ObjClass<T> where T : class
    {
        List<T> list = new List<T>();
        public void Add(T t)
        {

        }
        public void Edit(T t)
        {

        }

    }
    class Book2 : IComparable
    {
        public int Year { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            return this.Rank.CompareTo(((Book)obj).Rank);
        }
    }

}
