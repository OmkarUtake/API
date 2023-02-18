using DataAccessLayer.Model;
using ServiceLayer.ApiConsuming;
using System.Net.Http;
using System.Web.Mvc;

namespace ServiceLayer.Controllers
{
    public class HomeController : Controller
    {
        HttpClient Client = new HttpClient();
        StudentApiConsume obj = new StudentApiConsume();
        public ActionResult Index()
        {
            var list = obj.GetAllStudents();
            return View(list);
        }

        public ActionResult Details(int id)
        {
            Student std = null;
            std = obj.GetById(id);
            return View(std);
        }

        public ActionResult Edit(int id)
        {
            Student std = obj.GetById(id);
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (obj.UpdateStudent(std))
            {
                return RedirectToAction("Index");
            }

            return View();
        }



    }
}