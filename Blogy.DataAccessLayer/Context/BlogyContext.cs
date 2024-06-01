using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Context
{
    public class BlogyContext : IdentityDbContext<AppUser, AppRole, int>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HHOE249\\SQLEXPRESS;initial catalog=DB_NewBlogy;integrated Security=true;");
        }
        public DbSet<Category> Categories { get; set; }
            public DbSet<Article> Articles { get; set; }
            public DbSet<Comment> Comments { get; set; }
            public DbSet<Tag> Tags { get; set; }
            public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }




    }
}
