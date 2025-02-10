using System;
using System.Net.Http.Headers;
using AleynaDailyEntity;
using Microsoft.EntityFrameworkCore;

namespace AleynaDailyData.Concrate;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
}

