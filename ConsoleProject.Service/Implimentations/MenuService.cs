using System;
using ConsoleProject.Core.Models;
using ConsoleProject.Core.Models.Enum;
using ConsoleProject.Service.Interfaces;

namespace ConsoleProject.Service.Implimentations
{
    public class MenuService
    {
        public bool IsAdmin = false;

        private User[] users = { new User { Name = "Togrul", Password = "Togrul200" }, new User { Name = "Emrah", Password = "Emrah123" } };
        private WritterService writterService = new WritterService();
        private BookService bookService = new BookService();

        public async Task<bool> Login()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add username");
            string username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add pasword");
            string password = Console.ReadLine();

            if (users.Any(x => x.Name == username && x.Password == password))
            {
                IsAdmin = true;
            }
            else
            {
                Console.WriteLine("Username or pasword incorrect");
                IsAdmin = false;
            }
            return IsAdmin;

        }

        public async Task ShowMenuAdmin()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            string sentence = "Buyrun kecin baxin ne alsan 1 manat";

            foreach (var item in sentence)
            {
                Thread.Sleep(100);
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("0.Close App");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1.Create Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2.Show Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3.Show Author by id");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4.Show Author's books");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("5.Update Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("6.Delete Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("7.Create Book");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("8.Update Book");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("9.Get books by Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("10.Deleted book");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("11.Show All books");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("12.Buy Book");

            string Request = Console.ReadLine();


            while (Request != "0")
            {
                switch (Request)
                {
                    case "1":
                        Console.Clear();
                        await CreateWritterAsync();
                        break;

                    case "2":
                        Console.Clear();
                        await ShowAuthor();
                        break;

                    case "3":
                        Console.Clear();
                        await ShowAuthorbyId();
                        break;

                    case "4":
                        Console.Clear();
                        await ShowAuthorbooks();
                        break;

                    case "5":
                        Console.Clear();
                        await UpdateAuthor();
                        break;

                    case "6":
                        Console.Clear();
                        await DeleteAuthor();
                        break;

                    case "7":
                        Console.Clear();
                        await CreatedBooks();
                        break;

                    case "8":
                        Console.Clear();
                        await BookUpDate();
                        break;

                    case "9":
                        Console.Clear();
                        await GetBookbyAuthor();
                        break;

                    case "10":

                        Console.Clear();
                        await DeletedBook();
                        break;

                    case "11":
                        Console.Clear();
                        await ShowAllBooks();
                        break;

                    case "12":
                        Console.Clear();
                        await BuyBook();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Chouse valid option");
                        break;

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("0.Close App");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1.Create Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2.Show Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3.Show Author by id");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("4.Show Author's books");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("5.Update Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("6.Delete Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("7.Create Book");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("8.Update Book");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("9.Get books by Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("10.Deleted book");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("11.Show All books");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("12.Buy Book");

                Request = Console.ReadLine();

            }

        }

        public async Task ShowMenuUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string sentence = "Buyrun kecin baxin ne alsan 1 manat";

            foreach (var item in sentence)
            {
                Thread.Sleep(100);
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("0.Close App");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1.Show Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2.Show Author by id");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3.Show Author's books");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4.Get books by Author");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("5.Show All books");

            string request = Console.ReadLine();

            while (request != "0")
            {
                switch (request)
                {
                    case "1":
                        await ShowAuthor();
                        break;

                    case "2":
                        await ShowAuthorbyId();
                        break;

                    case "3":
                        await ShowAuthorbooks();
                        break;

                    case "4":
                        await GetBookbyAuthor();
                        break;

                    case "5":
                        await ShowAllBooks();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Chouse valid option");
                        break;

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("0.Close App");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1.Show Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2.Show Author by id");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3.Show Author's books");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("4.Get books by Author");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("5.Show All books");

                request = Console.ReadLine();
            }
        }

        private async Task CreateWritterAsync()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Add Name");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Surname");
            string surname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Age");
            int.TryParse(Console.ReadLine(), out int age);

