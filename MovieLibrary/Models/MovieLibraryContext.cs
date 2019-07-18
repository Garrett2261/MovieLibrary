using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNet;
using System.Data.Entity;

namespace MovieLibrary.Models
{
    public class MovieLibraryContext: DbContext
    {
        public MovieLibraryContext()
            
        {
        }

        
        public DbSet<Movie> Movies { get; set; }
    }
}