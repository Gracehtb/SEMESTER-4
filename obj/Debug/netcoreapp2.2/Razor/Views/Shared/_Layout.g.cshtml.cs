#pragma checksum "F:\ProjectRpl\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c60291ea87ff4eee1d39b5f3b96be81c16693d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c60291ea87ff4eee1d39b5f3b96be81c16693d7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78f5a7bef169c7b6916469b95ea7b1c4eed9a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery-easing/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sb-admin-2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 707, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c60291ea87ff4eee1d39b5f3b96be81c16693d76696", async() => {
                BeginContext(43, 354, true);
                WriteLiteral(@"

  <meta charset=""utf-8"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""description"" content="""">
  <meta name=""author"" content="""">

  <title>Vlane.Choco</title>

  <!-- Custom fonts for this template                        -->
  ");
                EndContext();
                BeginContext(397, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c60291ea87ff4eee1d39b5f3b96be81c16693d77447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(485, 193, true);
                WriteLiteral("\r\n  <link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\" rel=\"stylesheet\">\r\n\r\n  <!-- Custom styles for this template-->\r\n  ");
                EndContext();
                BeginContext(678, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c60291ea87ff4eee1d39b5f3b96be81c16693d79066", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(733, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(744, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(748, 7958, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c60291ea87ff4eee1d39b5f3b96be81c16693d711204", async() => {
                BeginContext(768, 7341, true);
                WriteLiteral(@"

  <!-- Page Wrapper -->
  <div id=""wrapper"">

    <!-- Sidebar -->
    <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

      <!-- Sidebar - Brand -->
      <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""http://localhost:5000/Home"">
        <div class=""sidebar-brand-icon rotate-n-10"">
          <img class=""rounded"" src=""img/vlane.choco.jpg"" width=""50"" height=""50"" style=""align: center;"">
        </div>
        <div class=""sidebar-brand-text mx-3"">Vlane.Choco</div>
      </a>

      <!-- Divider -->
      <hr class=""sidebar-divider my-0"">

      <!-- Nav Item - Dashboard -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""http://localhost:5000/Login"">
          <img class=""rounded"" src=""img/login.png"" width=""25"" height=""25"" style=""align: left;""></i>
          <span>Login</span></a>
        <a class=""nav-link"" href=""http://localhost:5000/Home"">
          <i class=""fas fa-fw fa-tachometer-alt");
                WriteLiteral(@"""></i>
          <span>Home</span></a>
      </li>
      

      <!-- Divider -->
      <hr class=""sidebar-divider"">

      <!-- Heading -->
      <div class=""sidebar-heading"">
        Menu
      </div>

      <!-- Nav Item - Pages Collapse Menu -->
      <li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
          <i class=""fas fa-fw fa-cog""></i>
          <span>Product</span>
        </a>
        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
          <div class=""bg-white py-2 collapse-inner rounded"">
            <h6 class=""collapse-header"">Category Product</h6>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Cosmetic</a>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Skin Care</a>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Polaroid</a>
  ");
                WriteLiteral(@"          <a class=""collapse-item"" href=""http://localhost:5000/Home"">Accessories</a>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Oriflame</a>
          </div>
        </div>
      </li>

      <!-- Nav Item - Utilities Collapse Menu -->
      <li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-controls=""collapseUtilities"">
          <i class=""fas fa-fw fa-wrench""></i>
          <span>Filter</span>
        </a>
        <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities"" data-parent=""#accordionSidebar"">
          <div class=""bg-white py-2 collapse-inner rounded"">
            <h6 class=""collapse-header"">Filter Product:</h6>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Product Name (A-Z)</a>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Product Name (Z-A)</a>
            <a class=""collapse-item""");
                WriteLiteral(@" href=""http://localhost:5000/Home"">Price Highest</a>
            <a class=""collapse-item"" href=""http://localhost:5000/Home"">Price Lower</a>
          </div>
        </div>
      </li>
<!-- 
      Divider
      <hr class=""sidebar-divider"">

      Heading
      <div class=""sidebar-heading"">
        Addons
      </div> -->

      <!-- Nav Item - Pages Collapse Menu -->
      <li class=""nav-item active"">
        <a class=""nav-link"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
          <i class=""fas fa-fw fa-folder""></i>
          <span>Service</span>
        </a>
        <div id=""collapsePages"" class=""collapse show"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
          <div class=""bg-white py-2 collapse-inner rounded"">
            <h6 class=""collapse-header"">Our Service</h6>
            <a class=""collapse-item"" href=""http://localhost:5000/ContactUs"">Contact Us</a>
            <a class=""collapse-item"" h");
                WriteLiteral(@"ref=""http://localhost:5000/FAQ"">FAQ</a>
            <a class=""collapse-item"" href=""http://localhost:5000/About"">About</a>
            <a class=""collapse-item"" href=""http://localhost:5000/Testimoni"">Testimoni</a>
          </div>
        </div>
      </li>

      <!-- Nav Item - Charts -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""http://localhost:5000/Payment"">
          <i class=""fas fa-fw fa-chart-area""></i>
          <span>Payment</span></a>
      </li>

      <!-- Nav Item - Tables -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""http://localhost:5000/Partnership"">
          <i class=""fas fa-fw fa-table""></i>
          <span>Partnership</span></a>
      </li>
      

      <!-- Divider -->
      <hr class=""sidebar-divider d-none d-md-block"">

      <!-- Sidebar Toggler (Sidebar) -->
      <div class=""text-center d-none d-md-inline"">
        <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
      </div>

    </ul>
    <!");
                WriteLiteral(@"-- End of Sidebar -->

    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

      <!-- Main Content -->
      <div id=""content"">

        <!-- Topbar -->
        <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

          <!-- Sidebar Toggle (Topbar) -->
          <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
            <i class=""fa fa-bars""></i>
          </button>

          <!-- Topbar Search >
          <form class=""d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"">
             <div class=""row"">
                <form asp-action=""Search"" class=""form-inline"">
                <div class=""form-group"">
                <label>Masukan Barang yang dicari :</label> 
                <input type=""text"" name=""keyword"" class=""form-control  bg-light border-0 medium"" placeholder=""Search for ..."" />
              </div>
                <button type=""s");
                WriteLiteral(@"ubmit"" class=""btn btn-primary"">Search</button> 
          </form><br/><br/>
            <div class=""input-group"">
              <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
              <div class=""input-group-append"">
                <button class=""btn btn-primary"" type=""button"">
                  <i class=""fas fa-search fa-sm""></i>
                </button>
              </div>
            </div>
          </form-->

          <!-- Topbar Navbar -->
          <ul class=""navbar-nav ml-auto"">

            <!-- Nav Item - Search Dropdown (Visible Only XS) -->
            <li class=""nav-item dropdown no-arrow d-sm-none"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
              </a>
              <!-- Dropdown - Messages -->
 ");
                WriteLiteral("           </li>\r\n          </ul>\r\n\r\n        </nav>\r\n        <!-- End of Topbar -->\r\n\r\n        <!-- Begin Page Content -->\r\n        <div class=\"container-fluid\">\r\n          ");
                EndContext();
                BeginContext(8110, 12, false);
#line 198 "F:\ProjectRpl\Views\Shared\_Layout.cshtml"
     Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(8122, 577, true);
                WriteLiteral(@"

        </div>
      
        <!-- /.container-fluid -->

      </div>
      <!-- End of Main Content -->

      <!-- Footer -->
      <footer class=""sticky-footer"" style=""background-color:#354eb9;"">
        <div class=""container my-auto"">
          <div class=""copyright text-center my-auto"">
            <span style=""color:white; "">Copyright &copy; Vlane Choco Website 2019</span>
          </div>
        </div>
      </footer>
      <!-- End of Footer -->

    </div>
    <!-- End of Content Wrapper -->

  </div>
  <!-- End of Page Wrapper -->

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8706, 41, true);
            WriteLiteral("\r\n  <!-- Bootstrap core JavaScript-->\r\n  ");
            EndContext();
            BeginContext(8747, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c60291ea87ff4eee1d39b5f3b96be81c16693d721308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8800, 4, true);
            WriteLiteral("\r\n  ");
            EndContext();
            BeginContext(8804, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c60291ea87ff4eee1d39b5f3b96be81c16693d722490", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8873, 40, true);
            WriteLiteral("\r\n\r\n  <!-- Core plugin JavaScript-->\r\n  ");
            EndContext();
            BeginContext(8913, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c60291ea87ff4eee1d39b5f3b96be81c16693d723713", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8980, 46, true);
            WriteLiteral("\r\n\r\n  <!-- Custom scripts for all pages-->\r\n  ");
            EndContext();
            BeginContext(9026, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c60291ea87ff4eee1d39b5f3b96be81c16693d724942", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9072, 15, true);
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
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
