using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.APP
{
    public class Mensajeria_Entrada : DDD_MSJ.I.Mensajeria_IN
    {
        readonly DDD_MSJ.DAL.Mensajeria_base m_Mensajeria;
        public Mensajeria_Entrada()
        {
            m_Mensajeria = new DDD_MSJ.I.Mensajeria().getMensajeria();
        }

        public void guardarMensajes(List<DDD_MSJ.DOM.Mensaje> Mensajes)
        {
            m_Mensajeria.guardarMensajes(Mensajes);


        }
    }
}