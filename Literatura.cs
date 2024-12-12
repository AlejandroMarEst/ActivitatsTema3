using System;

namespace ActivitatsTema3
{
    public class Literatura
    {
        public string Name { get; set; }
        public string Editorial { get; set; }
        public string PublishingDate { get; set; }
        public int Volume { get; set; }
        public int PageNumber { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Literatura(string name, string editorial, string publishingDate, int volume, int pageNumber, string author, string category){
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
