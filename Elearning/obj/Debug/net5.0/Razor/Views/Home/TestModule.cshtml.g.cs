#pragma checksum "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06fb101bce69c0c69027ea936c7be28e4169bd71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestModule), @"mvc.1.0.view", @"/Views/Home/TestModule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06fb101bce69c0c69027ea936c7be28e4169bd71", @"/Views/Home/TestModule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef53120a21a0f02ed6f7b235f93cae41b1d0cfcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestModule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ELearning.Models.Test>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Mark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
      
    ViewData["Title"] = "Home Page";
    var i = 1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container mb-5\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06fb101bce69c0c69027ea936c7be28e4169bd714256", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                     foreach (Test j in Model)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p class=\"subject\">");
#nullable restore
#line 15 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .");
#nullable restore
#line 15 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                                      Write(j.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <input type=\"hidden\" name=\"marks.Id\" id=\"circle1\"");
                BeginWriteAttribute("value", " value=\"", 471, "\"", 484, 1);
#nullable restore
#line 16 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
WriteAttributeValue("", 479, j.Id, 479, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div>\r\n                        <label for=\"one\" class=\"box first\">\r\n                            <div class=\"course\">\r\n                                <input type=\"radio\" name=\"tests.AnswerA\" id=\"circle1\"");
                BeginWriteAttribute("value", " value=\"", 711, "\"", 729, 1);
#nullable restore
#line 20 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
WriteAttributeValue("", 719, j.AnswerA, 719, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <span class=\"fw-bold\">");
#nullable restore
#line 21 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                                                 Write(j.AnswerA);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            </div>
                        </label>
                        <br />
                        <label for=""two"" class=""box second"">
                            <div class=""course"">
                                <input type=""radio"" name=""tests.AnswerB"" id=""circle2""");
                BeginWriteAttribute("value", " value=\"", 1105, "\"", 1123, 1);
#nullable restore
#line 27 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
WriteAttributeValue("", 1113, j.AnswerB, 1113, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <span class=\"fw-bold\">");
#nullable restore
#line 28 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                                                 Write(j.AnswerB);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            </div>
                        </label>
                        <br />
                        <label for=""three"" class=""box third"">
                            <div class=""course"">
                                <input type=""radio"" name=""tests.AnswerC"" id=""circle3""");
                BeginWriteAttribute("value", " value=\"", 1500, "\"", 1518, 1);
#nullable restore
#line 34 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
WriteAttributeValue("", 1508, j.AnswerC, 1508, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <span class=\"fw-bold\">");
#nullable restore
#line 35 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                                                 Write(j.AnswerC);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            </div>
                        </label>
                        <br />
                        <label for=""four"" class=""box forth"">
                            <div class=""course"">
                                <input type=""radio"" name=""tests.AnswerD"" id=""circle4""");
                BeginWriteAttribute("value", " value=\"", 1894, "\"", 1912, 1);
#nullable restore
#line 41 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
WriteAttributeValue("", 1902, j.AnswerD, 1902, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <span class=\"fw-bold\">");
#nullable restore
#line 42 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                                                 Write(j.AnswerD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                        </label>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\KN\source\repos\VietLish\ELearning\Views\Home\TestModule.cshtml"
                    i++;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-danger\">Submit</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ELearning.Models.Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591