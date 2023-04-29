using System;
using System.Xml.Linq;
using ConsoleProject.Core.Models.Base;

namespace ConsoleProject.Core.Models
{
	public class BookWriter: BaseModel
	{
        private static int _id;
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Book> books;

        public BookWriter(string name, string surname, int age)
        {
            _id++;
            Id = _id;

            Name = name;
            Surname = surname;
            Age = age;
            books = new List<Book>();
            CreatedDate = DateTime.UtcNow.AddHours(4);
        }

        public override string ToString()
        {
            return $"Name{Name},Surname{Surname},Age{Age},CreateDate{CreatedDate},UpDate{UpdateDate}";
        }
    }
}

