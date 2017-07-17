﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMoviePreview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMoviePreview1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMoviePreview1Context(serviceProvider.GetRequiredService<DbContextOptions<MvcMoviePreview1Context>>()))
            {
                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie
                    {
                       Title = "When Harry Met Sally",
                       ReleaseDate = DateTime.Parse("1989-1-11"),
                       Genre = "Romantic Comedy",
                       Price = 7.99M
                    },
                    
                    new Movie
                    {
                         Title = "Ghostbusters ",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M
                    },

                    new Movie
                    {
                         Title = "Ghostbusters 2",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Price = 9.99M
                    },

                    new Movie
                    {
                       Title = "Rio Bravo",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Price = 3.99M
                    });
                context.SaveChanges();
            }
        }
    }
}
