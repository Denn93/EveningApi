using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData;
using DenCreation.Dev.EveningApi.Models;

namespace DenCreation.Dev.EveningApi.Controllers
{
    public class MoviesController : ODataController
    {
        private List<Movie> FillMovies()
        {
            List<Movie> result = new List<Movie>();
            result.Add(new Movie {Id = 1, Title = "Simpsons", RunningTime = "40min"});
            result.Add(new Movie {Id = 2, Title = "Batman", RunningTime = "50min"});
            result.Add(new Movie {Id = 3, Title = "Family Guy", RunningTime = "20min"});
            result.Add(new Movie {Id = 4, Title = "2000BC", RunningTime = "140min"});

            return result;
        }

        [EnableQuery]
        public IQueryable<Movie> Get()
        {
            return FillMovies().AsQueryable();
        }

        [EnableQuery]
        public SingleResult<Movie> Get([FromODataUri] int key)
        {
            IQueryable<Movie> result = FillMovies().Where(m => m.Id == key).AsQueryable();
            return SingleResult.Create(result);
        }  

    }
}
