#pragma checksum "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9647fae14db89fe412dd0c6c17c6a025a649febc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Message_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Message/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9647fae14db89fe412dd0c6c17c6a025a649febc", @"/Areas/admin/Views/Message/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5523b647e6edabe7cac4b660f9e9633431e2c56", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactUs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-3 btn-sm btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <div class=""body d-flex py-lg-3 py-md-2"">
            <div class=""container-xxl"">
                <div class=""row align-items-center"">
                    <div class=""border-0 mb-4"">
                        <div class=""card-header py-3 no-bg bg-transparent d-flex align-items-center px-0 justify-content-between border-bottom flex-wrap"">
                            <h3 class=""fw-bold py-3 mb-0"">Message</h3>
                            <div class=""d-flex py-2 project-tab flex-wrap w-sm-100"">
                                <ul class=""nav nav-tabs tab-body-header rounded ms-3 prtab-set w-sm-100"" role=""tablist"">
                                    <li class=""nav-item""><a class=""nav-link active"" data-bs-toggle=""tab"" href=""#list-view"" role=""tab"">List Messages</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div> <!-- Row end  -->
                <div class=""tab-content"">
                   ");
            WriteLiteral(" <div class=\"tab-pane fade show active\" id=\"list-view\">\r\n                        <div class=\"row clearfix g-3\">\r\n\r\n");
#nullable restore
#line 25 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                              
                                if (TempData["MessageError"] != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p style=\"font-size: 20px !important;\" class=\"alert alert-danger\">");
#nullable restore
#line 28 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                 Write(TempData["MessageError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"

                                    TempData["MessageError"] = null;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-8"" style=""width:100%"">
                                <div class=""card mb-3"">
                                    <div class=""card-body"">
                                        <table id=""myProjectTable"" class=""table table-hover align-middle mb-0"" style=""width:100%"">
                                            <thead>
                                                <tr>
                                                    <th> Name</th>
                                                    <th>Email</th>
                                                    <th>Phone</th>
                                                    <th>Subject</th>
                                                    <th>Message</th>
                                                    <th>CreatedDate</th>
                                                    <th>Edit</th>
                                                </tr>
                                            </thead>
  ");
            WriteLiteral("                                          <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                  
                                                    int counter2 = 0;
                                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                        foreach (var item in Model)
                                                        {
                                                        counter2++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                             <tr>\r\n\r\n                                                                 <td>\r\n                                                                   <span class=\"fw-bold ms-1\">");
#nullable restore
#line 57 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                 </td>\r\n                                                                  <td>");
#nullable restore
#line 59 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                 Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                  <td>");
#nullable restore
#line 60 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                 Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                  <td>");
#nullable restore
#line 61 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                 Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                  <td>");
#nullable restore
#line 62 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                  Write(item.Message.Length>50? item.Message.Substring(0,50)+"...": item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                  <td>\r\n");
#nullable restore
#line 64 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                        
                                                                          var date = (DateTime.Now - item.CreatedDate);
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
#line 72 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                  Write(date.Seconds);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                  Write(" seconds before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                                          
                                                                                  }
                                                                                  else
                                                                                  {
                                                                                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                  Write(date.Minutes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                  Write(" minutes before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                                          
                                                                                  }
                                                                              }
                                                                              else
                                                                              {
                                                                                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                              Write(date.Hours);

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                            Write(" hours before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                                  
                                                                              }
                                                                          }
                                                                          else
                                                                          {
                                                                              

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                          Write(date.Days);

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                       Write(" days before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                            
                                                                          }
                                                                      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                  </td>

                                                                  <td>
                                                                      <div class=""btn-group"" role=""group"" aria-label=""Basic outlined example"">
                                                                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9647fae14db89fe412dd0c6c17c6a025a649febc19344", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"
                                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                                      </div>\r\n                                                                  </td>\r\n                                                             </tr>\r\n");
#nullable restore
#line 97 "C:\Users\HP\Desktop\FinalProject-Hospital\HospitalSite\HospitalSite\Areas\admin\Views\Message\Index.cshtml"

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div><!-- Row End -->
                    </div>
                 
                </div>
            </div>
        </div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
