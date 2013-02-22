using System;
using System.Text;
using System.Linq;

namespace GenericList
{
    public class GenericList<T>
    {
        /// <summary>
        /// 5. Write a generic class GenericList<T> that keeps a list of elements of some 
        /// parametric type T. Keep the elements of the list in an array with
        /// fixed capacity which is given as parameter in the class 
        /// constructor. Implement methods for adding element, accessing 
        /// element by index, removing element by index, inserting element 
        /// at given position, clearing the list, finding element by its 
        /// value and ToString(). Check all input parameters to avoid 
        /// accessing elements at invalid positions.
        /// 6. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        /// 
        /// </summary>
        
        #region Fields
        
        private int count;
        private static readonly int CAPACITY = 4;
        private T[] arr;

        #endregion

        #region Constructors
        
        public GenericList()
        {
            count = 0;
            arr = new T[CAPACITY];
        }

        #endregion

        #region Properties
        
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentException("Invalid index");
                }
                return this.arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentException("Invalid index");
                }
                this.arr[index] = value;
            }
        }
        
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        #endregion

        #region Methods
        
        //Add
        public void Add(T item)
        {
            InsertAt(Count, item);
        }
        
        //Insert(index)
        public void InsertAt(int index, T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Invalid item value (null)");
            }
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            count++;
            T[] newArr = arr;
            if (count == arr.Length)
            {
                newArr = new T[arr.Length * 2];
            }
            Array.Copy(arr, newArr, index);
            Array.Copy(arr, index, newArr, index + 1, Count - index - 1);
            newArr[index] = item;
            arr = newArr;
        }
        
        //Remove(index)
        public T Remove(int index)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            T item = arr[index];
            T[] newArr = arr;
            Array.Copy(arr, newArr, index);
            Array.Copy(arr, index + 1, newArr, index, --count);
            arr = newArr;
            return item;
        }
        
        //Clear
        public void Clear()
        {
            arr = new T[CAPACITY];
            count = 0;
        }
        
        //ToString
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                result.Append(arr[i] + " ");
            }
            return result.ToString();
        }

        //7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.
        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = arr.Min();
            return min;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            dynamic max = arr.Max();
            return max;
        }
        #endregion
    }
}
