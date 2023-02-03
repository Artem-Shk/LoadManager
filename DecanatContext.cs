using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoadManager;

public partial class DecanatContext : DbContext
{
    public DecanatContext()
    {
    }

    public DecanatContext(DbContextOptions<DecanatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Teacher> Преподаватели { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=sql;Database=деканат;Trusted_Connection=True;Persist Security Info=False;User ID=SFRUDN\\shakrislanov.a;Integrated Security=True;TrustServerCertificate=True;");

  

        
    
}
