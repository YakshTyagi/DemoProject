#pragma checksum "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ce194a0c2db6498817c7db8dc419d9ad14c6c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_LoginUser), @"mvc.1.0.view", @"/Views/Register/LoginUser.cshtml")]
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
#line 1 "E:\.net\final project1\FrontendEcom\Views\_ViewImports.cshtml"
using FrontendEcom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net\final project1\FrontendEcom\Views\_ViewImports.cshtml"
using FrontendEcom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0ce194a0c2db6498817c7db8dc419d9ad14c6c3", @"/Views/Register/LoginUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48505ce7ca7b7b8858810a88e2e7b99baad124c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_LoginUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrontendEcom.Models.LoginData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/LoginUser.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
  
                
     ViewBag.Title = "LogIn";
    
       

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      <h2>LogIn</h2>\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0ce194a0c2db6498817c7db8dc419d9ad14c6c34216", async() => {
                WriteLiteral("\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0ce194a0c2db6498817c7db8dc419d9ad14c6c34478", async() => {
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
                WriteLiteral("\n      ");
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
            WriteLiteral("\n<div class=\"row justify-content-md-center\">\n");
#nullable restore
#line 14 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
Write(Html.ValidationSummary(true, "Login Failed, check details"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
                                                            ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <fieldset>\n        <div class=\"editor-label\">");
#nullable restore
#line 19 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
                             Write(Html.LabelFor(u => u.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"editor-field\">\n            ");
#nullable restore
#line 21 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
       Write(Html.TextBoxFor(u => u.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 22 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
       Write(Html.ValidationMessageFor(u => u.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"editor-label\">");
#nullable restore
#line 24 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
                             Write(Html.LabelFor(u => u.Upassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"editor-field\">\n            ");
#nullable restore
#line 26 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
       Write(Html.PasswordFor(u => u.Upassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 27 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
       Write(Html.ValidationMessageFor(u => u.Upassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div> <br />\n        <input type=\"submit\" value=\"Log In\" />\n    </fieldset>\n\n        <p>\n            ");
#nullable restore
#line 33 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
       Write(Html.ActionLink("Create New Account?", "RegisterUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n\n    </div>");
#nullable restore
#line 36 "E:\.net\final project1\FrontendEcom\Views\Register\LoginUser.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontendEcom.Models.LoginData> Html { get; private set; }
    }
}
#pragma warning restore 1591