            string message = await writterService.CreateAsync(name, surname, age);

            Console.WriteLine(message);
        }

        private async Task ShowAuthor()
        {
            await writterService.GetAllAsync();
        }

        private async Task ShowAuthorbyId()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add Author Id");
            int.TryParse(Console.ReadLine(), out int id);

            BookWriter bookWriter = await writterService.GetAsync(id);
            if (bookWriter != null)
            {
                Console.WriteLine(bookWriter);
            }

        }

        private async Task ShowAuthorbooks()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Add Author Id");
            int.TryParse(Console.ReadLine(), out int id);

            List<Book> books = await writterService.GetAllBooksAsync(id);

            if (books != null)
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                    
                }
            }
        }

        private async Task UpdateAuthor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author id");
            int.TryParse(Console.ReadLine(), out int id);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author Name");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author Surname");
            string surname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author Age");
            int.TryParse(Console.ReadLine(), out int age);
            Console.ForegroundColor = ConsoleColor.Blue;

            string message = await writterService.UpdateAsync(id, name, surname, age);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);

        }

        private async Task DeleteAuthor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author id");
            int.TryParse(Console.ReadLine(), out int id);

            string message = await writterService.DeleteAsync(id);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        private async Task CreatedBooks()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author Id");
            int.TryParse(Console.ReadLine(), out int id);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Book Name");
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Price");
            int.TryParse(Console.ReadLine(), out int price);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Discount Price");
            int.TryParse(Console.ReadLine(), out int discount);

            bool.TryParse(Console.ReadLine(), out bool bookInStock);
            Console.ForegroundColor = ConsoleColor.Blue;

            BookCategory category;

            Console.WriteLine("Choose Category");

            foreach (var item in Enum.GetValues(typeof(BookCategory)))
            {
                Console.WriteLine((int)item + " " + item);
            }

            int.TryParse(Console.ReadLine(), out int categoryindex);

            var result = Enum.GetName(typeof(BookCategory), categoryindex);

            while (result == null)
            {
                Console.WriteLine("Choose Valid Category");
                int.TryParse(Console.ReadLine(), out categoryindex);

                result = Enum.GetName(typeof(BookCategory), categoryindex);

            }
            category = (BookCategory)categoryindex;

            string message = await bookService.CreateAsync(id, name, price, discount, category, bookInStock);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);

        }

        private async Task BookUpDate()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Author id");
            int.TryParse(Console.ReadLine(), out int Authorid);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Book id");
            int.TryParse(Console.ReadLine(), out int Bookid);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Price");
            int.TryParse(Console.ReadLine(), out int Price);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add DisCountPrice");
            int.TryParse(Console.ReadLine(), out int DiscountPrice);


            string messsage = await bookService.UpdateAsync(Authorid, Bookid, name, Price, DiscountPrice);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(messsage);

        }

        private async Task GetBookbyAuthor()
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Add Author id");
            int.TryParse(Console.ReadLine(), out int authorid);
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Book id");
            int.TryParse(Console.ReadLine(), out int bookid);

            Book book = await bookService.GetAsync(authorid, bookid);
            if (book != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(book);
            }

        }

        private async Task DeletedBook()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add author id");
            int.TryParse(Console.ReadLine(), out int authorid);
      
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Book id");
            int.TryParse(Console.ReadLine(), out int bookid);

            string message = await bookService.DeleteAsync(bookid, authorid);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);

        }

        private async Task ShowAllBooks()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            await bookService.GetAll();
        }

        private async Task BuyBook()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Add Author id");
            int.TryParse(Console.ReadLine(), out int authorid);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Add Book id");
            int.TryParse(Console.ReadLine(), out int bookid);

            bool.TryParse(Console.ReadLine(), out bool bookInStock);

            string message = await bookService.BuyBook(bookid, authorid, bookInStock);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}

