#pragma checksum "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a91253b173f983727f1e81d7e30a539e6a3ac3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AccountManagement), @"mvc.1.0.view", @"/Views/Home/AccountManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a91253b173f983727f1e81d7e30a539e6a3ac3b", @"/Views/Home/AccountManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef53120a21a0f02ed6f7b235f93cae41b1d0cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AccountManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">NO</th>
                <th scope=""col"">FullName</th>
                <th scope=""col"">Gender</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">ContactNo</th>
                <th scope=""col"">UserName</th>
");
            WriteLiteral("                <th scope=\"col\">Status</th>\r\n                <th scope=\"col\">Action</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
             foreach (var j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"nr td-actions text-center\"></td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
               Write(j.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
                Write(j.Gender == true ? "Male" : "Female");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
               Write(j.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
               Write(j.ContactNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
               Write(j.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
                Write(j.Status == true ? "Active" : "Deactive");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1128, "\"", 1160, 2);
            WriteAttributeValue("", 1135, "/Home/UpdateAccount/", 1135, 20, true);
#nullable restore
#line 32 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
WriteAttributeValue("", 1155, j.Id, 1155, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update Status</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 41 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
          
            int numberPage = (int)ViewBag.numberPage;
            int pageCurrent = ViewBag.pageCurrent;

            if (pageCurrent > 1)
            {
                int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1625, "\"", 1646, 2);
            WriteAttributeValue("", 1632, "?page=", 1632, 6, true);
#nullable restore
#line 49 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
WriteAttributeValue("", 1638, prePage, 1638, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                    <span class=\"sr-only\">Previous</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 54 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
            }

            int i;
            for (i = 1; i < numberPage; i++)
            {
                if (i == pageCurrent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2050, "\"", 2065, 2);
            WriteAttributeValue("", 2057, "?page=", 2057, 6, true);
#nullable restore
#line 61 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
WriteAttributeValue("", 2063, i, 2063, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 62 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 2176, "\"", 2191, 2);
            WriteAttributeValue("", 2183, "?page=", 2183, 6, true);
#nullable restore
#line 65 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
WriteAttributeValue("", 2189, i, 2189, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 66 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
                }
            }

            if (pageCurrent >= 1 && pageCurrent < numberPage - 1)
            {
                int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2445, "\"", 2467, 2);
            WriteAttributeValue("", 2452, "?page=", 2452, 6, true);
#nullable restore
#line 73 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
WriteAttributeValue("", 2458, nextPage, 2458, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                    <span class=\"sr-only\">Next</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 78 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\AccountManagement.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n<script type=\"text/javascript\">\r\n    var a = document.getElementsByClassName(\"nr\");\r\n    for (var i = 0; i < a.length; i++) {\r\n        a[i].innerHTML = (i + 1);\r\n    }\r\n</script>");
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
