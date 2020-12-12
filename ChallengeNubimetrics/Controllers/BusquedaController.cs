using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using ChallengeNubimetrics.Models;
using Newtonsoft.Json;
using System.Web;

namespace ChallengeNubimetrics.Controllers
{
    public class BusquedaController : ApiController
    {
        //GET: api/Busqueda/5
        public async Task<string> GetAsync(string buscar)
        {

            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.mercadolibre.com/sites/MLA/search?q=" + buscar);

            Producto prod = JsonConvert.DeserializeObject<Producto>(json);
            var prodJson = JsonConvert.SerializeObject(prod);

            return prodJson;
        }
    }
}
