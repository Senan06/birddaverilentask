using birddaverilentask.Models;
using System;
using static System.Console;
using static Utils.Enums;

namespace birddaverilentask
{
    class Program
    {
        static void Main(string[] args)
        {
            byte role;
            bool test;
            do
            {
                Write("role(1admin 2.member):");
                string rolestr = ReadLine();
                test = byte.TryParse(rolestr, out role);

            } while (test == false || !Enum.IsDefined(typeof(Role), role));
            Write("Name:");
            string name = ReadLine();
            Write("Email");
            string email = ReadLine();
            User other = new User(name, email, role);
            int booklimit;
            do
            {
                string booklimitstr = ReadLine();
                bool testt = Int32.TryParse(booklimitstr, out booklimit);
            }while(test);

            Library library = new Library(booklimit);
            int button;
            do
            {
                button = Convert.ToInt32(ReadLine());
                WriteLine("Menu");
                WriteLine("1. Add book");
                WriteLine("2. Get book by id");
                WriteLine("3. Get all books");
                WriteLine("4. Delete book by id");
                WriteLine("5. Edit book name");
                WriteLine("6. Filter by page count");
                WriteLine("0. Quit");
                switch(button)
                {
                    case 1:
                        
                        string Name = ReadLine();
                        string authorName = ReadLine();
                        int pageCount;                        
                        bool tester;
                        do
                        {
                            string pagecount = ReadLine();
                            tester = Int32.TryParse(pagecount, out pageCount);
                        } while (tester);
                        Book book = new Book(Name, authorName, pageCount);
                        library.AddBook(book);
                        break;
                    case 2:
                        int id;
                        
                            Console.Write("id sadece reqem olmalidir!");
                            string idstr = ReadLine();
                            bool testt = Int32.TryParse(idstr, out id);
                            Book input = library.GetBookById(id);
                            Console.WriteLine(input);
                        break;
                    case 3:
                        Console.WriteLine( library.GetAllBooks() );
                        //geri qaytarir, vaxt mehdudiyyetine gore bir bir  cixartmadim, mence werte uygundur :)
                        break;
                    case 4:
                        library.DeleteBookById(Convert.ToInt32(ReadLine()));
                        //trypase =>>;
                        break;
                    case 5:
                        library.FilterByPageCount(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
                        break;
                         }
            } while (button != 0);



        }
    }
    
}
