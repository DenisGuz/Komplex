using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeStore.Controllers;
using System.Web.Mvc;
using System.Web.Routing;

namespace BikeStore.Controllers.Tests
{
    [TestClass()]
    public class AdminControllerTests

    {   
         [TestMethod()]
        public void Login_CorrectData_OK()
        {
            var admc = new AdminController();
           string login = "admin";
            string passw = "admin";

            var exp = admc.RedirectToAction("Index");
            //RedirectToAction недоступен из-за уровня защиты
            var fact = admc.Login(login, passw);

            Assert.AreSame(exp, fact);
            // Возможно assert.aresame не подходящий метод дня тестирования 

            var result = ();
            var redirectResult = result.As<RedirectToRouteResult>();

            var expectedRedirectValues = new RouteValueDictionary
        {
            { "action", "Index" }
        };

            redirectResult
               .RouteValues
               .ShouldBeEquivalentTo(expectedRedirectValues);
        }
        [TestMethod()]
        public void Login_CorrectData_notOK()
        {
            var admc = new AdminController();
            string login = "admin";
            string passw = "admin";
            AdminController exp = admc.View("Index");
            //View недоступен из-за уровня защиты
            var fact = admc.Login(login, passw);

            //Assert.AreNotSame(exp, fact);

        }
        /*
        [TestMethod()]
        public void Edit_()
        {
            var controller = new AdminController();
            controller.ModelState.Clear();


        }
        */
        [TestMethod()]
        public void Edit_Vaidation_OK()
        {
            AdminController admController = new AdminController();
            ActionResult result = admController.Index();
            //Сбой Assert.IsInstanceOfType. Ожидается тип: <System.Web.Mvc.RedirectToRouteResult>. Фактический тип: <System.Web.Mvc.ViewResult>.
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
           // RedirectToRouteResult routeResult = result as RedirectToRouteResult;
            //Assert.AreEqual(routeResult.RouteValues["action"], "Index");

        }
    }
}



