using LibraryManage.Models;
using System.Data.SqlClient;


public class LibraryRepository
{
    private readonly string _connectionString;

    public LibraryRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    
    public IEnumerable<Book> GetBooks()
    {
        var books = new List<Book>();

        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand("SELECT * FROM Books", connection);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookId = (int)reader["BookId"],
                        Title = (string)reader["Title"],
                        Author = (string)reader["Author"],
                        ISBN = (string)reader["ISBN"],
                        Publisher = (string)reader["Publisher"],
                        Year = (int)reader["Year"]
                    });
                }
            }
        }

        return books;
    }

    
    public IEnumerable<Member> GetMembers()
    {
        var members = new List<Member>();

        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand("SELECT * FROM Members", connection);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    members.Add(new Member
                    {
                        MemberId = (int)reader["MemberId"],
                        Name = (string)reader["Name"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        MembershipDate = (DateTime)reader["MembershipDate"]
                    });
                }
            }
        }

        return members;
    }
    public IEnumerable<Loan> GetLoans()
    {
        var loans = new List<Loan>();

        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand("SELECT * FROM Loans", connection);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    loans.Add(new Loan
                    {
                        LoanId = (int)reader["LoanId"],
                        BookId = (int)reader["BookId"],
                        MemberId = (int)reader["MemberId"],
                        LoanDate = (DateTime)reader["LoanDate"],
                        ReturnDate = (DateTime)(reader["ReturnDate"] as DateTime?)
                    });
                }
            }
        }

        return loans;
    }


}

