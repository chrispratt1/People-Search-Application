using People_Search_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace People_Search_Application.Controllers
{
    public class HomeController : Controller
    {
        private PeopleContext db = new PeopleContext();
        public ActionResult Index()
        {
            People person = new People { name = "Chris", personID = 1, address = "234 West", age = 12, interests = "sports, school", picture = "chris.png" };
            db.Person.Add(person);
            Dictionary<int, People> people = db.Person.ToDictionary(props => props.personID, props => props);
            ViewBag.people = db.Person.ToList();
            ViewBag.person = person;

            return View();
        }

        [HttpPost]
        public string AddPerson(People model)
        {
            var person = db.Person.Create();
            person.name = model.name;
            person.address = model.address;
            person.age = model.age;
            person.interests = model.interests;
            person.picture = model.picture;

            db.Person.Add(person);
            db.SaveChanges();

            return person.personID.ToString();
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
    }
}