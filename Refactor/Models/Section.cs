using System;
using System.Collections.Generic;

namespace Refactor.Models
{
    public abstract class Section : ISection
    {
        private List<Book> books;
        private string NameOfSection;
        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }

        public string Name
        {
            get
            {
                return this.NameOfSection;
            }
            set
            {
                this.NameOfSection = value;
            }
        }

        public Section(string name, List<Book> books)
        {
            Name = name;
            Books = books;
        }

        public int Count()
        {
            return Books.Count;
        }

        public void AddBook(Section section, Book book)
        {
            throw new NotImplementedException();
        }

        public Book Search(string Name, string author)
        {
            throw new NotImplementedException();
        }

        public List<Book> Selection(params object[] selectionParameters)
        {
            throw new NotImplementedException();
        }
    }
}
