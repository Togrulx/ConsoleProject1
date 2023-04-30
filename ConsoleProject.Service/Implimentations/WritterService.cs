using System;
using ConsoleProject.Core.Models;
using ConsoleProject.Data.Repositories;
using ConsoleProject.Service.Interfaces;

namespace ConsoleProject.Service.Implimentations
{
    internal class WritterService : IWritterService
    {
        private readonly static BookWriterRepo _repository = new BookWriterRepo();
        public async Task<string> CreateAsync(string name, string surname, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Add valid Name";

            if (string.IsNullOrWhiteSpace(surname))
                return "Add valid Surname";

            if (age<=0)
                return "Add valid Age";



            BookWriter bookWriter = new BookWriter(name,surname,age);
            return "";
        }

        public Task<string> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllBooksAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookWriter> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(int id, string name, string surname, int age)
        {
            throw new NotImplementedException();
        }
    }
}

