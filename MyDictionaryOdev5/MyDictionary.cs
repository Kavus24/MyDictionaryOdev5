using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryOdev5
{
    class MyDictionary<T,T2> 
    {
        T[] _array1;
        T2[] _array2;
        T[] tempArray1;
        T2[] tempArray2;
        public MyDictionary()
        {
            _array1 = new T[0];
            _array2 = new T2[0];
        }

        public void Add(T item,T2 item2)
        {
            tempArray1 = _array1;
            tempArray2 = _array2;
            
            _array1 = new T[_array1.Length+1];
            _array2 = new T2[_array2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                _array1[i] = tempArray1[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                _array2[i] = tempArray2[i];
            }

        }

        public int Count
        {
            get { return _array1.Length; }
           
        }


       
    }
}
