using Refactor.Models;
using System.Collections.Generic;

namespace Course_Project
{

    public class Specialized : Section
    {
        //some additional features
        public Specialized(string name, List<Book> books) : base(name, books) { }
    }
    public class Detective : Section
    {
        //some additional features 
        public Detective(string name, List<Book> books) : base(name, books) { }
    }
    public class TextBook : Section
    {
        //some additional features
        public TextBook(string name, List<Book> books) : base(name, books) { }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}