#pragma checksum "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1e0924015c6d40d1c1024c3c9b36ef7d2d3af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Booking), @"mvc.1.0.view", @"/Views/Booking/Booking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Booking.cshtml", typeof(AspNetCore.Views_Booking_Booking))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1e0924015c6d40d1c1024c3c9b36ef7d2d3af7", @"/Views/Booking/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73552b94f159943c3a8e2140dd470d33433f3fc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
  
    ViewData["Title"] = "Booking";

#line default
#line hidden
            BeginContext(65, 324, true);
            WriteLiteral(@"
<h2>Booking</h2>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Barber</th>
            <th scope=""col"">Time</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
          int i = 0; 

#line default
#line hidden
            BeginContext(413, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
         foreach (var item in Model)
        {
            i++;

#line default
#line hidden
            BeginContext(482, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(533, 1, false);
#line 25 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(534, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(562, 16, false);
#line 26 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
               Write(item.Barber.Name);

#line default
#line hidden
            EndContext();
            BeginContext(578, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(606, 22, false);
#line 27 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
               Write(item.Status.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(628, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(656, 20, false);
#line 28 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
               Write(item.Time.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(676, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(703, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a58cd926e6664828a1b742f533ac560f", async() => {
                BeginContext(773, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(784, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Michail\Source\Repos\sancho-panso\barberShop\barberShopProject20201006\Views\Booking\Booking.cshtml"
        }

#line default
#line hidden
            BeginContext(821, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
