#pragma checksum "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ccaf7130c6fa5f8b5ecdc2a823c31f1d609691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Update.cshtml", typeof(AspNetCore.Views_Home_Update))]
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
#line 1 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
using ChillAndGrill.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ccaf7130c6fa5f8b5ecdc2a823c31f1d609691", @"/Views/Home/Update.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChillAndGrill.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
  
    ViewBag.Title = "Update";

#line default
#line hidden
            BeginContext(109, 13, true);
            WriteLiteral("\r\n<h1>Update ");
            EndContext();
            BeginContext(123, 8, false);
#line 8 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(131, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(134, 10, false);
#line 8 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(144, 78, true);
            WriteLiteral("</h1>\r\n<div>\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 222, "\"", 239, 1);
#line 11 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
WriteAttributeValue("", 230, Model.Id, 230, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(240, 32, true);
            WriteLiteral(" />\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(273, 18, false);
#line 13 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
       Write(Html.Label("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(291, 44, true);
            WriteLiteral("\r\n            <input type=\"text\" name=\"Name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 335, "\"", 354, 1);
#line 14 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
WriteAttributeValue("", 343, Model.Name, 343, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 23, true);
            WriteLiteral(" />\r\n            <span>");
            EndContext();
            BeginContext(379, 30, false);
#line 15 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
             Write(Html.ValidationMessage("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(409, 52, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(462, 21, false);
#line 18 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
       Write(Html.Label("Cuisine"));

#line default
#line hidden
            EndContext();
            BeginContext(483, 62, true);
            WriteLiteral("\r\n            <select name=\"Cuisine\">\r\n                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 545, "\"", 567, 1);
#line 20 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
WriteAttributeValue("", 553, Model.Cuisine, 553, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(568, 17, true);
            WriteLiteral(" selected hidden>");
            EndContext();
            BeginContext(586, 13, false);
#line 20 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
                                                          Write(Model.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(599, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 21 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
                 foreach (CuisineType cuisineType in Enum.GetValues(typeof(CuisineType)))
                {

#line default
#line hidden
            BeginContext(720, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 747, "\"", 767, 1);
#line 23 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
WriteAttributeValue("", 755, cuisineType, 755, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(768, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(770, 11, false);
#line 23 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
                                            Write(cuisineType);

#line default
#line hidden
            EndContext();
            BeginContext(781, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 24 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
                }

#line default
#line hidden
            BeginContext(811, 105, true);
            WriteLiteral("            </select>\r\n        </div>\r\n        <input type=\"Submit\" name=\"save\" value=\"Save\" />\r\n        ");
            EndContext();
            BeginContext(917, 23, false);
#line 28 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(940, 41, true);
            WriteLiteral("\r\n    </form>\r\n</div>\r\n\r\n<br />\r\n<button>");
            EndContext();
            BeginContext(982, 40, false);
#line 33 "C:\Users\lukeg\Documents\Visual Studio 2017\Projects\ChillAndGrill\ChillAndGrill\Views\Home\Update.cshtml"
   Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 9, true);
            WriteLiteral("</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChillAndGrill.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591