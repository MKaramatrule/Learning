#pragma checksum "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d271411a622fffbb4dbd362538253fd1d79c89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "D:\Karam\Pagination_ASP_Core5\Practice\Views\_ViewImports.cshtml"
using Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
using Practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d271411a622fffbb4dbd362538253fd1d79c89b", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd757ed8785d7859154d904007503f4f18d9d71", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderPagingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d271411a622fffbb4dbd362538253fd1d79c89b4616", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d271411a622fffbb4dbd362538253fd1d79c89b5675", async() => {
                WriteLiteral("\r\n    <h4>Orders</h4>\r\n    <hr />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d271411a622fffbb4dbd362538253fd1d79c89b5974", async() => {
                    WriteLiteral("\r\n        <table cellpadding=\"0\" cellspacing=\"0\">\r\n            <tr>\r\n                <th>OrderID</th>\r\n                <th>Name</th>\r\n                <th>Date</th>\r\n                <th>Total</th>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
             foreach (OrderModel Order in Model.Orders)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                   Write(Order.ID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                   Write(Order.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                   Write(Order.Date);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                   Write(Order.Total);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        </table>\r\n        <br />\r\n        <table cellpadding=\"0\" cellspacing=\"0\">\r\n            <tr>\r\n");
#nullable restore
#line 42 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                 for (int i = 1; i <= Model.PageCount; i++)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <td>\r\n");
#nullable restore
#line 45 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                         if (i != Model.CurrentPageIndex)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <a");
                    BeginWriteAttribute("href", " href=\"", 1230, "\"", 1263, 3);
                    WriteAttributeValue("", 1237, "javascript:PagerClick(", 1237, 22, true);
#nullable restore
#line 47 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
WriteAttributeValue("", 1259, i, 1259, 2, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 1261, ");", 1261, 2, true);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 47 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                                                            Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n");
#nullable restore
#line 48 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <span>");
#nullable restore
#line 51 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                             Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n");
#nullable restore
#line 52 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </td>\r\n");
#nullable restore
#line 54 "D:\Karam\Pagination_ASP_Core5\Practice\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            </tr>\r\n        </table>\r\n        <input type=\"hidden\" id=\"hfCurrentPageIndex\" name=\"currentPageIndex\" />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function PagerClick(index) {\r\n            document.getElementById(\"hfCurrentPageIndex\").value = index;\r\n            document.forms[0].submit();\r\n        }\r\n    </script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderPagingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
