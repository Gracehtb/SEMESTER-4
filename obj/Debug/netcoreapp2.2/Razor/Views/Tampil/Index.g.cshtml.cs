#pragma checksum "F:\ProjectRpl\Views\Tampil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d186098c0d10f7faa51c924d7efa595f5f3b681d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tampil_Index), @"mvc.1.0.view", @"/Views/Tampil/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tampil/Index.cshtml", typeof(AspNetCore.Views_Tampil_Index))]
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
#line 1 "F:\ProjectRpl\Views\_ViewImports.cshtml"
using ProjectRpl;

#line default
#line hidden
#line 2 "F:\ProjectRpl\Views\_ViewImports.cshtml"
using ProjectRpl.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d186098c0d10f7faa51c924d7efa595f5f3b681d", @"/Views/Tampil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78f5a7bef169c7b6916469b95ea7b1c4eed9a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tampil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\ProjectRpl\Views\Tampil\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 896, true);
            WriteLiteral(@"<div class=""jumbotron text-center"">
  <h1>FAQ (Frequently Asked Questions)</h1>
  <img class=""img-fluid rounded"" src=""img/faq-icon.png"" alt="""">
  <p class=""lead"">Selamat datang di Vlane.Choco, kami menawarkan berbagai macam produk yang anda butuhkan.
          Berikut adalah daftar pertanyaan yang sering anda tanyakan:</p>
</div>

<table class=""table table-striped"">
<tr>
<th>Question</th>
<tr>
<td>Apakah dapat dilakukan Cash on Delivery?</td>
<td>Apakah semua barang ready stock?</td>
<td>Apa yang dimaksud dengan sistem Preorder?</td>
</tr>
<th>Answer</th>
<tr>
<td>Tentu saja bisa, dengan lokasi Monjali dan sekitar UKDW.</td>
<td>Tentu saja bisa, dengan lokasi Monjali dan sekitar UKDW.</td>
<td>Preorder adalah sistem dimana pembeli harus menunggu barang
            selama beberapa hari untuk sampai ditangan pembeli.</td>
</tr>
</tr>
</table>
<p>Your Question : ");
            EndContext();
            BeginContext(929, 8, false);
#line 28 "F:\ProjectRpl\Views\Tampil\Index.cshtml"
              Write(Model.cm);

#line default
#line hidden
            EndContext();
            BeginContext(937, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
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
