using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class CustomList : ICollection
    {
        //Count + 1
        private int _index;

        //Capacity
        private int _capacity;

        private object[] array;

        //
        // Summary:
        //     Initializes a new instance of the System.Collections.ArrayList class that contains
        //     elements copied from the specified collection and that has the same initial capacity
        //     as the number of elements copied.
        //
        // Parameters:
        //   c:
        //     The System.Collections.ICollection whose elements are copied to the new list.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     c is null.
        public CustomList()
        {
            _capacity = 4;
            array = new object[_capacity];
            _index = -1;
        }

        //
        // Summary:
        //     Gets a value indicating whether access to the System.Collections.ArrayList is
        //     synchronized (thread safe).
        //
        // Returns:
        //     true if access to the System.Collections.ArrayList is synchronized (thread safe);
        //     otherwise, false. The default is false.
        public bool IsSynchronized { get; }

        //
        // Summary:
        //     Gets a value indicating whether the System.Collections.ArrayList is read-only.
        //
        // Returns:
        //     true if the System.Collections.ArrayList is read-only; otherwise, false. The
        //     default is false.
        public bool IsReadOnly { get; }

        //
        // Summary:
        //     Gets a value indicating whether the System.Collections.ArrayList has a fixed
        //     size.
        //
        // Returns:
        //     true if the System.Collections.ArrayList has a fixed size; otherwise, false.
        //     The default is false.
        public bool IsFixedSize { get; }

        //
        // Summary:
        //     Gets an object that can be used to synchronize access to the System.Collections.ArrayList.
        //
        // Returns:
        //     An object that can be used to synchronize access to the System.Collections.ArrayList.
        public object SyncRoot { get; }

        //
        // Summary:
        //     Gets the number of elements actually contained in the System.Collections.ArrayList.
        //
        // Returns:
        //     The number of elements actually contained in the System.Collections.ArrayList.
        public int Count
        {
            get
            {
                return _index + 1;
            }
        }

        //
        // Summary:
        //     Gets or sets the number of elements that the System.Collections.ArrayList can
        //     contain.
        //
        // Returns:
        //     The number of elements that the System.Collections.ArrayList can contain.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     System.Collections.ArrayList.Capacity is set to a value that is less than System.Collections.ArrayList.Count.
        //
        //   T:System.OutOfMemoryException:
        //     There is not enough memory available on the system.
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        
        public virtual object this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        //
        // Summary:
        //     Adds an object to the end of the System.Collections.ArrayList.
        //
        // Parameters:
        //   value:
        //     The System.Object to be added to the end of the System.Collections.ArrayList.
        //     The value can be null.
        //
        // Returns:
        //     The System.Collections.ArrayList index at which the value has been added.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public int Add(object value)
        {
            if (IsFixedSize == true || IsReadOnly == true)
                throw new NotSupportedException();

            if (_index == (Capacity - 1))
            { 
                Capacity *= 2;

                object[] temp = new object[Capacity];
                CopyTo(temp, 0);
                array = temp;
            }
            array[++_index] = value;
            return _index;
        }

        //
        // Summary:
        //     Adds the elements of an System.Collections.ICollection to the end of the System.Collections.ArrayList.
        //
        // Parameters:
        //   c:
        //     The System.Collections.ICollection whose elements should be added to the end
        //     of the System.Collections.ArrayList. The collection itself cannot be null, but
        //     it can contain elements that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     c is null.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public void AddRange(ICollection c)
        {
            if (c == null)
                throw new ArgumentNullException();

            if (IsFixedSize == true || IsReadOnly == true)
                throw new NotSupportedException();

            foreach (var x in c)
                array[_index] = x;
        }

        //
        // Summary:
        //     Copies the entire System.Collections.ArrayList to a compatible one-dimensional
        //     System.Array, starting at the specified index of the target array.
        //
        // Parameters:
        //   array:
        //     The one-dimensional System.Array that is the destination of the elements copied
        //     from System.Collections.ArrayList. The System.Array must have zero-based indexing.
        //
        //   arrayIndex:
        //     The zero-based index in array at which copying begins.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     array is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     arrayIndex is less than zero.
        //
        //   T:System.ArgumentException:
        //     array is multidimensional. -or- The number of elements in the source System.Collections.ArrayList
        //     is greater than the available space from arrayIndex to the end of the destination
        //     array.
        //
        //   T:System.InvalidCastException:
        //     The type of the source System.Collections.ArrayList cannot be cast automatically
        //     to the type of the destination array.
        public void CopyTo(Array target_array, int target_index)
        {
            if (target_array == null)
                throw new ArgumentNullException();

            if ((target_array.Length - target_index) < Count)
                throw new ArgumentException();
            
            for(int index = 0; index < Count; index++)
            {
                target_array.SetValue(array[index], target_index);
                target_index++;
            }
        }

        //
        // Summary:
        //     Copies the entire System.Collections.ArrayList to a compatible one-dimensional
        //     System.Array, starting at the beginning of the target array.
        //
        // Parameters:
        //   array:
        //     The one-dimensional System.Array that is the destination of the elements copied
        //     from System.Collections.ArrayList. The System.Array must have zero-based indexing.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     array is null.
        //
        //   T:System.ArgumentException:
        //     array is multidimensional. -or- The number of elements in the source System.Collections.ArrayList
        //     is greater than the number of elements that the destination array can contain.
        //
        //   T:System.InvalidCastException:
        //     The type of the source System.Collections.ArrayList cannot be cast automatically
        //     to the type of the destination array.
        public void CopyTo(Array array)
        {
            CopyTo(array, 0);
        }

        //
        // Summary:
        //     Searches for the specified System.Object and returns the zero-based index of
        //     the first occurrence within the range of elements in the System.Collections.ArrayList
        //     that starts at the specified index and contains the specified number of elements.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        //   startIndex:
        //     The zero-based starting index of the search. 0 (zero) is valid in an empty list.
        //
        //   count:
        //     The number of elements in the section to search.
        //
        // Returns:
        //     The zero-based index of the first occurrence of value within the range of elements
        //     in the System.Collections.ArrayList that starts at startIndex and contains count
        //     number of elements, if found; otherwise, -1.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     startIndex is outside the range of valid indexes for the System.Collections.ArrayList.
        //     -or- count is less than zero. -or- startIndex and count do not specify a valid
        //     section in the System.Collections.ArrayList.
        public int IndexOf(object value, int startIndex, int count)
        {
            if ((startIndex >= Count) || (startIndex < 0) || ((startIndex + count) > Count))
                throw new ArgumentOutOfRangeException();
            for(int index = startIndex; index < (startIndex + count); index++)
            {
                if (array[index].Equals(value))
                    return index;
            }
            return -1;
        }

        //
        // Summary:
        //     Searches for the specified System.Object and returns the zero-based index of
        //     the first occurrence within the range of elements in the System.Collections.ArrayList
        //     that extends from the specified index to the last element.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        //   startIndex:
        //     The zero-based starting index of the search. 0 (zero) is valid in an empty list.
        //
        // Returns:
        //     The zero-based index of the first occurrence of value within the range of elements
        //     in the System.Collections.ArrayList that extends from startIndex to the last
        //     element, if found; otherwise, -1.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     startIndex is outside the range of valid indexes for the System.Collections.ArrayList.
        public int IndexOf(object value, int startIndex)
        {
            return IndexOf(value, startIndex, Count);
        }

        //
        // Summary:
        //     Searches for the specified System.Object and returns the zero-based index of
        //     the first occurrence within the entire System.Collections.ArrayList.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        // Returns:
        //     The zero-based index of the first occurrence of value within the entire System.Collections.ArrayList,
        //     if found; otherwise, -1.
        public int IndexOf(object value)
        {
            return IndexOf(value, 0);
        }

        //
        // Summary:
        //     Inserts an element into the System.Collections.ArrayList at the specified index.
        //
        // Parameters:
        //   index:
        //     The zero-based index at which value should be inserted.
        //
        //   value:
        //     The System.Object to insert. The value can be null.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- index is greater than System.Collections.ArrayList.Count.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public void Insert(int targetIndex, object value)
        {
            if ((targetIndex < 0) || (targetIndex > Count))
                throw new ArgumentOutOfRangeException();

            if (IsReadOnly || IsFixedSize)
                throw new NotSupportedException();

            object[] temp = new object[Count + 1];

            int array_index = 0;

            for(int index = 0; index < (Count + 1); index++)
            {
                if (index != targetIndex)
                    temp[index] = array[array_index++];
                else
                    temp[index] = value;
            }

            _index++;

            array = temp;

        }

        //
        // Summary:
        //     Removes the first occurrence of a specific object from the System.Collections.ArrayList.
        //
        // Parameters:
        //   obj:
        //     The System.Object to remove from the System.Collections.ArrayList. The value
        //     can be null.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public void Remove(object obj)
        {
            if (IsReadOnly || IsFixedSize)
                throw new NotSupportedException();

            int obj_index = IndexOf(obj);
            int temp_index = 0;

            object[] temp = new object[Count - 1];

            for(int index = 0; index < Count; index++)
            {
                if (index != obj_index)
                    temp[temp_index++] = array[index];
            }

            _index--;

            array = temp;

        }

        //
        // Summary:
        //     Removes the element at the specified index of the System.Collections.ArrayList.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the element to remove.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- index is equal to or greater than System.Collections.ArrayList.Count.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public void RemoveAt(int index)
        {
            RemoveRange(index, 1);
        }

        //
        // Summary:
        //     Removes a range of elements from the System.Collections.ArrayList.
        //
        // Parameters:
        //   index:
        //     The zero-based starting index of the range of elements to remove.
        //
        //   count:
        //     The number of elements to remove.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- count is less than zero.
        //
        //   T:System.ArgumentException:
        //     index and count do not denote a valid range of elements in the System.Collections.ArrayList.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public void RemoveRange(int target_index, int count)
        {
            if ((target_index < 0) || (target_index > Count))
                throw new ArgumentOutOfRangeException();

            if ((target_index + count - 1) > Count)
                throw new ArgumentException();

            if (IsReadOnly || IsFixedSize)
                throw new NotSupportedException();

            int temp_index = 0;

            object[] temp = new object[Count - (count)];

            for (int index = 0; index < Count; index++)
            {
                if ((index < target_index) || (index > (target_index + count - 1)))
                    temp[temp_index++] = array[index];
            }

            _index=temp.Length - 1 ;

            array = temp;
        }

    }
}
