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
    public class UzytkownicyController : Controller
    {
        // GET: UzytkownicyController
        public ActionResult Index(string searchString)
        {
            //List <User> users = new List<User>();
            //users.Add(new WebApiLibrary.Models.User()
            //{
            //    UserId = 2,
            //    FirstName = "Janusz",
            //    LastName = "Nowak",
            //    Pesel = 222222

            //}); 
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("uzytkownicy", Method.GET, DataFormat.Json);
            var response = client.Execute<IEnumerable<User>>(request);

            IEnumerable<User> users = response.Data;

            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.FullName.Contains(searchString));
            }

            return View(users);
        }

        // GET: UzytkownicyController/Create
        public ActionResult Dodaj()
        {
            return View();
        }

        // POST: UzytkownicyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dodaj(IFormCollection collection)
        {
            try
            {
                User user = new User();
                user.FirstName = collection["FirstName"];
                user.LastName = collection["LastName"];
                user.BirthDate = DateTime.Parse(collection["BirthDate"]);
                user.Pesel = Convert.ToInt64(collection["Pesel"]);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("uzytkownicy", Method.POST, DataFormat.Json);

                request.AddJsonBody(user);
                var response = client.Post<User>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UzytkownicyController/Edit/5
        public ActionResult Edycja(int id)
        {

            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("uzytkownicy/" + id, Method.GET, DataFormat.Json);
            var response = client.Execute<User>(request);

            User user = response.Data;
            return View(user);
        }

        // POST: UzytkownicyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edycja(int id, IFormCollection collection)
        {
            try
            {
                User user = new User();
                user.UserId = id;
                user.FirstName = collection["FirstName"];
                user.LastName = collection["LastName"];
                user.BirthDate = DateTime.Parse(collection["BirthDate"]);
                user.Pesel = Convert.ToInt64(collection["Pesel"]);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("uzytkownicy/" + id, Method.PUT, DataFormat.Json);

                request.AddJsonBody(user);
                var response = client.Put<User>(request);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UzytkownicyController/Delete/5
        public ActionResult Usun(int id)
        {

            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("uzytkownicy/"+id, Method.GET, DataFormat.Json);
            var response = client.Execute<User>(request);

            User user = response.Data;
            return View(user);
        }

        // POST: UzytkownicyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Usun(int id, IFormCollection collection)
        {
            try
            {
                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("uzytkownicy/"+id, Method.DELETE, DataFormat.Json);
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
