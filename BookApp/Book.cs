using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace BookApp
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set; }

        public Book() { }
        public Book(string name, string author, string releasedate)
        {
            Name = name;
            Author = author;
            ReleaseDate = releasedate;
        }
        public string ToXML()
        {
            using (StringWriter sw = new StringWriter())
            {
                new XmlSerializer(typeof(Book)).Serialize(sw, this);
                return sw.ToString();
            }
        }

        public static Book FromXML(string xmlText)
        {
            using (StringReader stringReader = new StringReader(xmlText))
                return new XmlSerializer(typeof(Book)).Deserialize(stringReader) as Book; 
        }

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static Book FromJSON(string jsondata)
        {
            return JsonConvert.DeserializeObject<Book>(jsondata);
        }

        public void Show()
        {
            Console.WriteLine("Book Name - {0}, Author - {1}, Release Date - {2}",Name,Author,ReleaseDate);
        }

    }
}
