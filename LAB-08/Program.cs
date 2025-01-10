namespace LAB_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            var letter = new Letter("Secret content of the letter.");
            var email = new Email("Subject: Important meeting at 10 AM.");
            var sms = new SMS("Reminder: Your appointment is tomorrow.");
            var messenger = new Messenger<IMessage>();
            messenger.Send(letter);
            messenger.Send(email);
            messenger.Send(sms);

            //Zadanie 2
            IEnumerable<string> words = new string[] { "apple", "banana", "cherry", "date", "orange" };
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            var filteredWords = words.Where(w => w.StartsWith("b"));
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
            var uppercasedWords = words.Select(w => w.ToUpper());
            foreach (var word in uppercasedWords)
            {
                Console.WriteLine(word);
            }
            var wordList = words.ToList();
            foreach (var word in wordList)
            {
                Console.WriteLine(word);
            }

            //Zadanie 3
            ICollection<string> words1 = new List<string> { "apple",
                "banana", "cherry", "date", "orange" };
            words1.Add("fig");
            foreach (var word in words1)
            {
                Console.WriteLine(word);
            }
            words1.Remove("date");
            foreach (var word in words1)
            {
                Console.WriteLine(word);
            }
            bool containsCherry = words.Contains("cherry");
            Console.WriteLine($"Does the collection contain" +
                $" 'cherry'? {containsCherry}");

            //Zadanie 4
            List<Books> books = new List<Books>
            {
                new Books("The Whispering Shadows", "Eleanor Blackwood", 1987),
                new Books("Beneath the Silver Moon", "Alexander Greene", 1924),
                new Books("The Clockmaker's Secret", "Olivia Cross", 2013),
                new Books("Echoes of the Forgotten", "Samuel Thorn", 2001),
                new Books("he Garden of Lost Dreams", "Mariana Velez", 1999),
            };
            // functions 
            void AddABook()
            {
                Console.WriteLine("Write a title of the book");
                string titleOfTheBook = Console.ReadLine();
                Console.WriteLine("Write an authorof the book");
                string authorOfTheBook = Console.ReadLine();
                Console.WriteLine("What is the year when the book was published?");
                int yearOfTheBook = int.Parse(Console.ReadLine());
                books.Add(new Books(titleOfTheBook, authorOfTheBook, yearOfTheBook));
                Console.WriteLine($"The book {titleOfTheBook} of {authorOfTheBook}, written in {yearOfTheBook} has been added to the library.");
            }
            void ShowBooks()
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} {book.Author} {book.Year}");
                }
            }
            void SearchABook()
            {
                while (true)
                {
                    Console.WriteLine("Do you want to search by: ");
                    Console.WriteLine("1. Title");
                    Console.WriteLine("2. Author");
                    Console.WriteLine("3. Year");
                    Console.WriteLine("Q. Quit");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Enter a title:");
                        string titleOfTheBook = Console.ReadLine();
                        List<Books> BooksFound = books.FindAll(x => x.Title == titleOfTheBook);
                        foreach (var book in BooksFound)
                        {
                            Console.WriteLine(book.Title + book.Author + book.Year);
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Enter an author:");
                        string authorOfTheBook = Console.ReadLine();
                        List<Books> BooksFound = books.FindAll(x => x.Author == authorOfTheBook);
                        foreach (var book in BooksFound)
                        {
                            Console.WriteLine(book.Title + book.Author + book.Year);
                        }
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Enter a year:");
                        int yearOfTheBook = int.Parse(Console.ReadLine());
                        List<Books> BooksFound = books.FindAll(x => x.Year == yearOfTheBook);
                        foreach (var book in BooksFound)
                        {
                            Console.WriteLine(book.Title + book.Author + book.Year);
                        }
                    }
                    else if (choice == "Q")
                    {
                        Console.WriteLine("Bye!");
                        break;
                    }
                    else { Console.WriteLine("Try again"); }

                }
            }
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1.Dodaj książkę");
                Console.WriteLine("2.Wyświetl wszystkie książki");
                Console.WriteLine("3.Wyszukaj książki");
                Console.WriteLine("Q. Koniec");
                Console.WriteLine();

                string choice = Console.ReadLine();
                if (choice == "1")
                {

                    Console.WriteLine("You chose to add a book");
                    AddABook();

                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose to show all books");
                    ShowBooks();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose to show a specific book");
                    SearchABook();
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("Good Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("You chose a non-existing option, try again");
                }
            }
        }
    }
}
