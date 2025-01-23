using System;
using AleynaAPI.AleynaAPIEntity;
using Microsoft.EntityFrameworkCore;


namespace AleynaAPI.AleynaAPIData.Context;

public class AleynaAPIDbContext:DbContext
{
    public AleynaAPIDbContext(DbContextOptions<AleynaAPIDbContext> options):base(options)
    {

    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

}

