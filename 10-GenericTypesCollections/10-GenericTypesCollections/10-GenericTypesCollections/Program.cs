using _10_GenericTypesCollections.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new(4, "Ağ Gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new(5, "Qırıq Budaq", "Elçin", 1998, 350);

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();


            Console.WriteLine(" ");

            Console.WriteLine("2. Generic Library<T> test edin:");

            Console.WriteLine(" ");

            Library<Book> library = new Library<Book>("Milli Kitabxana");

            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);

            Console.WriteLine(" ");

            Console.WriteLine(library.Count());

            Console.WriteLine(" ");

            Console.WriteLine(library.FindByIndex(0));

            Console.WriteLine(" ");

            Console.WriteLine(library.FindByIndex(2));

            Console.WriteLine(" ");

            List<Book> allbook = library.GetAll();
            foreach (Book items in allbook)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine(" ");

            Console.WriteLine("3. List<T> - Üzvlər yaradın:");

            Console.WriteLine(" ");

            List<Member> members = new List<Member>()
            {
            new Member(1, "Ali Memmedov", "ali@mail.com"),
            new Member(2, "Leyla Hesenova", "Leyla@mail.com"),
            new Member(3, "Vuqar Eliyev", "vuqar@mail.com")
            };

            members[0].BorrowBook(book1);
            members[1].BorrowBook(book2);

            Console.WriteLine(" ");

            members[0].DisplayBorrowedBooks();
            members[1].DisplayBorrowedBooks();

            Console.WriteLine(" ");

            members[0].ReturnBook(1);

            Console.WriteLine(" ");

            members[1].DisplayBorrowedBooks();

            Console.WriteLine(" ");

            members[2].BorrowBook(book3);
            members[2].BorrowBook(book4);
            members[2].BorrowBook(book5);

            Console.WriteLine(" ");

            members[2].BorrowBook(book5);

            Console.WriteLine(" ");

            Console.WriteLine("4. Dictionary<TKey, TValue> - Müellife göre axtarış:");

            Console.WriteLine(" ");

            BookManager bookManager = new BookManager();

            bookManager.AddBook(book1);
            bookManager.AddBook(book2);
            bookManager.AddBook(book3);
            bookManager.AddBook(book4);
            bookManager.AddBook(book5);

            List<Book> books = bookManager.GetBooksByAuthor("George Orwell");

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine(" ");

            List<Book> books1 = bookManager.GetBooksByAuthor("Cingiz Aytmatov");
            foreach (var book in books1)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine(" ");

            List<Book> books2 = bookManager.GetBooksByAuthor("Jack London");
            foreach (var book in books2)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine(" ");

            List<Book> books3 = bookManager.GetBooksByAuthor("Dostoyevski");
            foreach (var book in books3)
            {
                Console.WriteLine( book.Title );
            }

            Console.WriteLine(" ");

            Console.WriteLine("5. Queue<T> - Gözleme növbesi:");

            Console.WriteLine(" ");

            bookManager.AddToWaitingQueue("Nigar");
            bookManager.AddToWaitingQueue("Resad");
            bookManager.AddToWaitingQueue("Sebine");

            Console.WriteLine(" ");

            Console.WriteLine($"Novbede qalan sayi:{bookManager.WaitingQueue.Count}");

            Console.WriteLine(" ");

            Console.WriteLine($"Xidmet edilir: {bookManager.ServeNextInQueue()}");

            Console.WriteLine(" ");

            Console.WriteLine($"Novbede qalan sayi:{bookManager.WaitingQueue.Count}");

            Console.WriteLine(" ");

            Console.WriteLine($"Xidmet edilir: {bookManager.ServeNextInQueue()}");

            Console.WriteLine(" ");

            Console.WriteLine($"Novbede qalan sayi:{bookManager.WaitingQueue.Count}");

            Console.WriteLine(" ");

            Console.WriteLine($"Xidmet edilir: {bookManager.ServeNextInQueue()}");

            Console.WriteLine(" ");

            Console.WriteLine($"Novbede qalan sayi:{bookManager.WaitingQueue.Count}");

            Console.WriteLine(" ");

            Console.WriteLine("6. Stack<T> - Son qaytarılan kitablar:");

            Console.WriteLine(" ");

            bookManager.ReturnBook(book1);
            bookManager.ReturnBook(book2);
            bookManager.ReturnBook(book3);

            Console.WriteLine(" ");

            Console.WriteLine($"Kitablarin sayi:{bookManager.RecentlyReturned.Count}");

            Console.WriteLine(" ");

            Console.WriteLine(bookManager.GetLastReturnedBook());

            bookManager.RecentlyReturned.Pop ();

            Console.WriteLine(" ");

            Console.WriteLine($"Kitablarin sayi:{bookManager.RecentlyReturned.Count}");

            Console.WriteLine(" ");

            Console.WriteLine(bookManager.GetLastReturnedBook());

            Console.WriteLine(" ");

            Console.WriteLine("7. Axtarış testi:");
            Console.WriteLine(" ");

            Console.WriteLine(bookManager.SearchByTitle("1984"));

            Console.WriteLine(" ");

                                                                              
            if (bookManager.SearchByTitle("Harry Potter")==null)
            {
                Console.WriteLine("Bele kitab yoxdur");
            }

            Console.WriteLine(" ");

            Console.WriteLine("8. Statistika (manual hesablama):");

            Console.WriteLine(" ");

            Console.WriteLine($"Umumi kitab sayi:{books.Count}");

            Console.WriteLine(" ");

            Console.WriteLine($"Umumi uzv sayi:{members.Count}");

            Console.WriteLine(" ");

            Console.WriteLine($"Novbede nece nefer var:{bookManager.WaitingQueue.Count}");

            Console.WriteLine(" ");

            Console.WriteLine($"Stack-de kitab sayi:{bookManager.RecentlyReturned.Count}");

            Console.WriteLine(" ");

            int  min = allbook[0].Year ;
            int  max = allbook[0].Year ;

            foreach (Book book in allbook)
            {
                if (book.Year < min)
                {
                    min = book.Year ;
                }
                if (book.Year > max)
                {
                    max = book.Year ;
                }
            }
            Console.WriteLine($"En kohne kitabin ili:{min}");
            Console.WriteLine($"En yeni kitabin ili:{max}");
        }

    }
}
