#pragma checksum "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ae12563e2fe8620514ffc09ed08e50a73a294bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DeliveryApp.Pages.myPages.Pages_myPages_Order), @"mvc.1.0.razor-page", @"/Pages/myPages/Order.cshtml")]
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
#nullable restore
#line 3 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ae12563e2fe8620514ffc09ed08e50a73a294bd", @"/Pages/myPages/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9e54ae7eb50dd595b3c97e770e69c878558aa5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_myPages_Order : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Orders</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ae12563e2fe8620514ffc09ed08e50a73a294bd3660", async() => {
                WriteLiteral("Create New Order");
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
                Order ID
            </th>
            <th>
                Expected Delivery Date
            </th>            
            <th>
                Delivery Address
            </th>
            <th>
                Vendor Details
            </th>            
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 32 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
         foreach (var order in Model.Orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.ExpectedDeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Address.OrderAddressId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                    ");
#nullable restore
#line 45 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Address.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 46 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Address.StreetHouse);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 47 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Address.PostCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Address.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    Phone/Mobil: ");
#nullable restore
#line 49 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
                            Write(order.Value.Address.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 54 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Vendor.VendorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 55 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Vendor.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 56 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
               Write(order.Value.Vendor.VendorAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    Phone/Mobil: ");
#nullable restore
#line 57 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
                            Write(order.Value.Vendor.VendorPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    Email : ");
#nullable restore
#line 58 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
                       Write(order.Value.Vendor.VendorEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                     \r\n                </td>                             \r\n            </tr>\r\n");
#nullable restore
#line 62 "D:\Assignments\Final Assignment 1st Semester\DeliveryApp\Pages\myPages\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryApp.Pages.myPages.OrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeliveryApp.Pages.myPages.OrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeliveryApp.Pages.myPages.OrderModel>)PageContext?.ViewData;
        public DeliveryApp.Pages.myPages.OrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591