#pragma checksum "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d1e65038a7e61c31991e0b5e6b3209c674bbf6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeacherDashboard_Events), @"mvc.1.0.view", @"/Views/TeacherDashboard/Events.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using PreSkool_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using PreSkool_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using PreSkool_project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d1e65038a7e61c31991e0b5e6b3209c674bbf6b", @"/Views/TeacherDashboard/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3afe996cee6003cd3de766477fa7edb07bf1de9", @"/Views/_ViewImports.cshtml")]
    public class Views_TeacherDashboard_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmTeacherDashboard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "teacherdashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
  
    ViewData["Title"] = "Events";
    Layout = "~/Views/Shared/_LayoutTeacher.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main>\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 page_title\">\r\n                    <div>\r\n                        <h2>Events</h2>\r\n                        <p class=\"d-none d-sm-block\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d1e65038a7e61c31991e0b5e6b3209c674bbf6b4878", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral(@" / Events</p>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card_body"">
                        <div class=""status"">
                            
                            <div class=""holiday"">
                                <p>Holiday </p>
                                <span></span>
                            </div>
                        </div>
                        <div class=""event"">
                            <div class=""row"">

");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                              
                                int i = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                             foreach (var item in Model.Holidays)
                               {
                                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-12 col-lg-3 col-md-6 col-sm-12\">\r\n                                    <a href=\"#\">");
#nullable restore
#line 37 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <div class=\"event-item\">\r\n                                        <div class=\"d-flex justify-content-between\">\r\n                                            <p><b>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                            <span style=\" background-color: green;\"></span>\r\n                                        </div>\r\n                                        <small>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                                          Write(item.HolidayType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        <p>");
#nullable restore
#line 44 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                                      Write(item.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 44 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                                                                             Write(item.EndDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 47 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\TeacherDashboard\Events.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmTeacherDashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591
