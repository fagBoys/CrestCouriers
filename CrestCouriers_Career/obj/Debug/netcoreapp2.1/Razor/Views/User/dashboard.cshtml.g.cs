#pragma checksum "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc255a15a2976e6c3a264811911681557fc41bf6"
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
#line 6 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career;

#line default
#line hidden
#line 3 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
using CrestCouriers_Career.Models;

#line default
#line hidden
#line 2 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 8 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\_ViewImports.cshtml"
using CrestCouriers_Career.ViewModels.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc255a15a2976e6c3a264811911681557fc41bf6", @"/Views/User/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0b61efe94e64c8835198418e3a1ed250bb1328", @"/Views/_ViewImports.cshtml")]
    public class Views_User_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrestCouriers_Career.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu-option-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/System/remove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: transparent; border: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/System/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:transparent; border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_System.cshtml";

#line default
#line hidden
            BeginContext(309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("UserMenu", async() => {
                BeginContext(329, 36, true);
                WriteLiteral("\r\n    <ul class=\"menu-ul\">\r\n        ");
                EndContext();
                BeginContext(365, 199, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ceec79fe8044efbb447e35fb72a193a", async() => {
                    BeginContext(438, 122, true);
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
                BeginContext(564, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(574, 184, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11aab69e584a4ed5b8eb6721e8765d77", async() => {
                    BeginContext(643, 111, true);
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
                BeginContext(758, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(768, 193, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ddecb5a5cbf479495b864a0f5d86b7e", async() => {
                    BeginContext(847, 110, true);
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
                BeginContext(961, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(971, 186, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7ae24c849d64f9582948c68473b2ac6", async() => {
                    BeginContext(1041, 112, true);
                    WriteLiteral("\r\n            <div class=\"panel-option\">\r\n                <li><h5>Logout</h5></li>\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1157, 13, true);
                WriteLiteral("\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(1173, 1243, true);
            WriteLiteral(@"
<div class=""list-title"">
    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            Order date
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            Origin
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            Destination
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            ReceiveDate
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            DeliveryDate
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            CarType
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
            Userid
        </h6>
    </div>

    <div class=""list-title-item"">
        <h6 class=""list-title-item-text"">
        ");
            WriteLiteral("    Price\r\n        </h6>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <h6 class=\"list-title-item-text\">\r\n            State\r\n        </h6>\r\n    </div>\r\n</div>\r\n\r\n<hr style=\"width:90%; border-color:red;\">\r\n\r\n");
            EndContext();
#line 94 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
 foreach (var order in Model)
{

    foreach(var location in order.Locations)
    { 

        using (Html.BeginForm("Delete", "User", new { id = order.OrderId }))
        {

#line default
#line hidden
            BeginContext(2597, 136, true);
            WriteLiteral("            <div class=\"list-order\">\r\n\r\n                <div class=\"list-title-item\">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(2734, 45, false);
#line 106 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                   Write(Html.DisplayFor(modelItem => order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2779, 402, true);
            WriteLiteral(@"
                    </p>
                </div>

                <div class=""list-title-item"">
                    <p>

                    </p>
                </div>

                <div class=""list-title-item"">
                    <p>

                    </p>
                </div>

                <div class=""list-title-item"">
                    <p>
                        ");
            EndContext();
            BeginContext(3182, 50, false);
#line 124 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                   Write(Html.DisplayFor(modelItem => order.CollectionDate));

#line default
#line hidden
            EndContext();
            BeginContext(3232, 150, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n                <div class=\"list-title-item\">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(3383, 48, false);
#line 130 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                   Write(Html.DisplayFor(modelItem => order.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(3431, 150, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n                <div class=\"list-title-item\">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(3582, 43, false);
#line 136 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                   Write(Html.DisplayFor(modelItem => order.CarType));

#line default
#line hidden
            EndContext();
            BeginContext(3625, 126, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n                <div class=\"list-title-item\">\r\n                    <p>\r\n");
            EndContext();
#line 142 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {
                            

#line default
#line hidden
            BeginContext(3869, 29, false);
#line 144 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                       Write(UserManager.GetUserName(User));

#line default
#line hidden
            EndContext();
#line 144 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                                                          
                        }

#line default
#line hidden
            BeginContext(3927, 148, true);
            WriteLiteral("                    </p>\r\n                </div>\r\n\r\n                <div class=\"list-title-item\">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(4076, 41, false);
#line 151 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                   Write(Html.DisplayFor(modelItem => order.Price));

#line default
#line hidden
            EndContext();
            BeginContext(4117, 150, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n                <div class=\"list-title-item\">\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(4268, 41, false);
#line 157 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                   Write(Html.DisplayFor(modelItem => order.State));

#line default
#line hidden
            EndContext();
            BeginContext(4309, 56, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(4439, 70, true);
            WriteLiteral("                <div class=\"list-record-button\">\r\n                    ");
            EndContext();
            BeginContext(4509, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e5239758dec4b00812b2fa67648b8dd", async() => {
                BeginContext(4656, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6024267b7605450ba8ee10074a5551bc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 164 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                                                                                                                                           WriteLiteral(order.OrderId);

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
            BeginContext(4734, 121, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"list-record-button\" data-toggle=\"modal\" data-target=\".confirmbox\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4855, "\"", 4994, 18);
            WriteAttributeValue("", 4865, "getValues(\'", 4865, 11, true);
#line 167 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4876, order.OrderId, 4876, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4890, "\',", 4890, 2, true);
            WriteAttributeValue(" ", 4892, "\'", 4893, 2, true);
#line 167 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4894, location.Town, 4894, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4908, "\',", 4908, 2, true);
            WriteAttributeValue(" ", 4910, "\'", 4911, 2, true);
#line 167 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4912, location.Town, 4912, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4926, "\',", 4926, 2, true);
            WriteAttributeValue(" ", 4928, "\'", 4929, 2, true);
#line 167 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4930, order.CollectionDate, 4930, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4951, "\',", 4951, 2, true);
            WriteAttributeValue(" ", 4953, "\'", 4954, 2, true);
#line 167 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4955, order.DeliveryDate, 4955, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 4974, "\',", 4974, 2, true);
            WriteAttributeValue(" ", 4976, "\'", 4977, 2, true);
#line 167 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
WriteAttributeValue("", 4978, order.CarType, 4978, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4992, "\')", 4992, 2, true);
            EndWriteAttribute();
            BeginContext(4995, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(5018, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee9f93de3a04dbe97c6563d71ae4d8f", async() => {
                BeginContext(5147, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(5173, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca62fa7a0cad465c9ef00efb32434be6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5240, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 168 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                                                                      WriteLiteral(order.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5271, 48, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(5323, 2173, true);
            WriteLiteral(@"            <div id=""confirmbox-delete"" class=""modal fade confirmbox-delete"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"" style=""width: 600px; padding: 0px;"">

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

                             ");
            WriteLiteral(@"       </div>

                                    <div class=""row"">

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

                     ");
            WriteLiteral("       </div>\r\n\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 308 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
                        


            }

    }

}

#line default
#line hidden
            BeginContext(12160, 444, true);
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
            BeginContext(12605, 19, false);
#line 326 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\User\dashboard.cshtml"
   Write(ViewData["Orderid"]);

#line default
#line hidden
            EndContext();
            BeginContext(12624, 33, true);
            WriteLiteral(" = Orderid;\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(12895, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Account> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Account> SignInManager { get; private set; }
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
