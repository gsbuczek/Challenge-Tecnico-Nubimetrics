using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.Web.Mvc;
using UsuariosClase;

namespace ChallengeNubimetrics.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: Usuarios
        public IEnumerable<Usuarios> Get()
        {
            using (ChallengeEntities db = new ChallengeEntities())

                return db.Usuarios.ToList();

        }

        public HttpResponseMessage Post([FromBody] Usuarios user)
        {
            int resp = 0;
            HttpResponseMessage msg = null;
            try
            {
                using (ChallengeEntities db = new ChallengeEntities())
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Added;
                    resp = db.SaveChanges();
                    msg = Request.CreateResponse(HttpStatusCode.OK, resp);
                }

            }
            catch (Exception ex)
            {
                msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return msg;
        }

        public HttpResponseMessage Put([FromBody] Usuarios user)
        {
            int resp = 0;
            HttpResponseMessage msg = null;
            try
            {
                using (ChallengeEntities db = new ChallengeEntities())
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    resp = db.SaveChanges();
                    msg = Request.CreateResponse(HttpStatusCode.OK, resp);
                }

            }
            catch (Exception ex)
            {
                msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return msg;
        }

        public HttpResponseMessage Delete([FromBody] Usuarios user)
        {
            int resp = 0;
            HttpResponseMessage msg = null;
            try
            {
                using (ChallengeEntities db = new ChallengeEntities())
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                    resp = db.SaveChanges();
                    msg = Request.CreateResponse(HttpStatusCode.OK, resp);
                }

            }
            catch (Exception ex)
            {
                msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return msg;
        }
    }
}
