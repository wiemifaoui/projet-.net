using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    public class FactureController : Controller
    {

        // GET: TraitementController1
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Traitement()
        {
            return View();
        }

        public async Task<string> GetExchangeRate(string from, string to, string invoiceDate)
        {

            //Examples:
            //from = "EUR"
            //to = "USD"
            using (var client = new HttpClient())
            {

                try
                {
                    client.BaseAddress = new Uri("https://api.exchangerate.host");
                    var response = await client.GetAsync($"/{invoiceDate}?source=ecb&from={from}");
                    var stringResult = await response.Content.ReadAsStringAsync();

                    var dictResult = JsonConvert.DeserializeObject(stringResult);
                    return "ok";
                    dynamic data = JObject.Parse(stringResult);
                    //data = {"EUR_USD":{"val":1.140661}}
                    //I want to return 1.140661
                    //EUR_USD is dynamic depending on what from/to is
                    return data.val;
                }
                catch (HttpRequestException httpRequestException)
                {
                    Console.WriteLine(httpRequestException.StackTrace);
                    return "Error calling API. Please do manual lookup.";
                }
            }
        }

    }
}