using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstMVCProject.Models;

namespace MyFirstMVCProject.Data
{
    public class MyFirstMVCProjectContext : DbContext
    {
        public MyFirstMVCProjectContext (DbContextOptions<MyFirstMVCProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMVCProject.Models.StudentData> StudentData { get; set; }
    }
}
