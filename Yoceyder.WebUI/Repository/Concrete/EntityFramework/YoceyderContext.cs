using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class YoceyderContext:DbContext
    {
        public YoceyderContext(DbContextOptions<YoceyderContext> options)
    : base(options)
        {

        }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Donation> Donation { get; set; }
        public DbSet<Scholarship> Scholarships { get; set; }

    }
}
