using System;
using ConsoleProject.Core.Models;

namespace ConsoleProject.Service.Interfaces
{
	public interface IWritterService
	{
        public Task<string> CreateAsync(string name, string surname, int age);
        public Task<string> DeleteAsync(int id);
        public Task<string> UpdateAsync(int id,string name,string surname,int age);
        public Task<BookWriter> GetAsync(int id);
        public Task GetAllAsync();
        public Task<List<Book>> GetAllBooksAsync(int id);
       
    }
}

