using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;


namespace NetCoreMVCLab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {    
            List<Book> books = Book.ListBook;
            ViewBag.Authors = book.Authors;
            ViewBag.Genres = book.Genres;
            return View(books);
        }
        public IActionResult Create()
        {
            Book model = new Book();
            ViewBag.Authors = book.Authors;
            ViewBag.Genres = book.Genres;
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Book model)
        {
            model.Id = Book.ListBook.Count + 1;
            Book.ListBook.Add(model);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            List<Book> books = Book.ListBook;
            ViewBag.Authors = book.Authors;
            ViewBag.Genres = book.Genres; 
            return View(books.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public IActionResult Edit(Book model)
        {
            Book oldbook = Book.ListBook.FirstOrDefault(x => x.Id == model.Id);
            oldbook.AuthorId = model.AuthorId;
            oldbook.GenreId = model.GenreId;
            if(model.Image != null )
            { 
                model.Image = model.Image.ToString();
            }      
            oldbook.Price = model.Price;
            oldbook.Sumary = model.Sumary;
            oldbook.Title = model.Title;
            oldbook.TotalPage = model.TotalPage;
            return RedirectToAction("Index");
        }
        public PartialViewResult PopularBook()
        {
            List<Book> books = Book.ListBook;
            return PartialView(books);
        }
    }
}
