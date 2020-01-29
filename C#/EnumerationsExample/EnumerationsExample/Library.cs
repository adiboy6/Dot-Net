using System;
using System.Collections;

namespace EnumerationsExample
{
    /// <summary>
    ///<para><c>Mode</c> enumeration which is used to tell how the array should be parsed.</para>
    /// </summary>
    /// <remarks>Mode of parsing an array</remarks>
    public enum Mode
    {
        Forward,
        Reverse
    }

    /// <summary>
    /// <para>A <c>Library</c> class which holds a list of books.</para>
    /// <para>Implements IEnumerable</para>
    /// </summary>
    /// <remarks>A list of books stored in library which implements IEnumerable.</remarks>
    public class Library : IEnumerable
    {
        private Book[] _library;
        private Mode _mode;

        /// <summary>
        /// <c>Library</c> class constructor which stores a list of books in _library member. 
        /// </summary>
        /// <param name="books">An array of book objects.</param>
        /// <param name="mode">An enum variable.</param>
        public Library(Book[] books, Mode mode)
        {
            this._library = new Book[books.Length];

            for (int i = 0; i < books.Length; i++)
                _library[i] = books[i];

            this._mode = mode;
        }

        /// <summary>
        /// In <c>foreach</c>, when the list is used, this method is called.
        /// </summary>
        /// <returns>Calls GetEnumerator()</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        /// <summary>
        /// Implements GetEnumerator()
        /// </summary>
        /// <returns>Returns a LibraryEnum object</returns>
        public LibraryEnum GetEnumerator()
        {
            return new LibraryEnum(_library,_mode);
        }
    }
}
