using WebAPIBOOK.Model;

namespace WebAPIBOOK.Repository
{
    public interface IBookRepository
    {
         Task <IEnumerable<Book>> GetBooks();   // Task-Based Asynchronous Programming in C#
        Task <Book> GetBookById(int id);
        Task <int> AddBook(Book book);
        Task <int> UpdateBook(Book book);
        Task <int> DeleteBook(int id);
    }
}   
