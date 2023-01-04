namespace Library_App
{
    internal class Book
    {
        /// Private fields
        private string name;
        private string? author;

        /// Static field
        public static int counter;

        // * Encapsulation *
        /// Properties
        public string Name { get { return name; } }
        public string? Author { get { return author; } }

        // * Polymorphism *
        /// Constructer for 2 argument: name, author
        public Book(string name, string author)
        {
            this.name  = name;
            this.author = author;
            counter++;
        }
        /// Constructer for 1 argument: name
        public Book(string name)
        {
            this.name = name;
            author = null;
            counter++;
        }

        /// Decrease the counter
        static public void RemoveBook() => counter--;

        /// Destructer - Decrease the counter for garbage collection
        ~Book() => counter--;

    }
}
