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
    public class WypozyczeniaController : Controller
    {
        // GET: WypoztczeniaController
        public ActionResult Index()
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("wypozyczenia", Method.GET, DataFormat.Json);
            var response = client.Execute<IEnumerable<Borrow>>(request);

            IEnumerable<Borrow> borrows = response.Data;
            return View(borrows);
        }

        // GET: WypoztczeniaController/Details/5
        public ActionResult Szczegoly(int id)
        {
            return View();
        }

        // GET: WypoztczeniaController/Create
        public ActionResult Dodaj()
        {
            return View();
        }

        // POST: WypoztczeniaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dodaj(IFormCollection collection)
        {
            try
            {
                Borrow borrow = new Borrow();
                borrow.BookId = Convert.ToInt16(collection["BookId"]);
                borrow.UserId = Convert.ToInt16(collection["UserId"]);
                borrow.BorrowDate = DateTime.Now;
                borrow.ReturnDate = default;
                borrow.Return = false;

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("wypozyczenia", Method.POST, DataFormat.Json);

                request.AddJsonBody(borrow);
                var response = client.Post<Borrow>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WypoztczeniaController/Edit/5
        public ActionResult Edycja(int id)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("wypozyczenia/" + id, Method.GET, DataFormat.Json);
            var response = client.Execute<Borrow>(request);

            Borrow borrow = response.Data;
            return View(borrow);
        }

        // POST: WypoztczeniaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edycja(int id, IFormCollection collection)
        {
            try
            {
                Borrow borrow = new Borrow();
                borrow.BorrowId = id;
                borrow.BookId = Convert.ToInt16(collection["BookId"]);
                borrow.UserId = Convert.ToInt16(collection["UserId"]);
                borrow.BorrowDate = DateTime.Parse(collection["BorrowDate"]);
                borrow.ReturnDate = DateTime.Parse(collection["ReturnDate"]);
                borrow.Return = Convert.ToBoolean(collection["Return"]);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("wypozyczenia/" + id, Method.PUT, DataFormat.Json);

                request.AddJsonBody(borrow);
                var response = client.Put<Borrow>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WypoztczeniaController/Delete/5
        public ActionResult Usun(int id)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("wypozyczenia/" + id, Method.GET, DataFormat.Json);
            var response = client.Execute<Borrow>(request);

            Borrow borrow = response.Data;
            return View(borrow);
        }

        // POST: WypoztczeniaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Usun(int id, IFormCollection collection)
        {
            try
            {
                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("wypozyczenia/" + id, Method.DELETE, DataFormat.Json);
                var response = client.Delete(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WypoztczeniaController/Zwrot/5
        public ActionResult Zwrot(int id)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("wypozyczenia/" + id, Method.GET, DataFormat.Json);
            var response = client.Execute<Borrow>(request);

            Borrow borrow = response.Data;
            return View(borrow);
        }

        // POST: WypoztczeniaController/Zwrot/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Zwrot(int id, IFormCollection collection)
        {
            try
            {
                RestClient client2 = new RestClient("https://localhost:5001/api/");
                RestRequest request2 = new RestRequest("wypozyczenia/" + id, Method.GET, DataFormat.Json);
                var response2 = client2.Execute<Borrow>(request2);

                Borrow borrow = response2.Data;
                borrow.ReturnDate = DateTime.Now;
                borrow.Return = true;

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("wypozyczenia/" + id, Method.PUT, DataFormat.Json);

                request.AddJsonBody(borrow);
                var response = client.Put<Borrow>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
