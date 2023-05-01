using System;
using ConsoleProject.Core.Models;
using ConsoleProject.Core.Models.Enum;

namespace ConsoleProject.Service.Interfaces
{
	public interface IBookService
	{
        public Task<string> CreateAsync(int id, string name, double price, double discountPrice, BookCategory category,bool BookInStock);
        public Task<string> DeleteAsync(int WriterId, int BookId);
        public Task<string> UpdateAsync(int WriterId, int BookId, string name, double price, double discountPrice);
        public Task<Book> GetAsync(int WriterId, int BookId);
        public Task<string> BuyBook(int WriterId, int BookId,bool InStock);
        public Task GetAll();
    }
}

