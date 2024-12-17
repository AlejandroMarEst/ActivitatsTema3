using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class Book : Literatura, IText, ILibrary
    {
        public Book(string name, string editorial, string publishingDate, int volume, int pageNumber, string author, string category) : base(name, editorial, publishingDate, volume, pageNumber, author, category)
        {
            Name = name;
            Editorial = editorial;
            PublishingDate = publishingDate;
            Volume = volume;
            PageNumber = pageNumber;
            Author = author;
            Category = category;
        }

        public Library Library
        {
            get => default;
            set
            {
            }
        }

        public void ReadCover(Literatura bookName)
        {
            string bookTitle = bookName.Name;
            string bookAuthor = "By {0}";
            Console.WriteLine(bookTitle);
            Console.WriteLine(bookAuthor, bookName.Author);
        }
        public void OpenBook()
        {
            const string bookContent = "\r\n\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus a suscipit nulla. Ut fringilla malesuada pretium. Aenean hendrerit justo nec consequat mollis. Nullam tempor odio pretium enim aliquam ultricies. Morbi tempor hendrerit ligula, vitae convallis nibh ultricies eget. Mauris id varius risus, at vestibulum felis. Sed tristique fermentum bibendum. Sed id nibh nec mi finibus laoreet. Nulla et purus et mauris maximus condimentum. Integer dapibus neque metus, eu posuere magna dictum eu. Nam pretium nisl nisl, eu lacinia augue iaculis ut. ";
            Console.WriteLine(bookContent);
        }

        public void LendBook()
        {
            Console.WriteLine("Return this book in a month");
        }
    }
}
