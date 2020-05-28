using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Workshop1.Models;
using System.Collections.Generic;
namespace Workshop1.Controllers
{
    public class MovieController :Controller
    {
        // public IActionResult Index(int? id,string lastClick)
        // {
        //     var repo = new MovieRespository();  
        //     var data = repo.GetMovies();
        //      if(id != null){
        //          data.Where(m => m.Id == id).ToList();
        //      }

        //      ViewData["LastClick"] = lastClick;
        //      return View(data);   
        //     // var repo =new MovieRespository();
        //     // ViewData["MyData"] = repo.GetMovies();
        //     // return View(repo.GetMovies());
        // }

        public IActionResult Index(string sort,string order){

                var repo = new MovieRespository();
                var data = repo.GetMovies();

                if(!string.IsNullOrEmpty(sort)){

                    switch (sort){
                        case "id":
                        if(order=="asc"){
                            data=data.OrderBy(m => m.Id).ToList();
                        }else{
                            data = data.OrderByDescending( m=>m.Id).ToList();
                        }
                        break;
                                  case "title":
                        if(order=="asc"){
                            data=data.OrderBy(m => m.Title).ToList();
                        }else{
                            data = data.OrderByDescending( m=>m.Title).ToList();
                        }
                        break;
                                  case "releaseDate":
                        if(order=="asc"){
                            data=data.OrderBy(m => m.ReleaseDate).ToList();
                        }else{
                            data = data.OrderByDescending( m=>m.ReleaseDate).ToList();
                        }
                        break;
                                  case "genre":
                        if(order=="asc"){
                            data=data.OrderBy(m => m.Genre).ToList();
                        }else{
                            data = data.OrderByDescending( m=>m.Genre).ToList();
                        }
                        break;
                                  case "price":
                        if(order=="asc"){
                            data=data.OrderBy(m => m.Price).ToList();
                        }else{
                            data = data.OrderByDescending( m=>m.Price).ToList();
                        }
                        break;

                    }
                }

            return View(data);

        }

        [HttpPost]
        public IActionResult DeleteMovie(int movieId){
            var repo= new MovieRespository();
            repo.DeteleMovie(movieId);
            return RedirectToAction("Index");
        }

    }
}