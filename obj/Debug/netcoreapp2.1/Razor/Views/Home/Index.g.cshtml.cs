#pragma checksum "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c941412f052a850cbd021274be48ba2cafd51936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c941412f052a850cbd021274be48ba2cafd51936", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChillAndGrill.ViewModels.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(95, 24, true);
            WriteLiteral("\r\n<h1>All Restaurants - ");
            EndContext();
            BeginContext(120, 17, false);
#line 7 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(137, 16, true);
            WriteLiteral("</h1>\r\n<table>\r\n");
            EndContext();
#line 9 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(212, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(243, 15, false);
#line 12 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(258, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(282, 13, false);
#line 13 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
           Write(restaurant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(295, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(319, 63, false);
#line 14 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Go", "Details", "Home", new { restaurant.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(382, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(411, 37, true);
            WriteLiteral("</table>\r\n<br />\r\n<div>\r\n    <button>");
            EndContext();
            BeginContext(449, 51, false);
#line 20 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Add Restaurant", "Create", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(500, 21, true);
            WriteLiteral("</button>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("footer", async() => {
                BeginContext(537, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(545, 20, false);
#line 24 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Index.cshtml"
Write(Model.CurrentMessage);

#line default
#line hidden
                EndContext();
                BeginContext(565, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(570, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChillAndGrill.ViewModels.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
