
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        public ActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(feedback);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
