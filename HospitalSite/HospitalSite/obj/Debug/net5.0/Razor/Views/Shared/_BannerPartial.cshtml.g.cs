#pragma checksum "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Shared\_BannerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b81265775dbe58b943e1e9b5ae16eb3e252073f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BannerPartial), @"mvc.1.0.view", @"/Views/Shared/_BannerPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b81265775dbe58b943e1e9b5ae16eb3e252073f", @"/Views/Shared/_BannerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bccd3439c9c4bff7c80845d1468a499fb8cbfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BannerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Banner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""banner"" style=""background-image: url(/images/background/about-bg.jpg);"">
    <div class=""banner-inner"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-12"">
                    <div class=""page-title-heading"">
                        <h2 class=""title"">");
#nullable restore
#line 10 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Shared\_BannerPartial.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"breadcrumb-wrapper\">\r\n                        <span>\r\n                            <a title=\"Homepage\" >Home</a>\r\n                        </span>\r\n                        <span>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Views\Shared\_BannerPartial.cshtml"
                         Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Banner> Html { get; private set; }
    }
}
#pragma warning restore 1591