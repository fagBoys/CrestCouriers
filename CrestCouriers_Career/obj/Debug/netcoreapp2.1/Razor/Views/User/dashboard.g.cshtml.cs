#pragma checksum "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5230461d48a32298d68ec4a333103c696b74abbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_dashboard), @"mvc.1.0.view", @"/Views/User/dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/dashboard.cshtml", typeof(AspNetCore.Views_User_dashboard))]
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
#line 1 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career;

#line default
#line hidden
#line 2 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5230461d48a32298d68ec4a333103c696b74abbe", @"/Views/User/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"239b58ab97d61d684c6dc860a7f192aa130cc0d5", @"/Views/_ViewImports.cshtml")]
    public class Views_User_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrestCouriers_Career.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(104, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea1930fdec249bdaebe15516beb6ee5", async() => {
                BeginContext(110, 88, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>dashboard</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(206, 2290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a55215e5c1548a8aa29a0d3c1d10234", async() => {
                BeginContext(212, 9, true);
                WriteLiteral("\n<p>\n    ");
                EndContext();
                BeginContext(221, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d64f4b9027af402a8646d3d8ad337605", async() => {
                    BeginContext(244, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(258, 86, true);
                WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
                EndContext();
                BeginContext(345, 45, false);
#line 22 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
                EndContext();
                BeginContext(390, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(443, 42, false);
#line 25 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
                EndContext();
                BeginContext(485, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(538, 47, false);
#line 28 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
                EndContext();
                BeginContext(585, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(638, 47, false);
#line 31 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.ReceiveDate));

#line default
#line hidden
                EndContext();
                BeginContext(685, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(738, 48, false);
#line 34 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
                EndContext();
                BeginContext(786, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(839, 43, false);
#line 37 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.CarType));

#line default
#line hidden
                EndContext();
                BeginContext(882, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(935, 42, false);
#line 40 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
                EndContext();
                BeginContext(977, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(1030, 41, false);
#line 43 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1071, 52, true);
                WriteLiteral("\n            </th>\n            <th>\n                ");
                EndContext();
                BeginContext(1124, 41, false);
#line 46 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
                EndContext();
                BeginContext(1165, 80, true);
                WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
                EndContext();
#line 52 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(1276, 46, true);
                WriteLiteral("        <tr>\n            <td>\n                ");
                EndContext();
                BeginContext(1323, 44, false);
#line 55 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
                EndContext();
                BeginContext(1367, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(1420, 41, false);
#line 58 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.Origin));

#line default
#line hidden
                EndContext();
                BeginContext(1461, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(1514, 46, false);
#line 61 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
                EndContext();
                BeginContext(1560, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(1613, 46, false);
#line 64 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReceiveDate));

#line default
#line hidden
                EndContext();
                BeginContext(1659, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(1712, 47, false);
#line 67 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
                EndContext();
                BeginContext(1759, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(1812, 42, false);
#line 70 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.CarType));

#line default
#line hidden
                EndContext();
                BeginContext(1854, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(1907, 41, false);
#line 73 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
                EndContext();
                BeginContext(1948, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2001, 40, false);
#line 76 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2041, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2094, 40, false);
#line 79 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
                EndContext();
                BeginContext(2134, 52, true);
                WriteLiteral("\n            </td>\n            <td>\n                ");
                EndContext();
                BeginContext(2187, 65, false);
#line 82 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2252, 19, true);
                WriteLiteral(" |\n                ");
                EndContext();
                BeginContext(2272, 71, false);
#line 83 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2343, 19, true);
                WriteLiteral(" |\n                ");
                EndContext();
                BeginContext(2363, 69, false);
#line 84 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2432, 33, true);
                WriteLiteral("\n            </td>\n        </tr>\n");
                EndContext();
#line 87 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
}

#line default
#line hidden
                BeginContext(2467, 22, true);
                WriteLiteral("    </tbody>\n</table>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2496, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrestCouriers_Career.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
