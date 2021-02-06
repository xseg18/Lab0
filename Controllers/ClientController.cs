using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0.Models.Data;

namespace Lab0.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientList);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int ID)
        {
            var ViewClient = Singleton.Instance.ClientList.Find(x => x.Phone == ID);
            return View(ViewClient);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var newClient = new Models.Client
                {
                    Name = collection["Name"],
                    LName = collection["LName"],
                    Phone = Convert.ToInt32(collection["Phone"]),
                    Description = collection["Description"]
                };
                Singleton.Instance.ClientList.Add(newClient);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SortN()
        {
            Singleton.Instance1.Sort.SortN(Singleton.Instance.ClientList);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult SortL()
        {
            Singleton.Instance1.Sort.SortL(Singleton.Instance.ClientList);
            return RedirectToAction(nameof(Index));
        }
    }
}
