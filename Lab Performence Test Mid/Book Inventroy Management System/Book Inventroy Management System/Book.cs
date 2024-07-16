using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Book_Inventroy_Management_System
{
    public abstract class Book
    {
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public CustomDate PublicationDate { get; private set; }

        protected Book(string isbn, string title, string author, CustomDate publicationDate)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.PublicationDate = publicationDate;
        }

        public abstract void ShowInfo();

        public int CalculateAge()
        {
            return PublicationDate.CalculateAge();
        }
    }

    public class Fiction : Book
    {
        public string Genre { get; private set; }

        public Fiction(string isbn, string title, string author, CustomDate publicationDate, string genre)
            : base(isbn, title, author, publicationDate)
        {
            this.Genre = genre;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Fiction Book - ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publication Date: {PublicationDate}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Age: {CalculateAge()}years");
        }
    }

    public class NonFiction : Book
    {
        public string FieldOfStudy { get; private set; }

        public NonFiction(string isbn, string title, string author, CustomDate publicationDate, string fieldOfStudy)
            : base(isbn, title, author, publicationDate)
        {
            this.FieldOfStudy = fieldOfStudy;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Fiction Book - ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publication Date: {PublicationDate}");
            Console.WriteLine($"Field of Study: { FieldOfStudy}");
            Console.WriteLine($"Age: {CalculateAge()}years");
        }
    }

}
