using System;
using System.Reflection.Metadata;
using ConsoleProject.Core.Models.Base;
using ConsoleProject.Core.Models.Enum;

namespace ConsoleProject.Core.Models
{
	public class Book :BaseModel
	{
		private static int _id;
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public BookCategory Category { get; set; }
        public BookWriter Writer { get; set; }
        public bool BookInStock { get; set; }

        public Book(string name,double price,double discountPrice, BookCategory category, BookWriter bookWriter)
        {
            _id++;
            Id = Id;

            Name = name;
            Price = price;
            DiscountPrice = discountPrice;
            Category = category;
            Writer = bookWriter;
            CreatedDate = DateTime.UtcNow.AddHours(4);

        }

        public override string ToString()
        {
            if (DiscountPrice < Price)
            {
                return $"Size : {Price - DiscountPrice} manat endrim edilib, Name:{Name},Price:{DiscountPrice},Category:{Category},Yazar:{Writer},InStock{BookInStock},DateTime:{CreatedDate},UpDate:{UpdateDate}";
            }
            return $"Name:{Name},Price:{Price},Category:{Category},Yazar:{Writer},InStock{BookInStock},DateTime:{CreatedDate},Update{UpdateDate}";
        }

    }
}

