#pragma checksum "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9e5eb16ac320a65e6b34291ad8d13f63af83ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9e5eb16ac320a65e6b34291ad8d13f63af83ee4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobileShop.Entities.Phone>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Mobile phone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Search section -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9e5eb16ac320a65e6b34291ad8d13f63af83ee44525", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12 col-md-6 offset-3\">\r\n            <button class=\"btn searchIcon\"");
                BeginWriteAttribute("style", " style=\"", 220, "\"", 228, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <i class=\"fas fa-search\"></i>\r\n            </button>\r\n            <input type=\"text\" class=\"form-control inputBar\" />\r\n            <button class=\"btn btn-success searchBtn\">Search</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Phones section -->\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
     foreach (var phone in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-sm-12 col-md-3 my-4\">\r\n        <div class=\"flip-card\" style=\"width: 200px; height: 250px;\">\r\n            <div class=\"flip-card-inner\">\r\n                <div class=\"flip-card-front\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9e5eb16ac320a65e6b34291ad8d13f63af83ee47052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 800, "~/img/", 800, 6, true);
#nullable restore
#line 26 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 806, phone.PhotoURL, 806, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"flip-card-back\">\r\n                    <h4>");
#nullable restore
#line 29 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
                   Write(phone.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>Display: ");
#nullable restore
#line 30 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
                           Write(phone.Display);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Battery: ");
#nullable restore
#line 31 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
                           Write(phone.Battery);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Memory: ");
#nullable restore
#line 32 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
                          Write(phone.Memory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><em>");
#nullable restore
#line 33 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
                      Write(phone.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n     </div>\r\n");
#nullable restore
#line 38 "C:\Users\Matej & Marko\Desktop\Code Academy\MobileShop\MobileShopApp\MobileShop\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MobileShop.Entities.Phone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
