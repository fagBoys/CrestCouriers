#pragma checksum "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf1f41d7ed850a17d40bb53d6275ebbbed968efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard), @"mvc.1.0.view", @"/Views/Admin/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Dashboard.cshtml", typeof(AspNetCore.Views_Admin_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1f41d7ed850a17d40bb53d6275ebbbed968efe", @"/Views/Admin/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f0e0bc3062d43907324b8a6cb008b8ff3cd964a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrestCouriers_Career.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/System/remove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:transparent; border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/System/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_SystemAdmin.cshtml";

#line default
#line hidden
            BeginContext(154, 1243, true);
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
#line 66 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
 foreach (var item in Model)
{
    using (Html.BeginForm("Delete", "User", new { id = item.Orderid }))
    {


#line default
#line hidden
            BeginContext(1512, 88, true);
            WriteLiteral("<div class=\"list-order\">\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1601, 44, false);
#line 75 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1736, 41, false);
#line 81 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1868, 46, false);
#line 87 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1914, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(2005, 46, false);
#line 93 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.ReceiveDate));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(2142, 47, false);
#line 99 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(2280, 42, false);
#line 105 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.CarType));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(2413, 41, false);
#line 111 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(2545, 40, false);
#line 117 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2585, 90, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"list-title-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(2676, 40, false);
#line 123 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
       Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(2716, 30, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(2808, 46, true);
            WriteLiteral("    <div class=\"list-record-button\">\r\n        ");
            EndContext();
            BeginContext(2854, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a2769adeac48d29fad47db32c17b41", async() => {
                BeginContext(2999, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f7343e7f2d734276b5c2ab884add291b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 129 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
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
            BeginContext(3077, 97, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"list-record-button\" data-toggle=\"modal\" data-target=\".confirmbox\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3174, "\"", 3302, 13);
            WriteAttributeValue("", 3184, "getValues(\'", 3184, 11, true);
#line 132 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
WriteAttributeValue("", 3195, item.Orderid, 3195, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3208, "\',\'", 3208, 3, true);
#line 132 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
WriteAttributeValue("", 3211, item.Origin, 3211, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 3223, "\',\'", 3223, 3, true);
#line 132 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
WriteAttributeValue("", 3226, item.Destination, 3226, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 3243, "\',\'", 3243, 3, true);
#line 132 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
WriteAttributeValue("", 3246, item.ReceiveDate, 3246, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 3263, "\',\'", 3263, 3, true);
#line 132 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
WriteAttributeValue("", 3266, item.DeliveryDate, 3266, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3284, "\',\'", 3284, 3, true);
#line 132 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
WriteAttributeValue("", 3287, item.CarType, 3287, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3300, "\')", 3300, 2, true);
            EndWriteAttribute();
            BeginContext(3303, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(3314, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc69be36a80d4c5daef19548d94f2804", async() => {
                BeginContext(3443, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3457, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7206745c62c4380a5c60182037f97af", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3524, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 133 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"
                                                           WriteLiteral(item.Orderid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3543, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
#line 139 "C:\Users\suzan\Documents\GitHub\MainProject\CrestCouriers_Career\Views\Admin\Dashboard.cshtml"

    }
}

#line default
#line hidden
            BeginContext(3579, 2039, true);
            WriteLiteral(@"
        <div id=""confirmbox-delete"" class=""modal fade confirmbox-delete"">
            <div class=""modal-dialog"">
                <div class=""modal-content"" style=""width:600px; padding:0px;"">

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

                                <div class=""row");
            WriteLiteral(@""">

                                    <div class=""col-sm-6"">
                                        <div class=""input-submit"">
                                            <button type=""button"" class=""book-now-btn"" style=""color:white; padding-top:14px; float:right;"" name=""button""><h5>Delete</h5></button>
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
        </div>

");
            EndContext();
            BeginContext(9684, 452, true);
            WriteLiteral(@"

<script>
    function getValues(Origin, Destination, ReceiveDate, DeliveryDate, CarType) {

        document.getElementById(""Origin"").value = Origin;
        document.getElementById(""Destination"").value = Destination;
        document.getElementById(""ReceiveDate"").value = ReceiveDate;
        document.getElementById(""DeliveryDate"").value = DeliveryDate;
        document.getElementById(""CarType"").value = CarType;

    }
</script>


");
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