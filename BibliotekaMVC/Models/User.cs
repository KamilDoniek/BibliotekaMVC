namespace BibliotekaMVC.Models;


public class User
{
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        
        public LibraryCard LibraryCard { get; set; }
        public ICollection<BookLoan> BookLoans { get; set; }
}

