using BookAPI.Data;
using BookAPI.ViewModel;

namespace BookAPI.Services
{
    public class BookService
    {
        private AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            var newBook = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.GetDateRead() : null,
                Rate = book.IsRead ? book.Rate : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverPictureURL = book.CoverPictureURL,
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
                book.DateRead = bookVM.IsRead ? bookVM.GetDateRead() : null;
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
