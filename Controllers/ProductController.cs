
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Workshop1.Models;

namespace Workshop1.Controllers
{
    public class ProductController :Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}