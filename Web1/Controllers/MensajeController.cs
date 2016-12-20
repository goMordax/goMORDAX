using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DDD_MSJ_WEBAPI.Controllers
{
    public class MensajeController : ApiController
    {
        // GET api/values
        public IEnumerable<DDD_MSJ.DOM.Mensaje> Get()
        {
            var appMensaje = new DDD_MSJ.APP.Mensajeria();
            var lstMensajes = new List <DDD_MSJ.DOM.Mensaje>();

            lstMensajes = appMensaje.getMensajes();

            return lstMensajes;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
