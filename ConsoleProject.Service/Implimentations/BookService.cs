using System;
using ConsoleProject.Core.Models;
using ConsoleProject.Core.Models.Enum;
using ConsoleProject.Data.Repositories;
using ConsoleProject.Service.Interfaces;

namespace ConsoleProject.Service.Implimentations
{
    public class BookService : IBookService
    {
        private readonly BookWriterRepo _repository = new BookWriterRepo();

        public async Task<string> CreateAsync(int id, string name, double price, double discountPrice, BookCategory category,bool BookInStock)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            BookWriter writer = await _repository.GetAsync(writerRepo => writerRepo.Id == id);

            if (await IsValidBooks(name, price, discountPrice) != null)
            {
                return await IsValidBooks(name, price, discountPrice);
            }

            Book book = new Book(name, price, discountPrice, category, writer);

            writer.books.Add(book);

            Console.ForegroundColor = ConsoleColor.Green;
            return "Ugurla Yarandi";

        }

        public async Task<string> DeleteAsync(int WriterId, int BookId)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookWriter = await _repository.GetAsync(writer => writer.Id == WriterId);

            if (bookWriter == null)
                return null;

            Book book = bookWriter.books.FirstOrDefault(Book => Book.Id == BookId);

            if (book == null)
                return "Book yoxdur";

            bookWriter.books.Remove(book);
            Console.ForegroundColor = ConsoleColor.Red;
            return "Silindi";

        }

        public async Task GetAll()
        {
            foreach (var item in await _repository.GetAllAsync())
            {
                foreach (var book in item.books)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public async Task<Book> GetAsync(int WriterId, int BookId)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            BookWriter bookWriter = await _repository.GetAsync(writer => writer.Id == WriterId);
            if (bookWriter == null)
            {
                Console.WriteLine("Yazar Yoxdur");
                return null;
            }

            Book book = bookWriter.books.FirstOrDefault(Book => Book.Id == BookId);

            if (book == null)
            {
                Console.WriteLine("Book yoxdur");
                return null;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            return book;

        }

        public async Task<string> UpdateAsync(int WriterId, int BookId, string name, double price, double discountPrice)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookWriter = await _repository.GetAsync(writer => writer.Id == WriterId);

            if (bookWriter == null)
                return "Yazar yoxdur";

            if (await IsValidBooks(name, price, discountPrice) != null)
            {
                return await IsValidBooks(name, price, discountPrice);
            }

            Book book = bookWriter.books.FirstOrDefault(book => book.Id == BookId);

            book.Name = name;
            book.Price = price;
            book.DiscountPrice = discountPrice;

            Console.ForegroundColor = ConsoleColor.Green;
            return "Updated olundu";




        }

        public async Task<string> BuyBook(int WriterId, int BookId,bool BookInStock)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookWriter = await _repository.GetAsync(writer => writer.Id == WriterId);

            if (bookWriter == null)
                return "Yazar yoxdur";

            Book book = bookWriter.books.FirstOrDefault(Book => Book.Id == BookId);

            if (book == null)
                return "Bu kitab stokda yoxdur";

            if (book.BookInStock)
                return "Kitab stockda yoxdur";

            Console.ForegroundColor = ConsoleColor.Blue;
            return "satildi";

        }

        private async Task<string> IsValidBooks(string name, double Price, double discountPrice)
        {
            if (string.IsNullOrEmpty(name))
                return "Add valid Name";
            if (Price < 0)
                return "Add valid Price";
            if (discountPrice > Price || discountPrice < 0)
                return "Add valid DisCount";

            return null;

        }
    }
}

