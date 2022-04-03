using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SpaceObejctController : Controller
    {
        // GET: SpaceObejctController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SpaceObejctController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SpaceObejctController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpaceObejctController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SpaceObejctController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SpaceObejctController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SpaceObejctController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SpaceObejctController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
