using blazorConfigure1.Data;
using blazorConfigure1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorConfigure1.Services
{
    public interface IPosts
    {
        List<post> GetDbPosts();
    }

    public class Posts : IPosts
    {
        DbContextOptions<ApplicationDbContext> options;
        public Posts(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }

        public List<post> GetDbPosts()
        {
            using (var context=new ApplicationDbContext(options))
            {
                return context.posts.ToList();
            }
        }
    }
}
