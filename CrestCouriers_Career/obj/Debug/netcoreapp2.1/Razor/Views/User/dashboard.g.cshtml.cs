#pragma checksum "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36f925d30ce1c60f2e74a9f7214657345c9a94f0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f925d30ce1c60f2e74a9f7214657345c9a94f0", @"/Views/User/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f0e0bc3062d43907324b8a6cb008b8ff3cd964a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrestCouriers_Career.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu-option-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/System/remove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: transparent; border: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/System/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:transparent; border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_System.cshtml";

#line default
#line hidden
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("UserMenu", async() => {
                BeginContext(169, 36, true);
                WriteLiteral("\r\n    <ul class=\"menu-ul\">\r\n        ");
                EndContext();
                BeginContext(205, 199, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3cf1a16fc94e228252a38f8f79abe5", async() => {
                    BeginContext(278, 122, true);
                    WriteLiteral("\r\n            <div class=\"panel-option-active\">\r\n                <li><h5>Dashboard</h5></li>\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(404, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(414, 184, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9bae59f26e4d41b6d06193d3f55ed1", async() => {
                    BeginContext(483, 111, true);
                    WriteLiteral("\r\n            <div class=\"panel-option\">\r\n                <li><h5>Order</h5></li>\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(598, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(608, 182, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dbbb7056f014f98a6b9732ca698915a", async() => {
                    BeginContext(676, 110, true);
                    WriteLiteral("\r\n            <div class=\"panel-option\">\r\n                <li><h5>User</h5></li>\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(790, 13, true);
                WriteLiteral("\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(806, 1243, true);
            WriteLiteral(@"
<div class=""list-title"">
    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            Order date
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            Origin
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            Destination
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            ReceiveDate
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            DeliveryDate
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            CarType
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
            Userid
        </h5>
    </div>

    <div class=""list-title-item"">
        <h5 class=""list-title-item-text"">
        ");
            WriteLiteral("    Price\r\n        </h5>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <h5 class=\"list-title-item-text\">\r\n            State\r\n        </h5>\r\n    </div>\r\n</div>\r\n\r\n<hr style=\"width:90%; border-color:red;\">\r\n\r\n");
            EndContext();
#line 86 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
 foreach (var item in Model)
{
    using (Html.BeginForm("Delete", "User", new { id = item.Orderid }))
    {

#line default
#line hidden
            BeginContext(2162, 120, true);
            WriteLiteral("        <div class=\"list-order\">\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(2283, 44, false);
#line 94 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(2458, 41, false);
#line 100 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(2499, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(2630, 46, false);
#line 106 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(2807, 46, false);
#line 112 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReceiveDate));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(2984, 47, false);
#line 118 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(3031, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(3162, 42, false);
#line 124 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.CarType));

#line default
#line hidden
            EndContext();
            BeginContext(3204, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(3335, 41, false);
#line 130 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(3376, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(3507, 40, false);
#line 136 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3547, 130, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"list-title-item\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(3678, 40, false);
#line 142 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
               Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 48, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(3836, 62, true);
            WriteLiteral("            <div class=\"list-record-button\">\r\n                ");
            EndContext();
            BeginContext(3898, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5360bb706b7486b896412a4eff020e3", async() => {
                BeginContext(4044, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8866312a8ae64597bddbf8addbf03824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                                                                                                                                       WriteLiteral(item.Orderid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4122, 113, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"list-record-button\" data-toggle=\"modal\" data-target=\".confirmbox\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4235, "\"", 4363, 13);
            WriteAttributeValue("", 4245, "getValues(\'", 4245, 11, true);
#line 152 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4256, item.Orderid, 4256, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4269, "\',\'", 4269, 3, true);
#line 152 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4272, item.Origin, 4272, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4284, "\',\'", 4284, 3, true);
#line 152 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4287, item.Destination, 4287, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 4304, "\',\'", 4304, 3, true);
#line 152 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4307, item.ReceiveDate, 4307, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 4324, "\',\'", 4324, 3, true);
#line 152 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4327, item.DeliveryDate, 4327, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 4345, "\',\'", 4345, 3, true);
#line 152 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4348, item.CarType, 4348, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4361, "\')", 4361, 2, true);
            EndWriteAttribute();
            BeginContext(4364, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(4383, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6829130e4fed41e096b7bbef632ba4f9", async() => {
                BeginContext(4511, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4533, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc1544b1ef764678b7f4f8b155a812b4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4600, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 153 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                                                                  WriteLiteral(item.Orderid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4627, 40, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
            BeginContext(4671, 2056, true);
            WriteLiteral(@"        <div id=""confirmbox-delete"" class=""modal fade confirmbox-delete"">
            <div class=""modal-dialog"">
                <div class=""modal-content"" style=""        width: 600px;
        padding: 0px;
"">

                    <div class=""modal-header"" style=""border-bottom-color:red;"">
                        <h2 class=""update-box-header"">Delete order</h2>
                    </div>

                    <div class=""modal-body"">




                        <div class=""popup-admin-deactive"">

                            <div class=""NewOrder-form"">

                                <div class=""row"">

                                    <div class=""col-sm-12"">
                                        <div class=""order-input"">
                                            <p>Are you sure? You realy want to delete this order?</p>
                                        </div>
                                    </div>

                                </div>

                            ");
            WriteLiteral(@"    <div class=""row"">

                                    <div class=""col-sm-6"">
                                        <div class=""input-submit"">
                                            <button type=""submit"" class=""book-now-btn"" style=""color:white; padding-top:14px; float:right;"" name=""button""><h5>Delete</h5></button>
                                        </div>
                                    </div>

                                    <div class=""col-sm-6"">
                                        <div class=""input-submit"">
                                            <button type=""button"" class=""book-now-btn"" style=""color:white; padding-top:14px; float:left;"" name=""button""><h5>Cancel</h5></button>
                                        </div>
                                    </div>

                                </div>

                            </div>

                        </div>

                    </div>


                </div>
            </div>
        ");
            WriteLiteral("</div>\r\n");
            EndContext();
#line 295 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                    


    }
}

#line default
#line hidden
            BeginContext(11124, 444, true);
            WriteLiteral(@"
<script>
    function getValues(Orderid,Origin, Destination, ReceiveDate, DeliveryDate, CarType) {

        document.getElementById(""Origin"").value = Origin;
        document.getElementById(""Destination"").value = Destination;
        document.getElementById(""ReceiveDate"").value = ReceiveDate;
        document.getElementById(""DeliveryDate"").value = DeliveryDate;
        document.getElementById(""CarType"").value = CarType;

        ");
            EndContext();
            BeginContext(11569, 19, false);
#line 310 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
   Write(ViewData["Orderid"]);

#line default
#line hidden
            EndContext();
            BeginContext(11588, 33, true);
            WriteLiteral(" = Orderid;\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(11859, 2, true);
            WriteLiteral("\r\n");
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
