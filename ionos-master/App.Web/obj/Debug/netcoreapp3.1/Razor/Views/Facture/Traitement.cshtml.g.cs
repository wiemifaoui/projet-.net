#pragma checksum "C:\Users\HP\Desktop\ionos-master\App.Web\Views\Facture\Traitement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf2e663edcac4a8a456bf32fb849a5c5e634725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facture_Traitement), @"mvc.1.0.view", @"/Views/Facture/Traitement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf2e663edcac4a8a456bf32fb849a5c5e634725", @"/Views/Facture/Traitement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4723d22b413d6abe7678061f95273542bcc544", @"/Views/_ViewImports.cshtml")]
    public class Views_Facture_Traitement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\ionos-master\App.Web\Views\Facture\Traitement.cshtml"
  
    ViewData["Title"] = "Traitement";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Traitement des factures</h1>
<hr height:100vh;
 width:.5vw;
 border-width:0;
 color:#000;
 background-color:#000;>


<strong>    Veuillez sélectionner les factures à traiter:      </strong>
<br>
<div class=""form-group"">
<div class=""input-group"">
<div class=""custom-file"">
<input type=""file"" class=""custom-file-input"" id=""exampleInputFile"">
<label class=""custom-file-label"" for=""exampleInputFile"">Choose file</label>
</div>

</div>
</div>
<input class=""favorite styled"" style=""float: right;""
       type=""button""
       value=""Vérification"">



<hr height:100vh;
 width:.5vw;
 border-width:0;
 color:#000;
 background-color:#000;>");
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