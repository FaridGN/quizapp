#pragma checksum "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f80bc8cc1850ef5c950947a8a9bf8c261dd53ca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Proceed), @"mvc.1.0.view", @"/Views/Account/Proceed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Proceed.cshtml", typeof(AspNetCore.Views_Account_Proceed))]
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
#line 1 "C:\Users\User\source\repos\Intellect\Intellect\Views\_ViewImports.cshtml"
using Intellect;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\Intellect\Intellect\Views\_ViewImports.cshtml"
using Intellect.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f80bc8cc1850ef5c950947a8a9bf8c261dd53ca1", @"/Views/Account/Proceed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f2054f996152a9fc936570a4fd2765fb28c5cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Proceed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Intellect.Models.TestTaker>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
  
    Layout = "AdminLayout";

#line default
#line hidden
            BeginContext(73, 330, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-4"">
   <h5>Məlumatların düzgünlüyünə əminsinizsə, Davam et düyməsini basın</h5>
        </div>
        <div class=""col-lg-4"">
            <div class=""profile"">
                <label class=""mydetail"" style=""width:105px;"">Ad/Soyad:</label><h5>");
            EndContext();
            BeginContext(404, 10, false);
#line 14 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
                                                                             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(414, 93, true);
            WriteLiteral("</h5>\r\n                <label class=\"mydetail\" style=\"width:105px;\">Doğum tarixi:</label><h5>");
            EndContext();
            BeginContext(508, 34, false);
#line 15 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
                                                                                 Write(Model.Birth.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(542, 87, true);
            WriteLiteral("</h5>\r\n                <label class=\"mydetail\" style=\"width:105px;\">Təhsil:</label><h5>");
            EndContext();
            BeginContext(630, 15, false);
#line 16 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
                                                                           Write(Model.Education);

#line default
#line hidden
            EndContext();
            BeginContext(645, 86, true);
            WriteLiteral("</h5>\r\n                <label class=\"mydetail\" style=\"width:105px;\">Peşə:</label><h5> ");
            EndContext();
            BeginContext(732, 9, false);
#line 17 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
                                                                          Write(Model.Job);

#line default
#line hidden
            EndContext();
            BeginContext(741, 88, true);
            WriteLiteral("</h5>\r\n                <label class=\"mydetail\" style=\"width:105px;\">Telefon:</label><h5>");
            EndContext();
            BeginContext(830, 11, false);
#line 18 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
                                                                            Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(841, 31, true);
            WriteLiteral("</h5>\r\n                <button>");
            EndContext();
            BeginContext(872, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82a06fc17abe4e928485b52689e80d65", async() => {
                BeginContext(951, 8, true);
                WriteLiteral("Davam et");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\User\source\repos\Intellect\Intellect\Views\Account\Proceed.cshtml"
                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(963, 115, true);
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-4\">\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Intellect.Models.TestTaker> Html { get; private set; }
    }
}
#pragma warning restore 1591
