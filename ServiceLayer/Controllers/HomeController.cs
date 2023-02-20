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

            Student std = obj.GetById(id);
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

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Student std)
        {
            if (obj.CreateStuddent(std))
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            Student std = obj.GetById(id);
            return View(std);
        }

        [HttpPost]
        public ActionResult Delete(int id, Student std)
        {
            if (obj.DeleteStudent(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}