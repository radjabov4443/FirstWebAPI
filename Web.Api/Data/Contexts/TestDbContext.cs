using Microsoft.EntityFrameworkCore;
using Web.Api.Models;

namespace Web.Api.Data.Contexts
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        public virtual DbSet<UserModel> Users { get; set; }
    }
}
