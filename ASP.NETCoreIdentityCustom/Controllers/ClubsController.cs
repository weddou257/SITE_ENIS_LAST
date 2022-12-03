using ASP.NETCoreIdentityCustom.Areas.Identity.Data;
using ASP.NETCoreIdentityCustom.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreIdentityCustom.Controllers
{
    public class ClubsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ClubsController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<Clubs> objList = _db.Clubs;
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
        public IActionResult Create(Clubs obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clubs.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Create");
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
            var obj = _db.Club.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Clubs obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clubs.Update(obj);
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
            var obj = _db.Clubs.Find(id);
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
            var obj = _db.Clubs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Clubs.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }

    }
}
