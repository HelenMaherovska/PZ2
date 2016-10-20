using System.Collections.Generic;

namespace Refactor.Models
{
    public interface ILibrary
    {
        void AddSection(Section section);
        void DeleteSection(string sectionName);
        void EditSection(string sectionName, Section newSection);

        void AddBook(Section section, Book book);
        Book Search(string Name, string author);
        List<Book> Selection(params object[] selectionParameters);
    }
}
