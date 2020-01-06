using BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace BikeStore.Controllers
{
    //Тесты находятся находятся в BookingTests
    public class AdminController : Controller
    {
        // GET: Admin
        private DatabaseShopEntities1 db = new DatabaseShopEntities1();


        //1 метод для тестирования
        //В данном методе идёт тестирование по 2 случаям: поля txtUserName и txtPassword содержат значения "admin" и "admin", и если содежат другие
        //в первом случае  return RedirectToAction("Index")
        //во втором  return View();
        public ActionResult Login(string txtUserName, string txtPassword)
        {
                if ((txtUserName == "admin") && (txtPassword == "admin"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
        }
        //Конец метода


        public ActionResult Index()
        {
            var Items = db.Bikes;
            return View(Items);
        }

        [HttpGet]
        public ViewResult Edit(int bikeName)
        {
          var bike = db.Bikes.FirstOrDefault(b => b.Id == bikeName);
            return View(bike);
        }

        //2 метод для тестирования
        //В данном методе идёт тестирование по 2 случаям: если ModelState.IsValid = true, и ModelState.IsValid = false
        //в первом случае изменяются данные и происходит return RedirectToAction("Index");
        //во втором случает выполняется View()
        [HttpPost]
        public ActionResult Edit(Bikes bike)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bike).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(bike);
            }
        }
        //Конец метода

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        //3 метод для тестирования
        //В данном методе идёт тестирование по 2 случаям: если ModelState.IsValid = true, и ModelState.IsValid = false
        //в первом случае добавляются данные в базу данных и происходит return RedirectToAction("Index")
        //во втором случает выполняется View()
        [HttpPost]
        public ActionResult Add(Bikes bike)
        {
            if (ModelState.IsValid)
            {
            db.Bikes.Add(bike);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        //Конец метода


        //4 метод для тестирования    
        //В данном методе идёт тестирование по 2 случаям: если b=db.Bikes.Find(bikeid) не пуст, и b=db.Bikes.Find(bikeid) пустой
        //в первом случае удаляются данные из базы данных и происходит return RedirectToAction("Index")
        //во втором случает выполняется View()
        public ActionResult Delete(int bikeid)
        {
            var b = db.Bikes.Find(bikeid);
            if (b != null)
            {
                db.Bikes.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        //Конец метода



    }
}