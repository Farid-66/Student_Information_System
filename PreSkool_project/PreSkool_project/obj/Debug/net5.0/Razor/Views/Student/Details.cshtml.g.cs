#pragma checksum "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d99c273d08b99390a8eea3d5973466fed3d74df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d99c273d08b99390a8eea3d5973466fed3d74df", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3afe996cee6003cd3de766477fa7edb07bf1de9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit_btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("srcset", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <main>
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12 page_title"">
                    <div>
                        <h2>Student Details</h2>
                        <p class=""d-none d-sm-block"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d99c273d08b99390a8eea3d5973466fed3d74df6324", async() => {
                WriteLiteral("Students");
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
            WriteLiteral(@" / Student Details </p>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card_body"">
                        <div id=""details"">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""details_header"">
                                        <h2>About</h2>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d99c273d08b99390a8eea3d5973466fed3d74df8218", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-12 col-md-3 image"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9d99c273d08b99390a8eea3d5973466fed3d74df11055", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1367, "~/Uploads/", 1367, 10, true);
#nullable restore
#line 34 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
AddHtmlAttributeValue("", 1377, Model.StudentImage, 1377, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-12 col-md-9 about\">\r\n                                    <p><b>Full Name :</b><span>");
#nullable restore
#line 37 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                                      Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                    <p><b>Parent Name :</b><span>");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                            Write(Model.FathersName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                                               Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                    <p><b>Mobile :</b><span>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                       Write(Model.MobilNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                    <p><b>Email :</b><span>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                      Write(Model.CustomUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                    <p><b>Gender :</b><span>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                       Write(Model.Gender.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                    <p><b>Date of Birth :</b><span>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                              Write(Model.DateOfBirth.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <address>
                                        <p><b>Present Address</b></p>
                                        <p>");
#nullable restore
#line 49 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                      Write(Model.PresentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p><b>Permanent Address</b></p>\r\n                                        <p>");
#nullable restore
#line 51 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                      Write(Model.PermanentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </address>\r\n\r\n                                    <div class=\"about\">\r\n                                        <p><b>Class :</b><span>");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                          Write(Model.Class.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                        <p><b>Joining Date :</b><span>");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                                 Write(Model.JoiningDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                        <p><b>Department :</b><span>");
#nullable restore
#line 57 "C:\Users\HP\Desktop\Final_Project\Back-end\Back_end\PreSkool_project\PreSkool_project\Views\Student\Details.cshtml"
                                                               Write(Model.Section.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
