using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities;

namespace TP1.Database
{
    public class MyBdContext : DbContext 
    {
        public DbSet<Author> Authors { get; set; }
    }
}
