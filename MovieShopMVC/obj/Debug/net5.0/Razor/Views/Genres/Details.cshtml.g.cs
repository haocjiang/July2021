#pragma checksum "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Genres\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f09ba9864b3eccc9e408d65d960654305877c05b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genres_Details), @"mvc.1.0.view", @"/Views/Genres/Details.cshtml")]
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
#line 1 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\_ViewImports.cshtml"
using MovieShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\_ViewImports.cshtml"
using MovieShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09ba9864b3eccc9e408d65d960654305877c05b", @"/Views/Genres/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6112aabca9b932007558671ce74e32c023ef6c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Genres_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationCore.Models.MovieCardResponseModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row bg-dark\" style=\"color:white;\">\r\n    <div class=\"col-5\">\r\n        <h1>");
#nullable restore
#line 5 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Genres\Details.cshtml"
       Write(ViewData["genreName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Movies</h1>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"rounded\">\r\n\r\n    <div class=\"container-fluid bg-light\">\r\n\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Genres\Details.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-6 col-lg-3 col-sm-4 col-xl-2\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Genres\Details.cshtml"
               Write(await Html.PartialAsync("_MovieCard", movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 20 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Genres\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationCore.Models.MovieCardResponseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
