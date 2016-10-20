using System;
using System.Collections.Generic;

namespace Refactor.Models
{
    public class Library : ILibrary
    {
        public List<Section> sections { get; set; }

        public Library(List<Section> sections)
        {
            this.sections = sections;
        }

        public void AddSection(Section section)
        {
            throw new NotImplementedException();
        }

        public void DeleteSection(string sectionName)
        {
            throw new NotImplementedException();
        }

        public void EditSection(string sectionName, Section newSection)
        {
            throw new NotImplementedException();
        }

        public void AddBook(Section section, Book book)
        {
            throw new NotImplementedException();
        }

        public Book Search(string Name, string author)
        {
            foreach (var section in sections)
            {
                section.Search(Name, author);
            }
            throw new NotImplementedException();
        }

        public List<Book> Selection(params object[] selectionParameters)
        {
            throw new NotImplementedException();
        }
    }
}
