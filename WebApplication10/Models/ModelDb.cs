using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class ModelDb : DbContext
    {
        public ModelDb(DbContextOptions<ModelDb> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }

    }
}
