#pragma checksum "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b0ce93819bef5065c3354c1e094a1278d4325e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Research_Index), @"mvc.1.0.view", @"/Views/Research/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b0ce93819bef5065c3354c1e094a1278d4325e", @"/Views/Research/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bccd3439c9c4bff7c80845d1468a499fb8cbfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Research_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmResearch>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Research", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main>\r\n\r\n \r\n\r\n    <div class=\"banner\"");
            BeginWriteAttribute("style", " style=\"", 147, "\"", 216, 4);
            WriteAttributeValue("", 155, "background-image:", 155, 17, true);
            WriteAttributeValue(" ", 172, "url(images/background/", 173, 23, true);
#nullable restore
#line 11 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
WriteAttributeValue("", 195, Model.Banner.Image, 195, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 214, ");", 214, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""banner-inner"">
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-12"">
                        <div class=""page-title-heading"">
                            <h2 class=""title"">");
#nullable restore
#line 17 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                                         Write(Model.Banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        </div>
                        <div class=""breadcrumb-wrapper"">
                            <span>
                                <a title=""Homepage"" href=""index.html"">Home</a>
                            </span>
                            <span>");
#nullable restore
#line 23 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                             Write(Model.Banner.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <section class=\"research clearfix\">\r\n        <div class=\"container\">\r\n            <div class=\"row \">\r\n");
#nullable restore
#line 35 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                 foreach (var item in Model.Researches)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""wrapper col-lg-4 col-md-4 col-sm-6"">
                        <div class=""research-box"">
                            <div class=""research-overlay"">
                                <div class=""research-image"">
                                    <a  data-lightbox=""mygallery""> <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 1481, "\"", 1518, 2);
            WriteAttributeValue("", 1487, "images/research/", 1487, 16, true);
#nullable restore
#line 41 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
WriteAttributeValue("", 1503, item.MainImage, 1503, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""image""></a>
                                </div>
                              
                                <div class=""overlay-content"">
                                    <div class=""featured-content "">
                                        <div class=""featured-title"">
                                            <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90b0ce93819bef5065c3354c1e094a1278d4325e7943", async() => {
#nullable restore
#line 47 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                                                                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                                        </div>\r\n                                        <span class=\"category\">");
#nullable restore
#line 49 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                                                          Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 55 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Research\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmResearch> Html { get; private set; }
    }
}
#pragma warning restore 1591