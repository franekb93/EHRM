using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WS_EHRM;
using WS_EHRM.Controllers;

namespace WS_EHRM.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Przygotowanie
            HomeController controller = new HomeController();

            // Wykonanie
            ViewResult result = controller.Index() as ViewResult;

            // Sprawdzenie
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
