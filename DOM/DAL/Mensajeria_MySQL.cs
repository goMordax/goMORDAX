using System.Collections.Generic;

namespace DDD_MSJ.DAL
{
    class Mensajeria_MySQL : DDD_MSJ.DAL.Mensajeria_base
    {
        private List<DDD_MSJ.DOM.Mensaje> m_lstMensajes;

        //constructor
        public Mensajeria_MySQL()
        {
            this.m_lstMensajes = new List<DDD_MSJ.DOM.Mensaje>();
        }

        public override List<DDD_MSJ.DOM.Mensaje> getMensajes()
        {
            var sqlConexion = new System.Data.Odbc.OdbcConnection("Dsn=prova");
            var sqlComando = new System.Data.Odbc.OdbcCommand();
            System.Data.Odbc.OdbcDataReader sqlReader;

            sqlComando.CommandText = "select * from mensajeria.Mensaje;";
            sqlComando.CommandType = System.Data.CommandType.Text;
            sqlComando.Connection = sqlConexion;

            try
            {

                sqlConexion.Open();
                sqlReader = sqlComando.ExecuteReader();

                string IdMensaje = "";
                string Descripcion = "";
                DDD_MSJ.DOM.Mensaje Mensaje;

                while (sqlReader.Read())
                {
                    IdMensaje = sqlReader.GetString(0);
                    Descripcion = sqlReader.GetString(1);
                    Mensaje = new DDD_MSJ.DOM.Mensaje(IdMensaje, Descripcion);
                    this.m_lstMensajes.Add(Mensaje);
                }

            }
            finally
            {
                sqlConexion.Close();
            }

            return this.m_lstMensajes;
        }

        public override void guardarMensajes(List<DOM.Mensaje> Mensajes)
        {
            var sqlConexion = new System.Data.Odbc.OdbcConnection("Dsn=prova");
            var sqlComando = new System.Data.Odbc.OdbcCommand();

            sqlComando.CommandText = "INSERT INTO mensajeria.Mensaje (IDMensaje, Mensaje) VALUES ('@IdMensaje','@Descripcion');";

            sqlComando.CommandType = System.Data.CommandType.Text;
            sqlComando.Connection = sqlConexion;

            System.Data.Odbc.OdbcTransaction Transaccion = null;

            try
            {

                sqlConexion.Open();

                Transaccion = sqlConexion.BeginTransaction();

                sqlComando.Transaction = Transaccion;

                foreach (DDD_MSJ.DOM.Mensaje MensajeAInserir in Mensajes)
                {
                    sqlComando.Parameters.AddWithValue("@IdMensaje", MensajeAInserir.IdMensaje);
                    sqlComando.Parameters.AddWithValue("@Descripcion", MensajeAInserir.Descripcion);
                    sqlComando.ExecuteNonQuery();
                }
            }
            catch
            {
                if (Transaccion != null) { Transaccion.Rollback(); }
            }
            finally
            {
                if (Transaccion != null) { Transaccion.Commit(); }
                sqlConexion.Close();
            }
        }

    }
}




