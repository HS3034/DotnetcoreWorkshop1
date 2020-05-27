using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Workshop1.Models;

namespace Workshop1.Controllers
{
    public class MovieController :Controller
    {
        public IActionResult index(int? id)
        {
            var repo = new MovieRespository();  
             var data = repo.GetMovies().Where(m=> m.Id==id);
             return View(data);   

            // var repo =new MovieRespository();
            // ViewData["MyData"] = repo.GetMovies();
            // return View(repo.GetMovies());

        }

    }
}