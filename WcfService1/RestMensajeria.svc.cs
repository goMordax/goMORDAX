using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_SRV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RestMensajeria" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RestMensajeria.svc o RestMensajeria.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RestMensajeria : IRestMensajeria
    {
        public DDD_MSJ.DOM.Mensaje GetData(int value)
        {

            return null;
        }

        public IEnumerable<DDD_MSJ.DOM.Mensaje> GetData()
        {
            var appMensaje = new DDD_MSJ.APP.Mensajeria_Salida();
            var lstMensajes = new List<DDD_MSJ.DOM.Mensaje>();

            lstMensajes = appMensaje.getMensajes();

            return lstMensajes;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
