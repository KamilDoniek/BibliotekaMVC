namespace BibliotekaMVC.Models;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int AuthorId { get; set; }

    public Author Author { get; set; }
    public ICollection<BookLoan> BookLoans { get; set; }

}