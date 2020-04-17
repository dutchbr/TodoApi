using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoContext:DbContext
    {

        protected TodoContext(DbContextOptions options) : base(options) { }

        public TodoContext(DbContextOptions<TodoContext> options) : this((DbContextOptions)options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }


    }
}
