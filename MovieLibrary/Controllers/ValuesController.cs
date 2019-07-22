using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieLibrary.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<MovieLibrary.Models.Movie> movieList { get; } = new List<Models.Movie>();
        private MovieLibrary.Models.MovieLibraryContext db = new Models.MovieLibraryContext();
        // GET api/values
        public IEnumerable<Models.Movie> Get()
        {
            return db.Movies.ToList();
        }

        // GET api/values/5
        public MovieLibrary.Models.Movie Get(int id)
        {
            var searchedMovie = db.Movies.Find(id);
            return searchedMovie;
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            //var movies = 
            return value;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]Models.Movie Movie)
        {
            var movieToUpdate = db.Movies.Where(d => d.MovieId == id).FirstOrDefault();
            if(movieToUpdate != null)
            {
                movieToUpdate.Title = Movie.Title;
                movieToUpdate.Genre = Movie.Genre;
                movieToUpdate.Director = Movie.Director;
                
            }
            return movieToUpdate.Director;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
