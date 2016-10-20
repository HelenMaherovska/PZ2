using System.Collections.Generic;

namespace Refactor.Models
{
    public interface ISection
    {
        void AddBook(Section section, Book book);
        Book Search(string Name, string author);
        List<Book> Selection(params object[] selectionParameters);
    }
}
