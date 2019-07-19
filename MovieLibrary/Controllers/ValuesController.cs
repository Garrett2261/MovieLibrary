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
        public string Get(int id)
        {
            var movie = db.Movies.Where(d => d.MovieId == id).Select(d => d.Title).FirstOrDefault().ToString();
            return movie;
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "Roll out the barrell";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
