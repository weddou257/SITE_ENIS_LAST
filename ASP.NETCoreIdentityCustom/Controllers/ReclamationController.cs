using ASP.NETCoreIdentityCustom.Areas.Identity.Data;
using ASP.NETCoreIdentityCustom.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreIdentityCustom.Controllers
{
    public class ReclamationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ReclamationController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<reclamation> objList = _db.reclamation;
            return View(objList);
        }


        // GET - CREATE
        public IActionResult Create()
        {

            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(reclamation obj)
        {
            if (ModelState.IsValid)
            {
                _db.reclamation.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        // GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.reclamation.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(reclamation obj)
        {
            if (ModelState.IsValid)
            {
                _db.reclamation.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        // GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.reclamation.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.reclamation.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.reclamation.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }

    }
}

