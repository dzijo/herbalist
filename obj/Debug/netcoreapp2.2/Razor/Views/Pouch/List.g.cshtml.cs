#pragma checksum "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a1b195a409d947fee72650643604b2a92b1a98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pouch_List), @"mvc.1.0.view", @"/Views/Pouch/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pouch/List.cshtml", typeof(AspNetCore.Views_Pouch_List))]
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
#line 1 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\_ViewImports.cshtml"
using Herbalist;

#line default
#line hidden
#line 2 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\_ViewImports.cshtml"
using Herbalist.Models;

#line default
#line hidden
#line 3 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\_ViewImports.cshtml"
using Herbalist.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a1b195a409d947fee72650643604b2a92b1a98", @"/Views/Pouch/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b778053ae0894a9e7777f4cfd7b98d4e3d3b691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pouch_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HerbViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-dark btn-lg text-center m-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pouch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Herb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Brew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
  
    ViewData["Title"] = "Pouch";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 127, true);
            WriteLiteral("\r\n<div class=\"text-center mb-2\">\r\n    <h1>Pouch</h1>\r\n</div>\r\n\r\n<div class=\"mb-2 btn-toolbar\" style=\"padding-left: 15px\">\r\n    ");
            EndContext();
            BeginContext(252, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a1b195a409d947fee72650643604b2a92b1a985990", async() => {
                BeginContext(390, 6, true);
                WriteLiteral("Gather");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(400, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(406, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a1b195a409d947fee72650643604b2a92b1a987936", async() => {
                BeginContext(544, 4, true);
                WriteLiteral("Brew");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(552, 313, true);
            WriteLiteral(@"
</div>
<table class=""table table-striped table-dark table-hover table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th>Herb</th>
            <th>Location</th>
            <th>Rarity</th>
            <th>DC</th>
            <th>Count</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
         foreach (var herb in Model)
        {

#line default
#line hidden
            BeginContext(914, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(953, 13, false);
#line 30 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
               Write(herb.HerbName);

#line default
#line hidden
            EndContext();
            BeginContext(966, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(994, 13, false);
#line 31 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
               Write(herb.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1035, 11, false);
#line 32 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
               Write(herb.Rarity);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1074, 7, false);
#line 33 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
               Write(herb.DC);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1109, 10, false);
#line 34 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
               Write(herb.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Matej\source\repos\Herbalist\Herbalist\Views\Pouch\List.cshtml"
        }

#line default
#line hidden
            BeginContext(1156, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HerbViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
