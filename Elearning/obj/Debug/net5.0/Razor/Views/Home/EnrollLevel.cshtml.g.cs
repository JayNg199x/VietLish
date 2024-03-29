#pragma checksum "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66d7469388bc75a0782e3b10981d793da51e818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EnrollLevel), @"mvc.1.0.view", @"/Views/Home/EnrollLevel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66d7469388bc75a0782e3b10981d793da51e818", @"/Views/Home/EnrollLevel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef53120a21a0f02ed6f7b235f93cae41b1d0cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EnrollLevel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VietLish.DTO.ModuleDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
  
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


<div class=""container"">
");
            WriteLiteral(@"
    <table class=""table"">
        <thead>
            <tr>
                <th>NO</th>
                <th>Module</th>
                <th>Image</th>
                <th>Part</th>
                <th>Level</th>
                <th>Status</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
             foreach (var j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"nr td-actions text-center\"></td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                   Write(j.Module1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1171, "\"", 1185, 1);
#nullable restore
#line 50 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 1177, j.Image, 1177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"120\"></td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                   Write(j.Part);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                   Write(j.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 55 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                         if (j.Status == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-info\">Passed</button>\r\n");
#nullable restore
#line 58 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                        }
                        else if (j.Status == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-danger\">Not Pass</button>\r\n");
#nullable restore
#line 62 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                        }
                        else if (j.Status == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-warning\">Pending</button>\r\n");
#nullable restore
#line 66 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2094, "\"", 2123, 2);
            WriteAttributeValue("", 2101, "/Home/ViewModule/", 2101, 17, true);
#nullable restore
#line 68 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 2118, j.Id, 2118, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Start</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 70 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 77 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
          
            int numberPage = (int)ViewBag.numberPage;
            int pageCurrent = ViewBag.pageCurrent;

            if (pageCurrent > 1)
            {
                int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2616, "\"", 2637, 2);
            WriteAttributeValue("", 2623, "?page=", 2623, 6, true);
#nullable restore
#line 85 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 2629, prePage, 2629, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                        <span class=\"sr-only\">Previous</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 90 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
            }

            int i;
            for (i = 1; i < numberPage; i++)
            {
                if (i == pageCurrent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3065, "\"", 3080, 2);
            WriteAttributeValue("", 3072, "?page=", 3072, 6, true);
#nullable restore
#line 97 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 3078, i, 3078, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 98 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 3199, "\"", 3214, 2);
            WriteAttributeValue("", 3206, "?page=", 3206, 6, true);
#nullable restore
#line 101 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 3212, i, 3212, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 102 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
                }
            }

            if (pageCurrent >= 1 && pageCurrent < numberPage - 1)
            {
                int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3476, "\"", 3498, 2);
            WriteAttributeValue("", 3483, "?page=", 3483, 6, true);
#nullable restore
#line 109 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 3489, nextPage, 3489, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                        <span class=\"sr-only\">Next</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 114 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\EnrollLevel.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VietLish.DTO.ModuleDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
