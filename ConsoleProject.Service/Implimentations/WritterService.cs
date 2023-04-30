using System;
using System.Xml.Linq;
using ConsoleProject.Core.Models;
using ConsoleProject.Data.Repositories;
using ConsoleProject.Service.Interfaces;

namespace ConsoleProject.Service.Implimentations
{
    public  class WritterService : IWritterService
    {
        private readonly static BookWriterRepo _repository = new BookWriterRepo();

        public async Task<string> CreateAsync(string name, string surname, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Add valid Name";

            if (string.IsNullOrWhiteSpace(surname))
                return "Add valid Surname";

            if (age <= 0)
                return "Add valid Age";



            BookWriter bookWriter = new BookWriter(name, surname, age);
            await _repository.AddAsync(bookWriter);
            return "Ugurla Yarandi";


        }

        public async Task<string> DeleteAsync(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookWriter = await _repository.GetAsync(writer => writer.Id == id);

            if (bookWriter == null)
                return "Yazar tapilmadi";

            await _repository.RemoveAsync(bookWriter);

            Console.ForegroundColor = ConsoleColor.Green;
            return "Ugurla silindi";
        }

        public async Task GetAllAsync()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var item in await _repository.GetAllAsync())
            {
                Console.WriteLine(item);
            }

        }

        public async Task<BookWriter> GetAsync(int id)
        {
            BookWriter bookWriter = await _repository.GetAsync(writter => writter.Id == id);

            if (bookWriter == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Author not foun");
                return null;
            }
            return bookWriter;
        }

        public async Task<string> UpdateAsync(int id, string name, string surname, int age)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Add valid Name");
            }


            if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Add valid Surname");
            }

            if (age <= 0)
            {
                Console.WriteLine("Add valid Age");
            }

            BookWriter bookWriter = await _repository.GetAsync(X => X.Id == id);

            if (bookWriter == null)
                return "Author not found";

            bookWriter.Name = name;
            bookWriter.Surname = surname;
            bookWriter.Age = age;

            Console.ForegroundColor = ConsoleColor.Green;

            return "Update sucesfully";



        }

        public async Task<List<Book>> GetAllBooksAsync(int id)
        {
            BookWriter bookWriter = await _repository.GetAsync(writ => writ.Id == id);

            if (bookWriter == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Author not found");
                return null;
            }

            return bookWriter.books;
        }
    }
}

