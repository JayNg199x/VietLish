#pragma checksum "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "813da6a37819987f3af8cdfacaa6d2c8c75b1be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813da6a37819987f3af8cdfacaa6d2c8c75b1be7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef53120a21a0f02ed6f7b235f93cae41b1d0cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
  string? username = Accessor.HttpContext.Session.GetString("username");
    string? type = Accessor.HttpContext.Session.GetString("role");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "813da6a37819987f3af8cdfacaa6d2c8c75b1be74926", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 10 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - VIETLISH</title>\r\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\'>\r\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\'>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "813da6a37819987f3af8cdfacaa6d2c8c75b1be75791", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "813da6a37819987f3af8cdfacaa6d2c8c75b1be77674", async() => {
                WriteLiteral(@"
    <nav class=""mnb navbar navbar-default navbar-fixed-top"" style=""background-color: #f6f8fc;"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar""
                        aria-expanded=""false"" aria-controls=""navbar"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <i class=""ic fa fa-bars""></i>
                </button>
                <div style=""padding: 15px 0;"">
                    <a href=""#"" id=""msbo""><i class=""ic fa fa-bars""></i></a>
                </div>
            </div>
            <div id=""navbar"" class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""#"">En</a></li>
");
#nullable restore
#line 31 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                     if (username != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"dropdown\">\r\n                            <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\" role=\"button\" aria-haspopup=\"true\"\r\n                               aria-expanded=\"false\">");
#nullable restore
#line 35 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                                                Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<span class=""caret""></span></a>
                            <ul class=""dropdown-menu"">
                               
                                <li><a href=""/Home/Logout"">Logout</a></li>
                            </ul>
                        </li>
");
#nullable restore
#line 41 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                     if (username == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li><a href=\"/Home/Login\"><i class=\"fa fa-sign-in\"></i></a></li>\r\n");
#nullable restore
#line 45 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    
                </ul>
            </div>
        </div>
    </nav>

    <div class=""msb"" id=""msb"">
        <nav class=""navbar navbar-default"" role=""navigation"">
            <div class=""navbar-header"" style=""background-color: #f6f8fc;"">
                <div class=""brand-wrapper"">
                    <div class=""brand-name-wrapper"">
                        <a class=""navbar-brand"" href=""#"">
                            <img style=""margin-top: -10%;""
                                 src=""https://vietlish.edu.vn/wp-content/uploads/2021/07/VIETLISH-LOGO-FULL-COLOR-_-SLOGAN-Web.png""
                                 width=""150"" height=""50"">
                        </a>
                    </div>
                </div>
            </div>

            <div class=""side-menu-container"" style=""background-color: #f6f8fc;"">

");
#nullable restore
#line 68 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                 if (type == "2")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul class=\"nav navbar-nav\">\r\n\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3316, "\"", 3364, 1);
#nullable restore
#line 72 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3324, ViewBag.Active == "5" ? "active" : "", 3324, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/Index\"><i class=\"fa fa-dashboard\"></i>Home</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3461, "\"", 3509, 1);
#nullable restore
#line 73 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3469, ViewBag.Active == "6" ? "active" : "", 3469, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/ViewMark\"><i class=\"fa fa-puzzle-piece\"></i>Mark</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3612, "\"", 3660, 1);
#nullable restore
#line 74 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3620, ViewBag.Active == "7" ? "active" : "", 3620, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/SentenceStructure\"><i class=\"fa fa-building-o\"></i>Sentence Structure</a></li>\r\n\r\n                      \r\n                    </ul>\r\n");
#nullable restore
#line 78 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 81 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                 if (type == "1")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <ul class=\"nav navbar-nav\">\r\n\r\n                <li");
                BeginWriteAttribute("class", " class=\"", 3949, "\"", 3997, 1);
#nullable restore
#line 85 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3957, ViewBag.Active == "1" ? "active" : "", 3957, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/AccountManagement\"><i class=\"fa fa-dashboard\"></i>Account Management</a></li>\r\n                <li");
                BeginWriteAttribute("class", " class=\"", 4112, "\"", 4160, 1);
#nullable restore
#line 86 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4120, ViewBag.Active == "2" ? "active" : "", 4120, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/ModuleManagement\"><i class=\"fa fa-puzzle-piece\"></i>Module Management</a></li>\r\n                <li");
                BeginWriteAttribute("class", " class=\"", 4276, "\"", 4324, 1);
#nullable restore
#line 87 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4284, ViewBag.Active == "4" ? "active" : "", 4284, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/WordManagement\"><i class=\"fa fa-file-word-o\"></i>Word Management</a></li>\r\n                <li");
                BeginWriteAttribute("class", " class=\"", 4435, "\"", 4483, 1);
#nullable restore
#line 88 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4443, ViewBag.Active == "9" ? "active" : "", 4443, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/SentenceManagement\"><i class=\"fa fa-building-o\"></i>Sentence Structure</a></li>\r\n                <li");
                BeginWriteAttribute("class", " class=\"", 4600, "\"", 4648, 1);
#nullable restore
#line 89 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4608, ViewBag.Active == "3" ? "active" : "", 4608, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/QuizManagement\"><i class=\"fa fa-question\"></i>Test Management</a></li>\r\n\r\n\r\n\r\n            </ul>\r\n");
#nullable restore
#line 94 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </nav>
    </div>
    <div class=""mcw"">
        <div class=""cv"">
            <div>
                <div class=""inbox"">
                    <div class=""inbox-sb"">

                    </div>
                    <div class=""inbox-bx container-fluid"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""container"">
                                    <main role=""main"" class=""pb-3"">
                                        ");
#nullable restore
#line 111 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Shared\_Layout.cshtml"
                                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </main>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src='https://code.jquery.com/jquery-3.1.1.min.js'></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "813da6a37819987f3af8cdfacaa6d2c8c75b1be717825", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""></script>
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js'></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; }
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
