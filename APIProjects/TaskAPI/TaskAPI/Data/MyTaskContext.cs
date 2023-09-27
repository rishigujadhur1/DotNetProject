using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Entities;

namespace TaskAPI.Data
{
    public class MyTaskContext : DbContext
    {
        public MyTaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MyTask> MyTasks { get; set; }

    }
}