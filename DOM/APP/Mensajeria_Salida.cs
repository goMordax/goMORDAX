using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.APP
{
   public class Mensajeria_Salida: I.Mensajeria_OUT
    {
        readonly DDD_MSJ.DAL.Mensajeria_base m_Mensajeria;

        public Mensajeria_Salida()
        {
            m_Mensajeria = new DDD_MSJ.I.Mensajeria().getMensajeria();
        }

        public List<DDD_MSJ.DOM.Mensaje> getMensajes()
        {            
            return m_Mensajeria.getMensajes();
        }
    }
}
