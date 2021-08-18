#pragma checksum "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf2b4d6c6033b54454538784e8a3d9233fd2dba4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
using ApplicationCore.ServiceInterfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf2b4d6c6033b54454538784e8a3d9233fd2dba4", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6112aabca9b932007558671ce74e32c023ef6c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.MovieDetailsResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-pill badge-dark m1-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Genres", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cast", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"bg-image\"");
            BeginWriteAttribute("style", " style=\"", 122, "\"", 170, 3);
            WriteAttributeValue("", 130, "background-image:url(", 130, 21, true);
#nullable restore
#line 4 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 151, Model.BackdropUrl, 151, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 169, ")", 169, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 offset-2\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 279, "\"", 301, 1);
#nullable restore
#line 9 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 285, Model.PosterUrl, 285, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"row mt-2\">\r\n                <div class=\"col-12\">\r\n                    <h1 class=\"text-white\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h1>\r\n                    <span style=\"color:white\">");
#nullable restore
#line 18 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                         Write(Model.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-4 text-white font-weight-bold mt-2 text-white\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
               Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m | ");
#nullable restore
#line 23 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                  Write(Model.ReleaseDate.Value.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n");
#nullable restore
#line 26 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                     foreach (var genre in Model.Genres)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2b4d6c6033b54454538784e8a3d9233fd2dba47616", async() => {
#nullable restore
#line 28 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                            Write(genre.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                          WriteLiteral(genre.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-4 mt-3\">\r\n                    <h4>\r\n                        <span class=\"badge badge-warning\">\r\n                            ");
#nullable restore
#line 36 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                       Write(Model.Rating?.ToString("0.000000"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-12 text-light mt-2\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
               Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-2 mt-4 offset-1"">
            <button type=""button"" class=""btn btn-outline-light btn-block"">REVIEW</button><br />
            <button type=""button"" class=""btn btn-outline-light btn-block"">TRAILER</button><br />
            <button type=""button"" class=""btn btn-light btn-block"">BUY ");
#nullable restore
#line 50 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button><br />
            <button type=""button"" class=""btn btn-light btn-block"">WATCH MOVIE</button>
        </div>
    </div>
</div>

<div class=""row mt-4"">
    <div class=""col-4"">
        <h5>MOVIE FACTS</h5>
        <hr>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">Release Date <span class=""badge badge-dark"">");
#nullable restore
#line 61 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                               Write(Model.ReleaseDate.Value.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n            <li class=\"list-group-item\">Run Time <span class=\"badge badge-dark\">");
#nullable restore
#line 62 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                           Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m</span></li>\r\n            <li class=\"list-group-item\">Box Office <span class=\"badge badge-dark\">$ ");
#nullable restore
#line 63 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                               Write(Model.Revenue.Value.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n            <li class=\"list-group-item\">Budget <span class=\"badge badge-dark\">$ ");
#nullable restore
#line 64 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                           Write(Model.Budget.Value.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n        </ul>\r\n    </div>\r\n\r\n    <div class=\"col-6 offset-1\">\r\n        <h5>CAST</h5>\r\n        <div class=\"card border-0\">\r\n");
#nullable restore
#line 71 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
             foreach (var cast in Model?.Casts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"list-group list-group-horizontal\">\r\n                    <li class=\"list-group-item col-1 border-left-0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2b4d6c6033b54454538784e8a3d9233fd2dba414577", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 3246, "\"", 3269, 1);
#nullable restore
#line 74 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 3252, cast.ProfilePath, 3252, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 3288, "\"", 3304, 1);
#nullable restore
#line 74 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 3294, cast.Name, 3294, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                                                                    WriteLiteral(cast.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item col-4 border-left-0\">");
#nullable restore
#line 75 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                               Write(cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item col-7 border-left-0 border-right-0\">");
#nullable restore
#line 76 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
                                                                              Write(cast.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n");
#nullable restore
#line 78 "C:\Users\andre\source\repos\JulyBatch\MovieShop\MovieShopMVC\Views\Movies\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.MovieDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
