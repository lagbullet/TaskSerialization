using System;
using System.IO;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"E:\Test\TestJson.txt");
            Book book = Book.FromJSON(text);
            book.Show();
            Console.WriteLine(book.ToJSON());
            Console.ReadLine();
            text = File.ReadAllText(@"E:\Test\TestXml.txt");
            Book book1 = Book.FromXML(text);
            book1.Show();
            Console.WriteLine(book1.ToXML());
            Console.ReadLine();
        }
    }
}
