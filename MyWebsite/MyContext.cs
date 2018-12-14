using Microsoft.EntityFrameworkCore;
using MyWebsite.Models;

namespace MyWebsite
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}