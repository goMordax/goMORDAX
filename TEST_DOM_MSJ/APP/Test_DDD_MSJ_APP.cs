using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TEST_DDD_MSJ
{
    [TestClass]
    public class Test_DDD_MSJ_APP
    {
        [TestMethod]
        public void DAL_Mensje_MySQL()
        {
            var appMensajeria = new DDD_MSJ.APP.Mensajeria();
            var expected_lstMensajes = appMensajeria.getMensajes();

            Assert.IsNotNull(expected_lstMensajes);
            
        }
    }

    
}
