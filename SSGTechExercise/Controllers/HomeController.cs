using SSGTechExercise.BL;
using SSGTechExercise.Models;
using System.Web.Mvc;

namespace SSGTechExercise.Controllers
{
    public class HomeController : Controller
    {
        CustomersContext _db = new CustomersContext();
        public ActionResult Index()
        {
            // var model = _db.Customer.ToList();
            CustomersBL custBl = new CustomersBL();
            var model = custBl.returnAll();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}