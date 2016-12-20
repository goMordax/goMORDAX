using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web1;
using Web1.Controllers;

namespace Web1.Tests.Controllers
{
    [TestClass]
    public class MensajeControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Disponer
            DDD_MSJ_WEBAPI.Controllers.MensajeController controller = new DDD_MSJ_WEBAPI.Controllers.MensajeController();

            // Actuar
            IEnumerable<DDD_MSJ.DOM.Mensaje> result = controller.Get();

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count());
            Assert.AreEqual("1", result.ElementAt(0).IdMensaje);
            Assert.AreEqual("2", result.ElementAt(1).IdMensaje);
        }

        [TestMethod]
        public void GetById()
        {
            // Disponer
            DDD_MSJ_WEBAPI.Controllers.MensajeController controller = new DDD_MSJ_WEBAPI.Controllers.MensajeController();

            // Actuar
            string result = controller.Get(5);

            // Declarar
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Disponer
            DDD_MSJ_WEBAPI.Controllers.MensajeController controller = new DDD_MSJ_WEBAPI.Controllers.MensajeController();

            // Actuar
            controller.Post("value");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Disponer
            DDD_MSJ_WEBAPI.Controllers.MensajeController controller = new DDD_MSJ_WEBAPI.Controllers.MensajeController();

            // Actuar
            controller.Put(5, "value");

            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Disponer
            DDD_MSJ_WEBAPI.Controllers.MensajeController controller = new DDD_MSJ_WEBAPI.Controllers.MensajeController();

            // Actuar
            controller.Delete(5);

            // Declarar
        }
    }
}
