#pragma checksum "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\Order\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4435d800f883ec0efe6a9bc179d5967688fa3824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Display), @"mvc.1.0.view", @"/Views/Order/Display.cshtml")]
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
#line 1 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\_ViewImports.cshtml"
using RestaurantApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\_ViewImports.cshtml"
using RestaurantApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4435d800f883ec0efe6a9bc179d5967688fa3824", @"/Views/Order/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8e57372de54ff26b173482358ab3fdcfb523b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RestaurantApplication.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/event.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>All Active Orders</h3>\r\n<br />\r\n\r\n<div class=\"card-deck\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\Order\Display.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4435d800f883ec0efe6a9bc179d5967688fa38244361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-header\">\r\n");
            WriteLiteral("                <h5>");
#nullable restore
#line 21 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\Order\Display.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>");
#nullable restore
#line 22 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\Order\Display.cshtml"
               Write(item.OrderPlaced);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5>");
#nullable restore
#line 23 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\Order\Display.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\hackathon\Desktop\DotNet\RestaurantApplication\RestaurantApplication\Views\Order\Display.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RestaurantApplication.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
