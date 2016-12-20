using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DDD_MSJ_SRV
{
    /// <summary>
    /// Descripción breve de Mensajeria
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Mensajeria : System.Web.Services.WebService, DDD_MSJ.I.IMensajeria
    {

        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public List<DDD_MSJ.DOM.Mensaje> getMensajes()
        {
            var appMensajeria = new DDD_MSJ.APP.Mensajeria();
            return appMensajeria.getMensajes();
        }
        [WebMethod]
        public void guardarMensajes(List<DDD_MSJ.DOM.Mensaje> Mensajes)
        {
            var appMensajeria = new DDD_MSJ.APP.Mensajeria();
            appMensajeria.guardarMensajes(Mensajes);
        }
    }
}
