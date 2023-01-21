using Microsoft.AspNetCore.Http;
using System.IO;

using Microsoft.AspNetCore.Mvc;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class CagnotteController : Controller
    {
        private readonly ICagnotte _cagnotteService;
        private readonly IEntreprise _entrepriseService;

        public CagnotteController(ICagnotte cagnotteService, IEntreprise entrepriseService)
        {
            _cagnotteService = cagnotteService;
            _entrepriseService = entrepriseService;
        }



        // GET: CagnotteController
        
        public ActionResult Index()
        {
            return View(_cagnotteService.GetAll().ToList());
        }


        [HttpPost]
        public ActionResult Index(string nom)
        {
            if (!string.IsNullOrEmpty(nom))
                return View(_cagnotteService.GetMany(d => d.Titre.Equals(nom)).ToList());
            else
                return View(_cagnotteService.GetAll().ToList());
        }

        // GET: CagnotteController/Details/5
        public ActionResult Details(int id)
        {

            var flight = _cagnotteService.GetById((int)id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        // GET: CagnotteController/Create
        public ActionResult Create()
        {
            ViewBag.Entreprise = new SelectList(_entrepriseService.GetAll().ToList(),
                "EntrepriseId", "NomEntreprise");
            return View();
        }

        // POST: CagnotteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cagnotte cagnotte, IFormFile Photo)
        {
            try
            {
                if (Photo != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", Photo.FileName);
                    Stream stream = new FileStream(path, FileMode.Create);
                    Photo.CopyTo(stream);
                    cagnotte.Photo = Photo.FileName;
                }
                _cagnotteService.Add(cagnotte);
                _cagnotteService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CagnotteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CagnotteController/Edit/5
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

        // GET: CagnotteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CagnotteController/Delete/5
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
