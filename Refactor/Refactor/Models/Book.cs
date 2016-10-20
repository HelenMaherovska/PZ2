namespace Refactor.Models
{
    public class Book
    {
        private string author;
        private string name;
        private string publication;
        private int year_of_publication;
        private int number_of_pages;

        private SubjectiveEstimation estimation;

        public Book(string author, string name, string publication, int year_of_publication, int number_of_pages, SubjectiveEstimation estimation)
        {
            this.author = author;
            this.name = name;
            this.publication = publication;
            this.year_of_publication = year_of_publication;
            this.number_of_pages = number_of_pages;
            this.estimation = estimation;
        }

        public string Author
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Publication
        {
            get; set;
        }

        public int Year_of_publication
        {
            get; set;
        }

        public int Number_of_pages
        {
            get; set;
        }
    }
}
