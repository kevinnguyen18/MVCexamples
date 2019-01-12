using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ComicBooksController : Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "This is from the comicbook controller"
            };


        }
    }
}