#pragma checksum "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86cf917e6e7b6f9ce2c0a05b9954230fac1891d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Book), @"mvc.1.0.view", @"/Views/Booking/Book.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Book.cshtml", typeof(AspNetCore.Views_Booking_Book))]
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
#line 2 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\_ViewImports.cshtml"
using barberShopProject20201006.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86cf917e6e7b6f9ce2c0a05b9954230fac1891d2", @"/Views/Booking/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73552b94f159943c3a8e2140dd470d33433f3fc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
  
    ViewData["Title"] = "Booking Details";

#line default
#line hidden
            BeginContext(106, 29, true);
            WriteLiteral("\r\n<p>Client\'s details</p>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
 foreach (Booking item in Model)
{
    if (item.Id == ViewBag.BookingID)
    {

#line default
#line hidden
            BeginContext(218, 26, true);
            WriteLiteral("        <p>Client\'s Name: ");
            EndContext();
            BeginContext(245, 16, false);
#line 18 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
                     Write(item.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(261, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(263, 19, false);
#line 18 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
                                       Write(item.Client.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(282, 40, true);
            WriteLiteral("</p>\r\n        <p>Client\'s Phone Number: ");
            EndContext();
            BeginContext(323, 17, false);
#line 19 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
                             Write(item.Client.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(340, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Book.cshtml"
    }
}

#line default
#line hidden
            BeginContext(356, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(358, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3590719fefaf4990936b095d7e777ce8", async() => {
                BeginContext(407, 22, true);
                WriteLiteral("Back to Booking\'s list");
                EndContext();
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
            EndContext();
            BeginContext(433, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
