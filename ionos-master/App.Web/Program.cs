using App.Domain;
using App.Web.Controllers;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using System.Text;

namespace App.Web
{
    public class Program
    {
        // Lire un pdf
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            StringBuilder sb = new StringBuilder();
            string file = @"C:/Users/HP/OneDrive/Bureau/Stage/Invoice_2022-06-11_202038773912_V87919141.pdf";
            using (PdfReader reader = new PdfReader(file))
            {
                for (int pageNo = 1; pageNo <= reader.NumberOfPages; pageNo++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, pageNo, strategy);

                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    sb.Append(text);
                }
            }

            Invoice invoice = new Invoice();


            //Extraction de données de la facture ionos

            /*     Invoice invoice = new Invoice();


                 string[,] table = new string[,] { { "Contract ID:", ": " },
                       { "Customer ID:", ": " }, { "Invoice:", ": " }, { "Invoice Date:", ": " } };

                 for (int i = 0; i < (table.Length / 2) - 1; i++)
                 {
                     int startt = sb.ToString().IndexOf(table[i, 0]);

                     if (startt >= 0)
                     {
                         //lire toute la ligne.

                         int end = sb.ToString().IndexOf("\n", startt);
                         string line = sb.ToString().Substring(startt, end - startt);
                         Console.WriteLine(line);
                         string token = line.Split(table[i, 1])[1];
                         Console.WriteLine(token);

                         //Conversion des données dans un fichier json

                         switch (table[i, 0]) //selon table[i, 0]
                         {
                             case "Contract ID:": invoice.ContractID = token; break;
                             case "Invoice:": invoice.InvoiceID = token; break;
                             case "Invoice Date:": invoice.InvoiceDate = token; break;
                             case "Customer ID:": invoice.CustomerID = token; break;
                         }


                         // Console.WriteLine(sb.ToString);
                          Console.ReadKey();

                     }
                 }

                 string json = JsonSerializer.Serialize(invoice);
                 string filePath = @"C:\Users\Public\invoice_" + DateTime.Now.Ticks + ".json";
                 File.WriteAllText(filePath, json);

                // Extraction du montant en $

                 int dollars = 0;
                 int start = 0;
                 while (dollars < sb.ToString().Length)
                 {
                     start = sb.ToString().IndexOf("$", start + 1);
                     if (start > 0)
                         dollars = start;
                     else
                         break;

                 }
                 Console.WriteLine(dollars);
                 int end_dollars = sb.ToString().IndexOf("\n", dollars);
                 string amount = sb.ToString().Substring(dollars, end_dollars - dollars);
                 Console.WriteLine(amount);
             }




            */

            


            static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                  .ConfigureWebHostDefaults(webBuilder =>
                  {
                      webBuilder.UseStartup<Startup>();
                  });
        }
    }
}