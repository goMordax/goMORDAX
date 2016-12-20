using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.APP
{
    public class Mensajeria: DDD_MSJ.I.IMensajeria
    {
        readonly DDD_MSJ.DAL.Mensajeria_base m_Mensajeria;
        public Mensajeria()
        {
            m_Mensajeria = new DDD_MSJ.DAL.Mensajeria().getMensajeria();
        }

        public void guardarMensajes(List<DDD_MSJ.DOM.Mensaje> Mensajes)
        {
            m_Mensajeria.guardarMensajes(Mensajes);


        }

        public List<DDD_MSJ.DOM.Mensaje> getMensajes()
        {
            return m_Mensajeria.getMensajes();
        }
    }
}
