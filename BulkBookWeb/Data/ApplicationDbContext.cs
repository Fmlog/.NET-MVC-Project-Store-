﻿using Microsoft.EntityFrameworkCore;
using BulkBookWeb.Models;

namespace BulkBookWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category>
    }
}
