using blazorConfigure1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace blazorConfigure1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();

            //posts.Add(new post { title = "Публикация 1", text = "Публикация из второй базы данных" });
            //posts.Add(new post { title = "Публикация 2", text = "Публикация из второй базы данных" });
            //posts.Add(new post {title="Публикация 3", text="Добавлена новая публикация" });
            //SaveChanges();
        }

        public DbSet<post> posts { get; set; }
    }
}
