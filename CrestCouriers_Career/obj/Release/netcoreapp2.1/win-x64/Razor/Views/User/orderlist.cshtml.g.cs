#pragma checksum "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4cc0204336074760ca75b1acfbb5580715d427f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_orderlist), @"mvc.1.0.view", @"/Views/User/orderlist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/orderlist.cshtml", typeof(AspNetCore.Views_User_orderlist))]
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
#line 6 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career;

#line default
#line hidden
#line 7 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career.Models;

#line default
#line hidden
#line 5 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 8 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career.ViewModels.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cc0204336074760ca75b1acfbb5580715d427f", @"/Views/User/orderlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0b61efe94e64c8835198418e3a1ed250bb1328", @"/Views/_ViewImports.cshtml")]
    public class Views_User_orderlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrestCouriers_Career.Models.Order>>
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
#line 2 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(82, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(111, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1dddd5ab3c34c04ab88c9ea15c1de3f", async() => {
                BeginContext(117, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>orderlist</title>\r\n");
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
            BeginContext(215, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(217, 2918, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d532e0bc7f24344a0a45877a29a5676", async() => {
                BeginContext(223, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(242, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9475e5ffdea9451dac30893bddf3ed67", async() => {
                    BeginContext(265, 10, true);
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
                BeginContext(279, 116, true);
                WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(396, 45, false);
#line 21 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
                EndContext();
                BeginContext(441, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(509, 45, false);
#line 24 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.Locations));

#line default
#line hidden
                EndContext();
                BeginContext(554, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(622, 45, false);
#line 27 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.Locations));

#line default
#line hidden
                EndContext();
                BeginContext(667, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(735, 50, false);
#line 30 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.CollectionDate));

#line default
#line hidden
                EndContext();
                BeginContext(785, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(853, 48, false);
#line 33 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
                EndContext();
                BeginContext(901, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(969, 43, false);
#line 36 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.CarType));

#line default
#line hidden
                EndContext();
                BeginContext(1012, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1080, 43, false);
#line 39 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
                EndContext();
                BeginContext(1123, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1191, 41, false);
#line 42 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1232, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1300, 41, false);
#line 45 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
               Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
                EndContext();
                BeginContext(1341, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 51 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1504, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1577, 44, false);
#line 55 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
                EndContext();
                BeginContext(1621, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1701, 80, false);
#line 58 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => @item.Locations.Where(T=>T.LocationType=="Origin")));

#line default
#line hidden
                EndContext();
                BeginContext(1781, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1861, 85, false);
#line 61 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => @item.Locations.Where(T=>T.LocationType=="Destination")));

#line default
#line hidden
                EndContext();
                BeginContext(1946, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2026, 49, false);
#line 64 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CollectionDate));

#line default
#line hidden
                EndContext();
                BeginContext(2075, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2155, 47, false);
#line 67 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
                EndContext();
                BeginContext(2202, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2282, 42, false);
#line 70 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CarType));

#line default
#line hidden
                EndContext();
                BeginContext(2324, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2404, 42, false);
#line 73 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
                EndContext();
                BeginContext(2446, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2526, 40, false);
#line 76 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2566, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2646, 40, false);
#line 79 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
                EndContext();
                BeginContext(2686, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2766, 65, false);
#line 82 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2831, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(2860, 71, false);
#line 83 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2931, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(2960, 69, false);
#line 84 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(3029, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 87 "C:\Users\Mohammad Javad\Documents\GitHub\CrestCouriers\CrestCouriers_Career\Views\User\orderlist.cshtml"
            }

#line default
#line hidden
                BeginContext(3096, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            BeginContext(3135, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
