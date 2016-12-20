using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.I
{
    public interface IMensajeria
    {
        void guardarMensajes(List<DDD_MSJ.DOM.Mensaje> Mensajes);
        List<DDD_MSJ.DOM.Mensaje> getMensajes();

    }
}
