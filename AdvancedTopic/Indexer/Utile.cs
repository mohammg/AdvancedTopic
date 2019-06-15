using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic.Indexer
{
    class GenericArray<T> where T : struct
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
        public T this[int index]
        {
            get
            {
                T tmp;

                if (index >= 0 && index <= arr.Length - 1)
                {
                    tmp = arr[index];
                }
                else
                {
                    return default(T);
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= arr.Length - 1)
                {
                    arr[index] = value;
                }
            }
        }
    }
}
