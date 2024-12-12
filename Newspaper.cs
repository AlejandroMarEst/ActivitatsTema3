using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public class Newspaper : Literatura, IText
    {
        public Newspaper(string name, string editorial, string publishingDate, int volume, int pageNumber, string author, string category) : base(name, editorial, publishingDate, volume, pageNumber, author, category)
        {
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
