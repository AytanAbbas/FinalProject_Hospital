#pragma checksum "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b5b0d7671e8cfda183aa18b69fabd676615b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Message_Read), @"mvc.1.0.view", @"/Areas/admin/Views/Message/Read.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b5b0d7671e8cfda183aa18b69fabd676615b4e", @"/Areas/admin/Views/Message/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5523b647e6edabe7cac4b660f9e9633431e2c56", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Message_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactUs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
  
    ViewData["Title"] = "Read";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""alert col-lg-10 my-5"" style=""background-color: #f5f5f58f !important; border-radius: 20px !important;"">
            <div class=""align-items-center d-flex flex-lg-row justify-content-between"">
                <h2 class=""m-0"">  ");
#nullable restore
#line 11 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <span style=\"font-size: 15px !important; color: #E39 !important;\">\r\n");
#nullable restore
#line 13 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                      
                        var date = (DateTime.Now - Model.CreatedDate);
                        if (date.Days == 0)
                        {
                            if (date.Hours == 0)
                            {
                                if (date.Minutes == 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                Write(date.Seconds);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                Write(" seconds before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                                        
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                Write(date.Minutes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                Write(" minutes before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                                        
                                }
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                            Write(date.Hours);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                          Write(" hours before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                                
                            }
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                        Write(date.Days);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                     Write(" days before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                          
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n            </div>\r\n            <span class=\"text-facebook\">");
#nullable restore
#line 40 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h6 class=\"mt-3 text-lg-center\" style=\"font-size: 22px !important; color: darkblue !important;\"> ");
#nullable restore
#line 41 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                                                                        Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n            <p class=\"m-0 alert alert-link text-center\" style=\"font-size: 18px !important;font-weight: 600 !important;font-style: italic !important;color: steelblue !important;\"> ");
#nullable restore
#line 42 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Read.cshtml"
                                                                                                                                                                              Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactUs> Html { get; private set; }
    }
}
#pragma warning restore 1591