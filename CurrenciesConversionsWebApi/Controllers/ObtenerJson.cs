using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CurrenciesConversionsWebApi.Models;

namespace CurrenciesConversionsWebApi.Controllers
{
    public class ObtenerJson
    {
        public async Task<List<CurrienciesModel>> GetCurriencies()
        {
            HttpClient cliente = new HttpClient();
            var json = await cliente.GetStringAsync("https://api.mercadolibre.com/currencies/");
            List<CurrienciesModel> objCurrency = JsonConvert.DeserializeObject<List<CurrienciesModel>>(json);
            return objCurrency;
        }

        public async Task<Property> PropertyCurrency(string property)
        {
            HttpClient objcliente = new HttpClient();
            var json = await objcliente.GetStringAsync("https://api.mercadolibre.com/currency_conversions/search?from=XXX&to=" + property + "&to=USD");
            Property objValue = JsonConvert.DeserializeObject<Property>(json);
            return objValue;
        }
    }
}