using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EnumerationsExample
{
    /// <summary>
    /// <para><c>LibraryEnum</c> implements IEnumerator which has the following:</para>
    /// <list type="bullet">
    /// <item>
    /// <term><c>IEnumerator.Current property</c></term>
    /// <description>Used to get the value at an index which returns <c>Book</c> object.</description>
    /// </item>
    /// <item>
    /// <term><c>MoveNext()</c></term>
    /// <description>Used as an iterator which returns bool value.</description>
    /// </item>
    /// <item>
    /// <term><c>Reset()</c></term>
    /// <description>Used to reset the <c>_index</c> of the array.</description>
    /// </item>
    /// </list>
    /// <para>Whenever <c>IEnumerable</c> interface is implemented, then <c>IEnumerator</c> interface should also be implemented.</para>
    /// </summary>
    /// <remarks>Implementations of <c>IEnumerator</c> methods in <c>LibraryEnum</c> class.</remarks>
    public class LibraryEnum : IEnumerator
    {
        public Book[] library;

        private int _index;
        private Mode _mode;

        /// <summary>
        /// <para><c>LibraryEnum</c> class constructor which sets the <paramref name="books"/> to <c>library</c> member and <paramref name="mode"/> to <c>_mode</c> member.</para>
        /// <para><c>_index</c> is set based on <paramref name="mode"/></para>
        /// </summary>
        /// <param name="books"></param>
        /// <param name="mode"></param>
        public LibraryEnum(Book[] books, Mode mode)
        {
            this.library = books;
            this._mode = mode;

            //Forward mode
            if (this._mode == 0)
                this._index = -1;
            else
                //Reverse mode
                this._index = library.Length;
        }

        /// <summary>
        /// <c>Current</c> property <c>get</c> definition.
        /// </summary>
        public Book Current
        {
            get
            {
                try
                {
                    return library[_index];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException("Index of library is not present");
                }
            }
        }

        /// <summary>
        /// <para>This is called when instance variable in foreach is used.</para>
        /// <para>It in turn called the <c>Current</c> property.</para>
        /// </summary>
        object IEnumerator.Current => Current;

        /// <summary>
        /// <c>MoveNext()</c> method is used to iterate to next value.
        /// </summary>
        /// <returns>Return whether the <c>_index</c> is within the bounds of it's size.</returns>
        public bool MoveNext()
        {
            //Forward mode
            if (this._mode == 0)
            { 
                _index++;
                return (_index < library.Length);
            }
            //Reverse mode
            _index--;
            return (_index > -1);
        }

        /// <summary>
        /// <c>Reset</c> method is used to reset the <c>_index</c> based upon the mode.
        /// </summary>
        public void Reset()
        {
            //Forward mode
            if (this._mode == 0)
                _index = -1;
            else
                _index = library.Length;
        }
    }
}
