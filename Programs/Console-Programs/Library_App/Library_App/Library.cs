namespace Library_App
{
    // * Abstraction *
    abstract class Library_Structure
    {
        /// Abstraction of Library Methods
        public abstract void Add_Book();
        public abstract void Remove_Book();
        public abstract void Show_Books();
    }

    // * Inheritance *
    internal class Library : Library_Structure
    {
        /// Books list
        static private List<Book> books = new List<Book>();

        /// Add Book Method
        public override void Add_Book()
        {
            string? name, author;
            Console.Write("Book name: ");
            name = Console.ReadLine();

            /// If name passed null return
            if (string.IsNullOrEmpty(name)) return;

            Console.Write("Author (enter to pass): ");
            author = Console.ReadLine();

            /// If author passed null invoke 1 argument constructer else 2 argument (Polymorphism)
            if (string.IsNullOrEmpty(author))
                books.Add(new Book(name));
            else
                books.Add(new Book(name, author));

        }

        /// Remove Book Method
        public override void Remove_Book()
        {
            /// Show books to find name
            Show_Books();

            string? name;

            Console.Write("\nBook name: ");
            name = Console.ReadLine();

            /// If name passed null return
            if (string.IsNullOrEmpty(name)) return;

            for (int i = 0; i < books.Count ; i++)
            {
                if (books[i].Name == name)
                {
                    books.RemoveAt(i);
                    Book.RemoveBook();
                    Console.WriteLine("\nBook Removed Successfully!");
                    return;
                }
            }
            Console.WriteLine("\nThe library doesn't have that book.");
        }

        /// Show Book Method
        public override void Show_Books()
        {
            Console.WriteLine($"Currently Library has {Book.counter} books.\n");
            for (int i = 0; i < books.Count; i++)
            {
                // If author exists add 'by {author}' else print book's name
                if (books[i].Author == null)
                    Console.WriteLine($"{i+1}) {books[i].Name}");
                else
                    Console.WriteLine($"{i+1}) {books[i].Name} by {books[i].Author}");
            }
            
        }
    }
}
