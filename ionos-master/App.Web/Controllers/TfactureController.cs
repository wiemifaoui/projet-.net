using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    public class TfactureController : Controller
    {
        // GET: TfactureController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Traitement_facture()
        {
            return View();
        }
    }
}