#pragma checksum "C:\Users\HP\Desktop\ionos-master\App.Web\Views\Tfacture\Traitement_facture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c8d82dc78b93d821510133c9ab0e0afe8c8586c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tfacture_Traitement_facture), @"mvc.1.0.view", @"/Views/Tfacture/Traitement_facture.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Desktop\ionos-master\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\ionos-master\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c8d82dc78b93d821510133c9ab0e0afe8c8586c", @"/Views/Tfacture/Traitement_facture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4723d22b413d6abe7678061f95273542bcc544", @"/Views/_ViewImports.cshtml")]
    public class Views_Tfacture_Traitement_facture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\ionos-master\App.Web\Views\Tfacture\Traitement_facture.cshtml"
  
    ViewData["Title"] = "Traitement_facture";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Traitement des factures</h1>
<hr height:100vh;
 width:.5vw;
 border-width:0;
 color:#000;
 background-color:#000;>

<strong>Voici la liste des factures soumis.(<span style=""color:red""> En rouges</span> les factures pr??sentant une erreur qui ne seront pas traiter) </strong>

<div class=""row"">
          <div class=""col-12"">
           <div class=""card"">
              <!-- /.card-header -->
              <div class=""card-body table-responsive p-0"">
                <table class=""table table-hover text-nowrap"">
                  <thead>
                   
                  </thead>
                  <tbody>
                     <tr>
                       <td>filename 2.pdf</td>
                      <td>11-7-2014</td>
                      <td>13.500 TND</td>
                      <td><i class=""icon fas fa-exclamation-triangle""></i></td>
                         <td><div class=""icheck-danger d-inline"">
                        <input type=""radio"" name=""r5""");
            BeginWriteAttribute("checked", " checked=\"", 1068, "\"", 1078, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""radioDanger1"">
                        <label for=""radioDanger1"">
                        </label>
                      </div></td>
                    </tr>
                    <tr>
                     <td>filename 3.pdf</td>
                      <td>11-7-2014</td>
                      <td>13.500 TND</td>
                      <td><i class=""icon fas fa-exclamation-triangle""></i></td>
                        <td><div class=""icheck-danger d-inline"">
                        <input type=""radio"" name=""r1""");
            BeginWriteAttribute("checked", " checked=\"", 1594, "\"", 1604, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""radioDanger1"">
                        <label for=""radioDanger1"">
                        </label>
                      </div></td>
                    </tr>
                    <tr>
                     <td>filename 4.pdf</td>
                      <td>11-7-2014</td>
                      <td>13.500 TND</td>
                      <td><i class=""icon fas fa-exclamation-triangle""></i></td>
                        <td><div class=""icheck-danger d-inline"">
                        <input type=""radio"" name=""r2""");
            BeginWriteAttribute("checked", " checked=\"", 2120, "\"", 2130, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""radioDanger1"">
                        <label for=""radioDanger1"">
                        </label>
                      </div></td>
                    </tr>
                    <tr>
                      <td>filename 5.pdf</td>
                      <td>11-7-2014</td>
                      <td>13.500 TND</td>
                      <td><i class=""icon fas fa-exclamation-triangle""></i></td>
                             <td><div class=""icheck-danger d-inline"">
                        <input type=""radio"" name=""r3""");
            BeginWriteAttribute("checked", " checked=\"", 2652, "\"", 2662, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""radioDanger1"">
                        <label for=""radioDanger1"">
                        </label>
                      </div></td>
                    </tr>
                    <tr>
                       <tr>
                      <td>filename 6.pdf</td>
                      <td>11-7-2014</td>
                      <td>13.500 TND</td>
                      <td><i class=""icon fas fa-exclamation-triangle""></i></td>
                           <td><div class=""icheck-danger d-inline"">
                        <input type=""radio"" name=""r4""");
            BeginWriteAttribute("checked", " checked=\"", 3210, "\"", 3220, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""radioDanger1"">
                        <label for=""radioDanger1"">
                        </label>
                      </div></td>
                    </tr>
                    <tr>
                </tbody>
                </table>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->
          </div>
        </div>


<div class=""form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck2"">
                        <label class=""form-check-label"" for=""exampleCheck2"">Envoyer une copie par email</label>
                      </div>
<input class=""favorite styled"" style=""float: right;""
       type=""button""
       value=""Confiramation"">


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
