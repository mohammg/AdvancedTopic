using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Generic
{
   
    class GenericArray<T>where T:struct
    {
        private T[] arr;
        public GenericArray(int length)
        {
            arr = new T[length];
        }
        public T[] Arr { get { return arr; } }

        public T Get(int index)
        {
            return arr[index];
        }
        public void SetValue(int index, T value)
        {
            arr[index] = value;
        }

    }
    class UtilityGeneric
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
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
            return inclusive ? (first.CompareTo(test) < 0) && (test.CompareTo(last) < 0) :
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
   /* class ManageList<T> where T :class
    {
        List<KeyValuePair<string, List<T>>> list = new List<KeyValuePair<string, List<T>>>();
        public List<T> this[int index]
        {
            get {
                if (index<0|| index > list.Count)
                {
                    return null;
                }
               
                return list[index].Value;
            }
            set {
                if (index < 0 || index > list.Count)
                {
                    throw new  IndexOutOfRangeException();
                }
                var key = list[index].Key;
                list[index] = new KeyValuePair<string, List<T>>(key, value);

            }
        }
        public List<T> this[string index]
        {
            get {
                var res = list.Where(a => a.Key == index);
                if (res.Count()>0)
                {
                    return res.FirstOrDefault().Value;
                }
                return null;
            }
            set {
                var res = list.Where(a => a.Key == index);
                if (res.Count() > 0)
                {
                    res.FirstOrDefault().Value=value;
                }

            }
        }
    }*/
    class Book2 : IComparable
    {
        public int Year { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {/*
            0 =
            1 >
            -1< 
             
             */
            return this.Rank.CompareTo(((Book)obj).Rank);
        }
    }

}
