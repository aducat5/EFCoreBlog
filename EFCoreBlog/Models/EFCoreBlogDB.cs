using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreBlog.Models
{
    public class EFCoreBlogDB : DbContext
    {
        public EFCoreBlogDB()
        {
        }

        public EFCoreBlogDB(DbContextOptions<EFCoreBlogDB> options) : base(options) {}

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
