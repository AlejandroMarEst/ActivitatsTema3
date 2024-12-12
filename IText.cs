using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatsTema3
{
    public interface IText
    {
        void OpenBook()
        {
            const string bookContent = "\r\n\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus a suscipit nulla. Ut fringilla malesuada pretium. Aenean hendrerit justo nec consequat mollis. Nullam tempor odio pretium enim aliquam ultricies. Morbi tempor hendrerit ligula, vitae convallis nibh ultricies eget. Mauris id varius risus, at vestibulum felis. Sed tristique fermentum bibendum. Sed id nibh nec mi finibus laoreet. Nulla et purus et mauris maximus condimentum. Integer dapibus neque metus, eu posuere magna dictum eu. Nam pretium nisl nisl, eu lacinia augue iaculis ut. "
            Console.WriteLine(bookContent);
        }
        void CloseBook()
        {
            const string bookTitle = "Fortnite BattlePass";
            const string bookAuthor = "By Hiper";
            Console.WriteLine(bookTitle);
            Console.WriteLine(bookAuthor);
        }
        void BuyBook(Magazine magazineName)
        {
            const string bookCosts = "The book costs {0}";
            int bookPrice = magazineName.Price;
            Console.WriteLine(bookCosts, bookPrice);
        }
    }
}
