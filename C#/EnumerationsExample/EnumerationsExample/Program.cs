using System;

namespace EnumerationsExample
{
    /// <summary>
    /// <c>Program</c> class is the Main class which is used to parse an array of <c>Book</c> objects or a <c>Library</c> object using <c>foreach</c>.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //An array of Book
            Book[] books = new Book[]
            {
                new Book("Mein Kampf","Adolf Hitler"),
                new Book("Inferno","Dan Brown"),
                new Book("The Return of the Native","Thomas Hardy"),
                new Book("The Monk who sold his Ferrari","Robin Sharma")
            };

            //Book array is passed to Library object
            Library library = new Library(books,Mode.Forward);

            //Non-generic class (Library) is parsed using foreach which internally IEnumerable and IEnumerator.
            foreach (Book b in library)
                Console.WriteLine("Title : " + b.Title + "\nAuthor : " + b.Author + "\n");

            //Using LibraryEnum (IEnumerator interface) class
            LibraryEnum library1 = new LibraryEnum(books, Mode.Forward);

            //By using MoveNext, it parses the non-generic collection and value is given by Current
            while (library1.MoveNext())
                Console.WriteLine("Title : " + library1.Current.Title + " " + "\nAuthor + " + library1.Current.Author + "\n");
        }
    }
}
