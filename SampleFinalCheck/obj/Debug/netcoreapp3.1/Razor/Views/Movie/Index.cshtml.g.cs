#pragma checksum "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13cd8a5e5b5d0c9c5f022359c8af2750a454b0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\_ViewImports.cshtml"
using SampleFinalCheck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\_ViewImports.cshtml"
using SampleFinalCheck.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13cd8a5e5b5d0c9c5f022359c8af2750a454b0d", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da29f66a80eee96894401f4942b1a8dbb6717578", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleFinalCheck.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"justify-content-center d-flex\">\r\n        <h1>Movies</h1>\r\n    </div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\user\source\repos\SampleFinalCheck\SampleFinalCheck\Views\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleFinalCheck.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
