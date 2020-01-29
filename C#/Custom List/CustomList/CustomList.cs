using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class CustomList : ICollection
    {
        private int _index;
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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets an object that can be used to synchronize access to the System.Collections.ArrayList.
        //
        // Returns:
        //     An object that can be used to synchronize access to the System.Collections.ArrayList.
        public object SyncRoot { get; }
        /*
        //
        // Summary:
        //     Creates an System.Collections.ArrayList wrapper for a specific System.Collections.IList.
        //
        // Parameters:
        //   list:
        //     The System.Collections.IList to wrap.
        //
        // Returns:
        //     The System.Collections.ArrayList wrapper around the System.Collections.IList.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static ArrayList Adapter(IList list);

        //
        // Summary:
        //     Returns an System.Collections.ArrayList wrapper with a fixed size.
        //
        // Parameters:
        //   list:
        //     The System.Collections.ArrayList to wrap.
        //
        // Returns:
        //     An System.Collections.ArrayList wrapper with a fixed size.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static ArrayList FixedSize(ArrayList list);
        
        //
        // Summary:
        //     Returns an System.Collections.IList wrapper with a fixed size.
        //
        // Parameters:
        //   list:
        //     The System.Collections.IList to wrap.
        //
        // Returns:
        //     An System.Collections.IList wrapper with a fixed size.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static IList FixedSize(IList list);
        
        //
        // Summary:
        //     Returns a read-only System.Collections.IList wrapper.
        //
        // Parameters:
        //   list:
        //     The System.Collections.IList to wrap.
        //
        // Returns:
        //     A read-only System.Collections.IList wrapper around list.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static IList ReadOnly(IList list);
        
        //
        // Summary:
        //     Returns a read-only System.Collections.ArrayList wrapper.
        //
        // Parameters:
        //   list:
        //     The System.Collections.ArrayList to wrap.
        //
        // Returns:
        //     A read-only System.Collections.ArrayList wrapper around list.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static ArrayList ReadOnly(ArrayList list);
        
        //
        // Summary:
        //     Returns an System.Collections.ArrayList whose elements are copies of the specified
        //     value.
        //
        // Parameters:
        //   value:
        //     The System.Object to copy multiple times in the new System.Collections.ArrayList.
        //     The value can be null.
        //
        //   count:
        //     The number of times value should be copied.
        //
        // Returns:
        //     An System.Collections.ArrayList with count number of elements, all of which are
        //     copies of value.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     count is less than zero.
        public static ArrayList Repeat([NullableAttribute(2)] object? value, int count);
        
        //
        // Summary:
        //     Returns an System.Collections.ArrayList wrapper that is synchronized (thread
        //     safe).
        //
        // Parameters:
        //   list:
        //     The System.Collections.ArrayList to synchronize.
        //
        // Returns:
        //     An System.Collections.ArrayList wrapper that is synchronized (thread safe).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static ArrayList Synchronized(ArrayList list);
        
        //
        // Summary:
        //     Returns an System.Collections.IList wrapper that is synchronized (thread safe).
        //
        // Parameters:
        //   list:
        //     The System.Collections.IList to synchronize.
        //
        // Returns:
        //     An System.Collections.IList wrapper that is synchronized (thread safe).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     list is null.
        public static IList Synchronized(IList list);
        */
        
        /*
        //
        // Summary:
        //     Searches the entire sorted System.Collections.ArrayList for an element using
        //     the default comparer and returns the zero-based index of the element.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate. The value can be null.
        //
        // Returns:
        //     The zero-based index of value in the sorted System.Collections.ArrayList, if
        //     value is found; otherwise, a negative number, which is the bitwise complement
        //     of the index of the next element that is larger than value or, if there is no
        //     larger element, the bitwise complement of System.Collections.ArrayList.Count.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     Neither value nor the elements of System.Collections.ArrayList implement the
        //     System.IComparable interface.
        //
        //   T:System.InvalidOperationException:
        //     value is not of the same type as the elements of the System.Collections.ArrayList.
        [NullableContextAttribute(2)]
        public  int BinarySearch(object? value);
        
        //
        // Summary:
        //     Searches a range of elements in the sorted System.Collections.ArrayList for an
        //     element using the specified comparer and returns the zero-based index of the
        //     element.
        //
        // Parameters:
        //   index:
        //     The zero-based starting index of the range to search.
        //
        //   count:
        //     The length of the range to search.
        //
        //   value:
        //     The System.Object to locate. The value can be null.
        //
        //   comparer:
        //     The System.Collections.IComparer implementation to use when comparing elements.
        //     -or- null to use the default comparer that is the System.IComparable implementation
        //     of each element.
        //
        // Returns:
        //     The zero-based index of value in the sorted System.Collections.ArrayList, if
        //     value is found; otherwise, a negative number, which is the bitwise complement
        //     of the index of the next element that is larger than value or, if there is no
        //     larger element, the bitwise complement of System.Collections.ArrayList.Count.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     index and count do not denote a valid range in the System.Collections.ArrayList.
        //     -or- comparer is null and neither value nor the elements of System.Collections.ArrayList
        //     implement the System.IComparable interface.
        //
        //   T:System.InvalidOperationException:
        //     comparer is null and value is not of the same type as the elements of the System.Collections.ArrayList.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- count is less than zero.
        [NullableContextAttribute(2)]
        public  int BinarySearch(int index, int count, object? value, IComparer? comparer);
        
        //
        // Summary:
        //     Searches the entire sorted System.Collections.ArrayList for an element using
        //     the specified comparer and returns the zero-based index of the element.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate. The value can be null.
        //
        //   comparer:
        //     The System.Collections.IComparer implementation to use when comparing elements.
        //     -or- null to use the default comparer that is the System.IComparable implementation
        //     of each element.
        //
        // Returns:
        //     The zero-based index of value in the sorted System.Collections.ArrayList, if
        //     value is found; otherwise, a negative number, which is the bitwise complement
        //     of the index of the next element that is larger than value or, if there is no
        //     larger element, the bitwise complement of System.Collections.ArrayList.Count.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     comparer is null and neither value nor the elements of System.Collections.ArrayList
        //     implement the System.IComparable interface.
        //
        //   T:System.InvalidOperationException:
        //     comparer is null and value is not of the same type as the elements of the System.Collections.ArrayList.
        [NullableContextAttribute(2)]
        public  int BinarySearch(object? value, IComparer? comparer);
        
        //
        // Summary:
        //     Removes all elements from the System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public  void Clear();
        
        //
        // Summary:
        //     Creates a shallow copy of the System.Collections.ArrayList.
        //
        // Returns:
        //     A shallow copy of the System.Collections.ArrayList.
        public  object Clone();
        
        //
        // Summary:
        //     Determines whether an element is in the System.Collections.ArrayList.
        //
        // Parameters:
        //   item:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        // Returns:
        //     true if item is found in the System.Collections.ArrayList; otherwise, false.
        [NullableContextAttribute(2)]
        public  bool Contains(object? item);
        
        //
        // Summary:
        //     Copies a range of elements from the System.Collections.ArrayList to a compatible
        //     one-dimensional System.Array, starting at the specified index of the target array.
        //
        // Parameters:
        //   index:
        //     The zero-based index in the source System.Collections.ArrayList at which copying
        //     begins.
        //
        //   array:
        //     The one-dimensional System.Array that is the destination of the elements copied
        //     from System.Collections.ArrayList. The System.Array must have zero-based indexing.
        //
        //   arrayIndex:
        //     The zero-based index in array at which copying begins.
        //
        //   count:
        //     The number of elements to copy.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     array is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- arrayIndex is less than zero. -or- count is less
        //     than zero.
        //
        //   T:System.ArgumentException:
        //     array is multidimensional. -or- index is equal to or greater than the System.Collections.ArrayList.Count
        //     of the source System.Collections.ArrayList. -or- The number of elements from
        //     index to the end of the source System.Collections.ArrayList is greater than the
        //     available space from arrayIndex to the end of the destination array.
        //
        //   T:System.InvalidCastException:
        //     The type of the source System.Collections.ArrayList cannot be cast automatically
        //     to the type of the destination array.
        public  void CopyTo(int index, Array array, int arrayIndex, int count);
        
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
        public  void CopyTo(Array array);
        
        //
        // Summary:
        //     Returns an enumerator for a range of elements in the System.Collections.ArrayList.
        //
        // Parameters:
        //   index:
        //     The zero-based starting index of the System.Collections.ArrayList section that
        //     the enumerator should refer to.
        //
        //   count:
        //     The number of elements in the System.Collections.ArrayList section that the enumerator
        //     should refer to.
        //
        // Returns:
        //     An System.Collections.IEnumerator for the specified range of elements in the
        //     System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- count is less than zero.
        //
        //   T:System.ArgumentException:
        //     index and count do not specify a valid range in the System.Collections.ArrayList.
        public  IEnumerator GetEnumerator(int index, int count);
        
        //
        // Summary:
        //     Returns an enumerator for the entire System.Collections.ArrayList.
        //
        // Returns:
        //     An System.Collections.IEnumerator for the entire System.Collections.ArrayList.
        public  IEnumerator GetEnumerator();
        
        //
        // Summary:
        //     Returns an System.Collections.ArrayList which represents a subset of the elements
        //     in the source System.Collections.ArrayList.
        //
        // Parameters:
        //   index:
        //     The zero-based System.Collections.ArrayList index at which the range starts.
        //
        //   count:
        //     The number of elements in the range.
        //
        // Returns:
        //     An System.Collections.ArrayList which represents a subset of the elements in
        //     the source System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- count is less than zero.
        //
        //   T:System.ArgumentException:
        //     index and count do not denote a valid range of elements in the System.Collections.ArrayList.
        public  ArrayList GetRange(int index, int count);
        
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
        [NullableContextAttribute(2)]
        public  int IndexOf(object? value, int startIndex, int count);
        
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
        [NullableContextAttribute(2)]
        public  int IndexOf(object? value, int startIndex);
        
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
        [NullableContextAttribute(2)]
        public  int IndexOf(object? value);
        
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
        [NullableContextAttribute(2)]
        public  void Insert(int index, object? value);
        
        //
        // Summary:
        //     Inserts the elements of a collection into the System.Collections.ArrayList at
        //     the specified index.
        //
        // Parameters:
        //   index:
        //     The zero-based index at which the new elements should be inserted.
        //
        //   c:
        //     The System.Collections.ICollection whose elements should be inserted into the
        //     System.Collections.ArrayList. The collection itself cannot be null, but it can
        //     contain elements that are null.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     c is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- index is greater than System.Collections.ArrayList.Count.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public  void InsertRange(int index, ICollection c);
        
        //
        // Summary:
        //     Searches for the specified System.Object and returns the zero-based index of
        //     the last occurrence within the entire System.Collections.ArrayList.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        // Returns:
        //     The zero-based index of the last occurrence of value within the entire the System.Collections.ArrayList,
        //     if found; otherwise, -1.
        [NullableContextAttribute(2)]
        public  int LastIndexOf(object? value);
        
        //
        // Summary:
        //     Searches for the specified System.Object and returns the zero-based index of
        //     the last occurrence within the range of elements in the System.Collections.ArrayList
        //     that contains the specified number of elements and ends at the specified index.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        //   startIndex:
        //     The zero-based starting index of the backward search.
        //
        //   count:
        //     The number of elements in the section to search.
        //
        // Returns:
        //     The zero-based index of the last occurrence of value within the range of elements
        //     in the System.Collections.ArrayList that contains count number of elements and
        //     ends at startIndex, if found; otherwise, -1.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     startIndex is outside the range of valid indexes for the System.Collections.ArrayList.
        //     -or- count is less than zero. -or- startIndex and count do not specify a valid
        //     section in the System.Collections.ArrayList.
        [NullableContextAttribute(2)]
        public  int LastIndexOf(object? value, int startIndex, int count);
        
        //
        // Summary:
        //     Searches for the specified System.Object and returns the zero-based index of
        //     the last occurrence within the range of elements in the System.Collections.ArrayList
        //     that extends from the first element to the specified index.
        //
        // Parameters:
        //   value:
        //     The System.Object to locate in the System.Collections.ArrayList. The value can
        //     be null.
        //
        //   startIndex:
        //     The zero-based starting index of the backward search.
        //
        // Returns:
        //     The zero-based index of the last occurrence of value within the range of elements
        //     in the System.Collections.ArrayList that extends from the first element to startIndex,
        //     if found; otherwise, -1.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     startIndex is outside the range of valid indexes for the System.Collections.ArrayList.
        [NullableContextAttribute(2)]
        public  int LastIndexOf(object? value, int startIndex);
        
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
        [NullableContextAttribute(2)]
        public  void Remove(object? obj);
        
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
        public  void RemoveAt(int index);
        
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
        public  void RemoveRange(int index, int count);
        
        //
        // Summary:
        //     Reverses the order of the elements in the specified range.
        //
        // Parameters:
        //   index:
        //     The zero-based starting index of the range to reverse.
        //
        //   count:
        //     The number of elements in the range to reverse.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- count is less than zero.
        //
        //   T:System.ArgumentException:
        //     index and count do not denote a valid range of elements in the System.Collections.ArrayList.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only.
        public  void Reverse(int index, int count);
        
        //
        // Summary:
        //     Reverses the order of the elements in the entire System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only.
        public  void Reverse();
        
        //
        // Summary:
        //     Copies the elements of a collection over a range of elements in the System.Collections.ArrayList.
        //
        // Parameters:
        //   index:
        //     The zero-based System.Collections.ArrayList index at which to start copying the
        //     elements of c.
        //
        //   c:
        //     The System.Collections.ICollection whose elements to copy to the System.Collections.ArrayList.
        //     The collection itself cannot be null, but it can contain elements that are null.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- index plus the number of elements in c is greater
        //     than System.Collections.ArrayList.Count.
        //
        //   T:System.ArgumentNullException:
        //     c is null.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only.
        public  void SetRange(int index, ICollection c);
        
        //
        // Summary:
        //     Sorts the elements in the entire System.Collections.ArrayList using the specified
        //     comparer.
        //
        // Parameters:
        //   comparer:
        //     The System.Collections.IComparer implementation to use when comparing elements.
        //     -or- A null reference (Nothing in Visual Basic) to use the System.IComparable
        //     implementation of each element.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only.
        //
        //   T:System.InvalidOperationException:
        //     An error occurred while comparing two elements.
        //
        //   T:System.ArgumentException:
        //     null is passed for comparer, and the elements in the list do not implement System.IComparable.
        [NullableContextAttribute(2)]
        public  void Sort(IComparer? comparer);
        
        //
        // Summary:
        //     Sorts the elements in a range of elements in System.Collections.ArrayList using
        //     the specified comparer.
        //
        // Parameters:
        //   index:
        //     The zero-based starting index of the range to sort.
        //
        //   count:
        //     The length of the range to sort.
        //
        //   comparer:
        //     The System.Collections.IComparer implementation to use when comparing elements.
        //     -or- A null reference (Nothing in Visual Basic) to use the System.IComparable
        //     implementation of each element.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero. -or- count is less than zero.
        //
        //   T:System.ArgumentException:
        //     index and count do not specify a valid range in the System.Collections.ArrayList.
        //
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only.
        //
        //   T:System.InvalidOperationException:
        //     An error occurred while comparing two elements.
        [NullableContextAttribute(2)]
        public  void Sort(int index, int count, IComparer? comparer);
        
        //
        // Summary:
        //     Sorts the elements in the entire System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only.
        public  void Sort();
        
        //
        // Summary:
        //     Copies the elements of the System.Collections.ArrayList to a new System.Object
        //     array.
        //
        // Returns:
        //     An System.Object array containing copies of the elements of the System.Collections.ArrayList.
        [return: NullableAttribute(new[] { 1, 2 })]
        public  object?[] ToArray()
        {
            return array;
        }
        
        //
        // Summary:
        //     Copies the elements of the System.Collections.ArrayList to a new array of the
        //     specified element type.
        //
        // Parameters:
        //   type:
        //     The element System.Type of the destination array to create and copy elements
        //     to.
        //
        // Returns:
        //     An array of the specified element type containing copies of the elements of the
        //     System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        //
        //   T:System.InvalidCastException:
        //     The type of the source System.Collections.ArrayList cannot be cast automatically
        //     to the specified type.
        public  Array ToArray(Type type);
        
        //
        // Summary:
        //     Sets the capacity to the actual number of elements in the System.Collections.ArrayList.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
        //     has a fixed size.
        public  void TrimToSize();
        */
    }
}
