#pragma checksum "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7797f189030c792d6ebca68ddc013c1d4cc57bd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_SiteSetting_Index), @"mvc.1.0.view", @"/Areas/admin/Views/SiteSetting/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\_ViewImports.cshtml"
using HospitalSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\_ViewImports.cshtml"
using HospitalSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\_ViewImports.cshtml"
using HospitalSite.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\_ViewImports.cshtml"
using HospitalSite.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7797f189030c792d6ebca68ddc013c1d4cc57bd6", @"/Areas/admin/Views/SiteSetting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5523b647e6edabe7cac4b660f9e9633431e2c56", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_SiteSetting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important; height: 100% !important; object-fit: contain !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SiteSetting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px !important; margin-left: auto !important; margin-right: 20px !important; margin-bottom: 40px !important; font-size: 16px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"

<div class=""row mt-3"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title my-4"" style=""font-size: 30px !important; text-align: center !important;"">Settings</h5>
                <div class=""table-responsive"">
                    <table class=""table table-hover table-bordered"">
                        <thead>
                            <tr style=""text-align: center !important"">
                                <th scope=""col"">#</th>
                                <th scope=""col"">Logo</th>
                                <th scope=""col"">Footer Background</th>
                                <th scope=""col"">Signature</th>
                                <th scope=""col"">Phone1</th>
                                <th scope=""col"">Phone2</th>
                                <th scope=""col"">Email1</th>
                                <th scope=""col"">Email2</th>
                                <th scope=""col"">Address</t");
            WriteLiteral(@"h>
                                <th scope=""col"">Info</th>
                                <th scope=""col"">About</th>
                                <th scope=""col"">AboutImage</th>
                                <th scope=""col"">FounderName</th>
                                <th scope=""col"">FounderPosition</th>
                                <th scope=""col"">WorkHpurs</th>
                                <th scope=""col"">MapLink</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th class=""align-middle"" scope=""row"">1</th>
                                <td class=""align-middle"" style=""width: 150px !important; height: 150px !important;"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7797f189030c792d6ebca68ddc013c1d4cc57bd69085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2062, "~/img/logo/", 2062, 11, true);
#nullable restore
#line 42 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
AddHtmlAttributeValue("", 2073, Model.Logo, 2073, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\" style=\"width: 150px !important; height: 150px !important;\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7797f189030c792d6ebca68ddc013c1d4cc57bd610965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2403, "~/img/bg-image/", 2403, 15, true);
#nullable restore
#line 45 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
AddHtmlAttributeValue("", 2418, Model.FooterBgImage, 2418, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 47 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Signature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 48 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 49 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Phone2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 50 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Email1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 51 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Email2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td class=""align-middle"">
                                    <marquee behavior=""scroll"" direction=""up"" height=""135""
                                             scrollamount=""2"" scrolldelay=""10"" style=""width: 150px !important;"">
                                        ");
#nullable restore
#line 55 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </marquee>
                                </td>
                                <td class=""align-middle"">
                                    <marquee behavior=""scroll"" direction=""up"" height=""auto""
                                             scrollamount=""2"" scrolldelay=""10"">
                                        ");
#nullable restore
#line 61 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                   Write(Model.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </marquee>
                                </td>
                                <td class=""align-middle"">
                                    <marquee behavior=""scroll"" direction=""up"" height=""auto""
                                             scrollamount=""2"" scrolldelay=""10"">
                                        ");
#nullable restore
#line 67 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                   Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </marquee>\r\n                                </td>\r\n                                <td class=\"align-middle\" style=\"width: 150px !important; height: 150px !important;\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7797f189030c792d6ebca68ddc013c1d4cc57bd616688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4300, "~/img/bg-image/", 4300, 15, true);
#nullable restore
#line 71 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
AddHtmlAttributeValue("", 4315, Model.AboutImage, 4315, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 73 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Foundername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 74 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.Founderposition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 75 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.WorkHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 76 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\SiteSetting\Index.cshtml"
                                                    Write(Model.MapLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7797f189030c792d6ebca68ddc013c1d4cc57bd620062", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
