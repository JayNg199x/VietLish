#pragma checksum "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1ff469753a27576bd3c95f075c0a478bf169d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mark), @"mvc.1.0.view", @"/Views/Home/Mark.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1ff469753a27576bd3c95f075c0a478bf169d1", @"/Views/Home/Mark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef53120a21a0f02ed6f7b235f93cae41b1d0cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml"
 if (ViewBag.score < 8)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Mark: ");
#nullable restore
#line 9 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml"
         Write(ViewBag.score);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <b style =\"color:red\">Not Pass</b></h3>\r\n");
#nullable restore
#line 10 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml"
 if (ViewBag.score >= 8)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Mark: ");
#nullable restore
#line 14 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml"
         Write(ViewBag.score);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <b style =\"color:green\"> Passed</b></h3>\r\n");
#nullable restore
#line 15 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\Mark.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a class=\"btn btn-info\" href=\"/Home/EnrollLevel\">Return home</a>");
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
