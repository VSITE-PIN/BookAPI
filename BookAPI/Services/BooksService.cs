using BookAPI.Data;
using BookAPI.ViewModel;
using static BookAPI.Controllers.BooksController;

namespace BookAPI.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM bookVM)
        {
            var newBook = new Book()
            {
                Title = bookVM.Title,
                Description = bookVM.Description,
                IsRead = bookVM.IsRead,
                DateRead = bookVM.IsRead ? bookVM.DateRead : null,
                Rate = bookVM.IsRead ? bookVM.Rate : null,
                Genre = bookVM.Genre,
                Author = bookVM.Author,
                CoverPictureURL = bookVM.CoverPictureURL,
                DateAdded = DateTime.Now,
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();
        }
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }
        public Book UpdateBookById(int id, BookVM bookVM)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                book.Title = bookVM.Title;
                bookVM.Description = bookVM.Description;
                book.IsRead = bookVM.IsRead;
                book.DateRead = bookVM.IsRead ? bookVM.DateRead : null;
                book.Rate = bookVM.IsRead ? bookVM.Rate : null;
                book.Genre = bookVM.Genre;
                book.Author = bookVM.Author;
                book.CoverPictureURL = bookVM.CoverPictureURL;
                _context.SaveChanges();
            }
            return book;
        }
        public void DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

    }
}
