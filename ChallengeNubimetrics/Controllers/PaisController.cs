using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;

namespace ChallengeNubimetrics.Controllers
{
    [System.Web.Mvc.RoutePrefix("{api/Paises}")]
    
    public class PaisController : ApiController
    {
        // GET: api/Pais/5
        [System.Web.Http.Route("api/pais")]
        public async Task<String> GetAsync(string pais)
        {
            if (pais == "BR" || pais == "br" || pais == "CO" || pais == "co")
            {
                HttpContext.Current.Response.StatusCode = 401;
                return "Error 401 Unauthorized";
            }
           
                HttpClient httpClient = new HttpClient();
                var json = await httpClient.GetStringAsync("https://api.mercadolibre.com/classified_locations/countries/" + pais);
                return json;
            
        }
    }
}
