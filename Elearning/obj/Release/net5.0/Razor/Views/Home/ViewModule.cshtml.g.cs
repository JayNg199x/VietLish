#pragma checksum "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb01281880f67ac50ed6991fcda6c3c1c4eb707b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewModule), @"mvc.1.0.view", @"/Views/Home/ViewModule.cshtml")]
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
#line 1 "C:\Users\KN\source\repos\VietLish\ELearning\Views\_ViewImports.cshtml"
using ELearning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KN\source\repos\VietLish\ELearning\Views\_ViewImports.cshtml"
using ELearning.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb01281880f67ac50ed6991fcda6c3c1c4eb707b", @"/Views/Home/ViewModule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef53120a21a0f02ed6f7b235f93cae41b1d0cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewModule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ELearning.Models.Vocabulary>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .row-padding {
        display: inline-block;
        margin-top: 20px;
        border: 1px solid rgb(37, 150, 190);
        font-size: 20px;
        border-radius: 10px;
        width: 70%;
    }

    .column {
        float: left;
        width: 20%;
        padding: 10px;
        height: 200px;
        margin-left: 5%;
    }
</style>

<a");
            BeginWriteAttribute("href", " href=\"", 464, "\"", 505, 2);
            WriteAttributeValue("", 471, "/Home/TestModule/", 471, 17, true);
#nullable restore
#line 26 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
WriteAttributeValue("", 488, ViewBag.moduleId, 488, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">TEST</a>
<div class=""container"">
    

    <table class=""table"">
        <thead>
            <tr>
                <th>NO</th>
                <th>Word</th>
                <th>Image</th>
                <th>Pronunciation</th>
                <th>Meaning</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
             foreach (var j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"nr td-actions text-center\"></td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                   Write(j.Word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1065, "\"", 1079, 1);
#nullable restore
#line 47 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
WriteAttributeValue("", 1071, j.Image, 1071, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"120\"></td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                   Write(j.Pronunciation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                   Write(j.Meaning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 59 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
          
            int numberPage = (int)ViewBag.numberPage;
            int pageCurrent = ViewBag.pageCurrent;

            if (pageCurrent > 1)
            {
                int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1654, "\"", 1675, 2);
            WriteAttributeValue("", 1661, "?page=", 1661, 6, true);
#nullable restore
#line 67 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
WriteAttributeValue("", 1667, prePage, 1667, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                        <span class=\"sr-only\">Previous</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 72 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
            }

            int i;
            for (i = 1; i < numberPage + 1; i++)
            {
                if (i == pageCurrent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2107, "\"", 2122, 2);
            WriteAttributeValue("", 2114, "?page=", 2114, 6, true);
#nullable restore
#line 79 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
WriteAttributeValue("", 2120, i, 2120, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 80 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2256, 2);
            WriteAttributeValue("", 2248, "?page=", 2248, 6, true);
#nullable restore
#line 83 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
WriteAttributeValue("", 2254, i, 2254, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 84 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
                }
            }

            if (pageCurrent >= 1 && pageCurrent < numberPage)
            {
                int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2514, "\"", 2536, 2);
            WriteAttributeValue("", 2521, "?page=", 2521, 6, true);
#nullable restore
#line 91 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
WriteAttributeValue("", 2527, nextPage, 2527, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                        <span class=\"sr-only\">Next</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 96 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\ViewModule.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n<script type=\"text/javascript\">\r\n    var a = document.getElementsByClassName(\"nr\");\r\n    for (var i = 0; i < a.length; i++) {\r\n        a[i].innerHTML = (i + 1);\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ELearning.Models.Vocabulary>> Html { get; private set; }
    }
}
#pragma warning restore 1591