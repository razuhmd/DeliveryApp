#pragma checksum "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f236e0f5c22c5b920572e00e8c95fc662c5d69ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DeliveryApp.Pages.myPages.Pages_myPages_Rute), @"mvc.1.0.razor-page", @"/Pages/myPages/Rute.cshtml")]
namespace DeliveryApp.Pages.myPages
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
#line 1 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\_ViewImports.cshtml"
using DeliveryApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f236e0f5c22c5b920572e00e8c95fc662c5d69ea", @"/Pages/myPages/Rute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9e54ae7eb50dd595b3c97e770e69c878558aa5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_myPages_Rute : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateRute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
  
    ViewData["Title"] = "Rute";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Rutes</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f236e0f5c22c5b920572e00e8c95fc662c5d69ea3459", async() => {
                WriteLiteral("Create New Rute");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Rute Number
            </th>
            <th>
                Employee ID
            </th>
            <th>
                Employee Name
            </th>
            <th>
                Employee Email
            </th>
            <th>
                Employee Address
            </th>
            <th>
                Employee Phone/Mobile
            </th>
            <th>
                Employee Type
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 40 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
         foreach (var rute in Model.Rutes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
           Write(rute.Value.RuteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 46 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
             if (rute.Value.Employee != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 49 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
               Write(rute.Value.Employee.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
               Write(rute.Value.Employee.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
               Write(rute.Value.Employee.EmployeeEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
               Write(rute.Value.Employee.EmployeeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
               Write(rute.Value.Employee.EmployeePhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
               Write(rute.Value.Employee.EmployeeType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 66 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    No Employee Assigned\r\n                </td>\r\n");
#nullable restore
#line 72 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 74 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Rute.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryApp.Pages.myPages.RuteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeliveryApp.Pages.myPages.RuteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeliveryApp.Pages.myPages.RuteModel>)PageContext?.ViewData;
        public DeliveryApp.Pages.myPages.RuteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591