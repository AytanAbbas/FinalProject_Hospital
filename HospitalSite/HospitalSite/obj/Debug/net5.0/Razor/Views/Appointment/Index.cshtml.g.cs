#pragma checksum "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Appointment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d746f6cff91dc309c7f95b8458dfa586194f338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_Index), @"mvc.1.0.view", @"/Views/Appointment/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\_ViewImports.cshtml"
using HospitalSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\_ViewImports.cshtml"
using HospitalSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\_ViewImports.cshtml"
using HospitalSite.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\_ViewImports.cshtml"
using HospitalSite.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d746f6cff91dc309c7f95b8458dfa586194f338", @"/Views/Appointment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bccd3439c9c4bff7c80845d1468a499fb8cbfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-form appointment_form clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Appointment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"appointment\">\r\n    <h3>Keep in touch!</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d746f6cff91dc309c7f95b8458dfa586194f3385083", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-4"">
                <label class=""form-group"">
                    <span class=""text-input"">
                        <i class=""fa fa-user"" aria-hidden=""true""></i>
                        <input name=""name"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 517, "\"", 525, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Your Name"" required=""required"">
                    </span>
                </label>
            </div>
            <div class=""col-md-4"">
                <label class=""form-group"">
                    <span class=""text-input"">
                        <i class=""fa fa-phone"" aria-hidden=""true""></i>
                        <input name=""phone"" type=""tel""");
                BeginWriteAttribute("value", " value=\"", 901, "\"", 909, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Phone Number"" required=""required"">
                    </span>
                </label>
            </div>
            <div class=""col-md-4"">
                <label class=""form-group"">
                    <span class=""text-input"">
                        <i class=""fa fa-envelope"" aria-hidden=""true""></i>
                        <input name=""email"" type=""email""");
                BeginWriteAttribute("value", " value=\"", 1293, "\"", 1301, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email"">
                    </span>
                </label>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group date"">
                    <span class=""text-input"">
                        <i class=""fa fa-calendar""></i>
                        <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 1628, "\"", 1636, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""datetimepicker1"">
                    </span>
                </div>
            </div>
            <div class=""col-md-4"">
                <label class=""form-group"">
                    <span class=""text-input"">
                        <i class=""fa fa-pencil"" aria-hidden=""true""></i>
                        <input name=""Note"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1988, "\"", 1996, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Note"">
                    </span>
                </label>
            </div>
            <div class=""col-md-4"">
                <button class=""submit ttm-btn ttm-btn-size-md ttm-btn-shape-rounded ttm-btn-style-fill ttm-btn-color-skincolor"" type=""submit"">Book appointment</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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