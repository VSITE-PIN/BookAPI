using WebApplication1.Data;

namespace BookAPI.Data
{
    public class Publisher
    {
        public List<Book> Books { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
