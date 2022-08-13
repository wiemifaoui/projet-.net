using App.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUploadController
        public ActionResult Index()
        {
            return View();                                                           
        }

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), formFile.FileName); //Add your own file path.
                    filePaths.Add(filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            float amount=500;
            string from = "USD";
            string to = "TND";
            string invoiceDate = "2020-04-04";
            
            
            Convertion conversion = await RateHelper.GetExchangeRate(from, to, invoiceDate);
            var amountAfterConvertion = conversion.Rates.TND * amount;
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            return View(new { count = files.Count, size, filePaths });
        }
    }
}
   





