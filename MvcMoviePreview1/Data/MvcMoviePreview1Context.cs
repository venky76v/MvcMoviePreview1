using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMoviePreview.Models;

namespace MvcMoviePreview1.Models
{
    public class MvcMoviePreview1Context : DbContext
    {
        public MvcMoviePreview1Context (DbContextOptions<MvcMoviePreview1Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMoviePreview.Models.Movie> Movie { get; set; }
    }
}
