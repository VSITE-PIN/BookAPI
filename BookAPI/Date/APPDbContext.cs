using Microsoft.EntityFrameworkCore;
using System;

namespace BookAPI.Date
{
    public class APPDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
    base(options){ }
public DbSet<Book> Books{get; set;}
}
