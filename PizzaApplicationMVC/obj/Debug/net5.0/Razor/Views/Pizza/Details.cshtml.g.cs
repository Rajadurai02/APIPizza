#pragma checksum "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674a6feb3cf4a935bfe86f00fef0742e2c9daf44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
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
#line 1 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\_ViewImports.cshtml"
using PizzaApplicationMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\_ViewImports.cshtml"
using PizzaApplicationMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674a6feb3cf4a935bfe86f00fef0742e2c9daf44", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f4f104084225faa9f7a65a441e0aea43b8c46f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaApplicationMVC.ViewModels.ToppingList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/DetailsPage.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "674a6feb3cf4a935bfe86f00fef0742e2c9daf445033", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
   TempData["pizzaChoise"] = @ViewBag.thePizza.PizzaID;
    TempData["pizzaPrice"] = @ViewBag.thePizza.PizzaPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container details\">\r\n    <div class=\"pizza-info\">\r\n        <div class=\"row\">\r\n            <div>\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 517, "\"", 572, 3);
            WriteAttributeValue("", 523, "/Images/Pizzas/", 523, 15, true);
#nullable restore
#line 16 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
WriteAttributeValue("", 538, ViewBag.thePizza.PizzaName, 538, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 567, ".jpeg", 567, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"height: 230px;\">\r\n                    <div class=\"card-body\">\r\n\r\n                        <h5 class=\"card-title text-center\">");
#nullable restore
#line 19 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                                                      Write(ViewBag.thePizza.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                        <h6 class=\"card-text\">Prise $");
#nullable restore
#line 21 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                                                Write(ViewBag.thePizza.PizzaPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6 class=\"card-text\">");
#nullable restore
#line 22 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                                         Write(ViewBag.thePizza.PizzaType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>

                        <p class=""card-text"">Some pizza descriptions on the card title and make up the bulk of the card's content.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "674a6feb3cf4a935bfe86f00fef0742e2c9daf448580", async() => {
                WriteLiteral("\r\n            <div>\r\n");
#nullable restore
#line 33 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                 using (Html.BeginForm())
                {
                    for (int i = 0; i < Model.Toppings.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>\r\n                            ");
#nullable restore
#line 38 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                       Write(Html.CheckBoxFor(m => Model.Toppings[i].IsChecked));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                       Write(Model.Toppings[i].ToppingName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $ \r\n                            ");
#nullable restore
#line 40 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                       Write(Model.Toppings[i].ToppingPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 41 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                       Write(Html.HiddenFor(m => Model.Toppings[i].ToppingPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                       Write(Html.HiddenFor(m => Model.Toppings[i].ToppingID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                       Write(Html.HiddenFor(m => Model.Toppings[i].ToppingName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 45 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"


                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""add-order"">
                        <input type=""submit"" value=""Add to order"" class=""btn btn-primary w-100"" />
                    </div>
                    <div class=""add-order"">
                        <a href=""/Pizza"" class=""btn btn-warning w-100 another"">Choose another pizza</a>
                    </div>
                    <div class=""add-order"">
                        <a href=""/OrderDetail/Index"" class=""btn btn-success w-100"">Finish orders</a>
                    </div>
");
#nullable restore
#line 57 "D:\October Training\PizzaApplication\PizzaApplicationMVC\Views\Pizza\Details.cshtml"
                                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaApplicationMVC.ViewModels.ToppingList> Html { get; private set; }
    }
}
#pragma warning restore 1591
