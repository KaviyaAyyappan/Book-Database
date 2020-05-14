using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDatabase
{
    class Program
    {
        struct book
        {
            public string title;
            public string author;
        }
        static void Main(string[] args)
        {
            int capacity = 1000;
            book[] books = new book[capacity];
            bool quit = true;
            int value = 0;
            
            do
            {
                Console.WriteLine("            ");
                Console.WriteLine("Books Database");
                Console.WriteLine();
                Console.WriteLine("1.Add" + "  2.Display" + "  3.Search" + "  4.Delete" + "  5.Exit");
                Console.WriteLine("Enter the option:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1://Add
                        if (value < capacity)
                        {
                            Console.WriteLine("Enter data the book details", value + 1);
                            Console.WriteLine("Enter the title of the book");
                            books[value].title = Console.ReadLine();
                            Console.WriteLine("Enter the author of the book");
                            books[value].author = Console.ReadLine();
                            value++;
                        }
                        else { Console.WriteLine("Database full"); }
                        break;
                    case 2://Display
                        if (value != 0)
                        {
                            for (int i = 0; i < value; i++)
                            {
                                Console.WriteLine("Title ,      Author " + (i + 1));
                                Console.WriteLine(books[i].title+"          " + books[i].author);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3://search
                        Console.WriteLine("Enter the title of the book");
                        string search = Console.ReadLine();
                        for (int i = 0; i < value; i++)
                        {
                            if (books[i].title == search)
                            {
                                Console.WriteLine("Book found int the database");
                                Console.WriteLine(books[i].title + "  " + books[i].author);
                                
                            }
                            else if(books[i].title != search)
                            {
                                Console.WriteLine("not found");
                            }
                            
                        }
                        break;
                    case 4://delete
                        if (value != 0)
                        {
                            Console.WriteLine("Enter the number of the book to delete",value);
                            int delete = Convert.ToInt32(Console.ReadLine()) - 1;
                            for (int i = delete; i < value - 1; i++)
                            {
                                books[i] = books[i + 1];
                                value--;
                            }
                        }
                        break;
                    case 5://quit
                        quit = false;
                        break;

                }

            }
            while (quit);
        }
    }
}
