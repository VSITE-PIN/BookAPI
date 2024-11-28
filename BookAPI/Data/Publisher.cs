using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

    }
}
