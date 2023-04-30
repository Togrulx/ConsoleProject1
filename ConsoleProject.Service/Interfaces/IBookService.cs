using System;
using ConsoleProject.Core.Models;
using ConsoleProject.Core.Models.Enum;

namespace ConsoleProject.Service.Interfaces
{
	public interface IBookService
	{
        public Task<string> CreateAsync();
        public Task<string> DeleteAsync();
        public Task<string> UpdateAsync();
        public Task<Book> GetAsync();
        public Task<string> BuyBook();
        public Task GetAll();
    }
}

