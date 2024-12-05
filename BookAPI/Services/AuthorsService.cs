using BookAPI.Data;

namespace BookAPI.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(AuthorVM author)
        {
            var newAuthor = new Author()
            {
                FullName = author.FullName,
            };
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
        }
    }
}
