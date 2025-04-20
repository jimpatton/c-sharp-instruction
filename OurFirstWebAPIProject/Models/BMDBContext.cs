using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OurFirstWebAPIProject.Models;

public partial class BMDBContext : DbContext
{
   

    public BMDBContext(DbContextOptions<BMDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Credit> Credits { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieCopy> MovieCopies { get; set; }


}
