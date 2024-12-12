using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class Magazine : Literatura, IText
    {
        public int Price { get; set; }
        public Magazine(int price, string name, string editorial, string publishingDate, int volume, int pageNumber, string author, string category) : base(name, editorial, publishingDate, volume, pageNumber, author, category)
        {
            Price = price;
            Name = name;
            Editorial = editorial;
            PublishingDate = publishingDate;
            Volume = volume;
            PageNumber = pageNumber;
            Author = author;
            Category = category;
        }
    }
}
