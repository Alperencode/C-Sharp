using Library_App;

main();

void main()
{
    /// Creating Library instance
    Library library = new Library();

    string menu = "[1] Add Book\n[2] Remove Book\n[3] Show Books\n[4] Exit\n\nSelect:";

    while (true)
    {
        Console.Clear();
        Concat_String("Menu");
        Console.Write(menu);

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("\nRedirecting to Add Book Section...");
                Wait_Clear();
                Concat_String("Add Book Section");
                library.Add_Book(); 
                break;

            case "2":
                Console.WriteLine("\nRedirecting to Remove Book Section...");
                Wait_Clear();
                Concat_String("Remove Book Section");
                library.Remove_Book(); 
                break;

            case "3":
                Console.WriteLine("\nRedirecting to Library...");
                Wait_Clear();
                Concat_String("Library");
                library.Show_Books();
                Console.WriteLine("\nEnter to exit.");
                Console.ReadLine();
                break;

            case "4":
                Console.WriteLine("\nGoodbye!");
                Wait_Clear();
                Environment.Exit(0);
                break;
                
            default:
                Console.WriteLine("\nInvalid option");
                break;
        }

        Console.WriteLine("\nRedirecting to Menu...");
        Wait_Clear();
    }
}

/// Print given string with concat '='
void Concat_String(string str) => Console.WriteLine(string.Concat(Enumerable.Repeat("=", 5)) + $" {str} " + string.Concat(Enumerable.Repeat("=", 5)));

/// Wait 1.5 second and clear console
void Wait_Clear() { System.Threading.Thread.Sleep(1250); Console.Clear(); }