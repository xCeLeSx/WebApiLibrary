using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using WebApiLibrary.Models;

namespace WebLibrary.Controllers
{
    public class KsiazkiController : Controller
    {
        // GET: KsiazkiController
        public ActionResult Index(string searchString)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("ksiazki", Method.GET, DataFormat.Json);
            var response = client.Execute<IEnumerable<Book>>(request);

            IEnumerable<Book> books = response.Data;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.FullBook.Contains(searchString));
            }

            return View(books);
        }


        // GET: KsiazkiController/Create
        public ActionResult Dodaj()
        {
            return View();
        }

        // POST: KsiazkiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dodaj(IFormCollection collection)
        {
            try
            {
                Book book = new Book();
                book.Title = collection["Title"];
                book.Author = collection["Author"];
                book.Publisher = collection["Publisher"];
                book.Added = DateTime.Parse(collection["Added"]);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("ksiazki", Method.POST, DataFormat.Json);

                request.AddJsonBody(book);
                var response = client.Post<Book>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KsiazkiController/Edit/5
        public ActionResult Edycja(int id)
        {

            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("ksiazki/" + id, Method.GET, DataFormat.Json);
            var response = client.Execute<Book>(request);

            Book book = response.Data;
            return View(book);
        }

        // POST: KsiazkiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edycja(int id, IFormCollection collection)
        {
            try
            {
                Book book = new Book();
                book.BookId = id;
                book.Title = collection["Title"];
                book.Author = collection["Author"];
                book.Publisher = collection["Publisher"];
                book.Added = DateTime.Parse(collection["Added"]);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("ksiazki/" + id, Method.PUT, DataFormat.Json);

                request.AddJsonBody(book);
                var response = client.Put<Book>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KsiazkiController/Delete/5
        public ActionResult Usun(int id)
        {

            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("ksiazki/" + id, Method.GET, DataFormat.Json);
            var response = client.Execute<Book>(request);

            Book book = response.Data;
            return View(book);
        }

        // POST: KsiazkiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Usun(int id, IFormCollection collection)
        {
            try
            {
                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("ksiazki/" + id, Method.DELETE, DataFormat.Json);
                var response = client.Delete(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
