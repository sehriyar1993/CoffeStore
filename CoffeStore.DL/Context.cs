using CoffeStore.EL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeStore.DL
{
        public class Context : IdentityDbContext<AppUser, AppRole, int>
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=.\\MSSQLSERVER19; database=CoffeStoreDB; integrated security = true;  Trusted_Connection=True;");
            }
            public DbSet<About> Abouts { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<NewsLetter> NewsLetters { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<HomeClass> HomeClasses { get; set; }
        }
    
}