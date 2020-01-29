using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerationsExample
{
    /// <summary>
    /// <c>Book</c> class is used to store the information of books such as Title and Author.
    /// </summary>
    public class Book
    {
        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }

        /// <summary>
        /// String Title varaible Properties
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// String Author variable Properties
        /// </summary>
        public string Author { get; set; }
    }
}
