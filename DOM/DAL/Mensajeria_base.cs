using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.DAL
{
    abstract class Mensajeria_base
    {
        abstract public void guardarMensajes(List<DDD_MSJ.DOM.Mensaje> Mensajes);
        abstract public List<DDD_MSJ.DOM.Mensaje> getMensajes();

    }
}
