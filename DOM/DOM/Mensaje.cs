using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_MSJ.DOM
{
    [Serializable]
    public class Mensaje
    {
        private string m_IdMensaje = "";
        private string m_Descripcion = "";

        public Mensaje()
        {

        }

        internal Mensaje(string IdMensaje, string Descripcion)
        {
            this.m_IdMensaje = IdMensaje;
            this.m_Descripcion = Descripcion;
        }

        public string IdMensaje { 
            get {
                return this.m_IdMensaje;
            }
            set {
                this.m_IdMensaje = value;
            }
        }

        public string Descripcion
        {
            get {
                return this.m_Descripcion;
            }
            set
            {
                this.m_Descripcion = value;
            }
        }

    //public string getIdMensaje()
    //    {
    //        return this.IdMensaje;
    //    }

    //    protected void setIdMensaje(string IdMensaje)
    //    {
    //        this.IdMensaje = IdMensaje;
    //    }

    //    public string getDescripcion()
    //    {
    //        return this.Descripcion;
    //    }

    //    protected void setDescripcion(string Descripcion)
    //    {
    //        this.Descripcion = Descripcion;
    //    }
}
}
