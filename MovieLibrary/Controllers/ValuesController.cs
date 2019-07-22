using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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
        public IHttpActionResult Post([FromBody]MovieLibrary.Models.Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]Models.Movie movie)
        {
            if(id != movie.MovieId)
            {
                return BadRequest();
            }
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
