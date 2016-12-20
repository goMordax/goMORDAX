using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.DAL
{
    class Mensajeria
    {        
        public DDD_MSJ.DAL.Mensajeria_base getMensajeria()
        {
            return new DDD_MSJ.DAL.Mensajeria_MySQL();
        }

}
}
