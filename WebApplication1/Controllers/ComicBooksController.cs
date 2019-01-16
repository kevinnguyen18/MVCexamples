using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicbookRepository = null;

        public ComicBooksController()
        {
            _comicbookRepository = new ComicBookRepository();
        }


        public ActionResult Index()
        {
            var comicBooks = _comicbookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicbookRepository.GetComicBook(id.Value);
           
            return View(comicBook);
           


        }
    }
}