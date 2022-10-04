using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class CampsController : Controller
    {
        private readonly ILogger logger;

        public CampsController(ILogger logger)
        {
            this.logger = logger;
        }


        // GET: CampsController
        public IActionResult Get()
        {
            return Ok(new { Moniker ="ATL2022", Name="Atlanta CodeCamp"});
        }

        // GET: CampsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CampsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CampsController/Create
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

        // GET: CampsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CampsController/Edit/5
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

        // GET: CampsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CampsController/Delete/5
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
