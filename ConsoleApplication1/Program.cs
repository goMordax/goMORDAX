using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            var appMensajeria = new DDD_MSJ.APP.Mensajeria();
            var lstMensajes = appMensajeria.getMensajes();

            foreach (DDD_MSJ.DOM.Mensaje MensajeDevuelto in lstMensajes)
            {
                Console.WriteLine("IdMensaje: " + MensajeDevuelto.IdMensaje + "Descripcion: " + MensajeDevuelto.Descripcion);
            }

            Console.ReadKey();
        }
    }
}
