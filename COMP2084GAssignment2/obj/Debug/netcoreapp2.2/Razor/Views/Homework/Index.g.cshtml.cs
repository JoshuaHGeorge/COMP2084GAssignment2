#pragma checksum "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a4cc270e1dacf2d25659d5501ea763c584400b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homework_Index), @"mvc.1.0.view", @"/Views/Homework/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Homework/Index.cshtml", typeof(AspNetCore.Views_Homework_Index))]
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
#line 1 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\_ViewImports.cshtml"
using COMP2084GAssignment2;

#line default
#line hidden
#line 2 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\_ViewImports.cshtml"
using COMP2084GAssignment2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a4cc270e1dacf2d25659d5501ea763c584400b", @"/Views/Homework/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1019c09677095ea26479d21ca1b0e716a2dfb38", @"/Views/_ViewImports.cshtml")]
    public class Views_Homework_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COMP2084GAssignment1.Models.Homework>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(177, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a4cc270e1dacf2d25659d5501ea763c584400b4862", async() => {
                BeginContext(200, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(214, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(307, 39, false);
#line 17 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Due));

#line default
#line hidden
            EndContext();
            BeginContext(346, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(402, 47, false);
#line 20 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(449, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(505, 46, false);
#line 23 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Assignment));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(607, 42, false);
#line 26 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
            EndContext();
            BeginContext(649, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(784, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(845, 38, false);
#line 36 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Due));

#line default
#line hidden
            EndContext();
            BeginContext(883, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(951, 46, false);
#line 39 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(997, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1065, 50, false);
#line 42 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Assignment.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1183, 46, false);
#line 45 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1296, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a4cc270e1dacf2d25659d5501ea763c584400b10279", async() => {
                BeginContext(1349, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
                                           WriteLiteral(item.HomeworkId);

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
            BeginContext(1357, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1381, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a4cc270e1dacf2d25659d5501ea763c584400b12657", async() => {
                BeginContext(1437, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
                                              WriteLiteral(item.HomeworkId);

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
            BeginContext(1448, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1472, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a4cc270e1dacf2d25659d5501ea763c584400b15041", async() => {
                BeginContext(1527, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
                                             WriteLiteral(item.HomeworkId);

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
            BeginContext(1537, 95, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    Due in\r\n                    ");
            EndContext();
            BeginContext(1634, 44, false);
#line 54 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
                Write((item.Due.Value.Subtract(DateTime.Now)).Days);

#line default
#line hidden
            EndContext();
            BeginContext(1679, 78, true);
            WriteLiteral("\r\n                    days, \r\n\r\n                    and \r\n                    ");
            EndContext();
            BeginContext(1759, 45, false);
#line 58 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
                Write((item.Due.Value.Subtract(DateTime.Now)).Hours);

#line default
#line hidden
            EndContext();
            BeginContext(1805, 76, true);
            WriteLiteral("\r\n                    hours.\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1892, 66, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<div class=\"calender\"\r\n     \r\n     >\r\n");
            EndContext();
#line 72 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
     foreach (var item in Model)
    {
        //TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time"));

        String hold = ($"style=margin-left:{(((item.Due.Value.Subtract(DateTime.Now)).Days) * 96) + (((item.Due.Value.Subtract(DateTime.Now)).Hours) * 4)}px");

#line default
#line hidden
            BeginContext(2283, 7, true);
            WriteLiteral("    <p ");
            EndContext();
            BeginContext(2291, 4, false);
#line 77 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
  Write(hold);

#line default
#line hidden
            EndContext();
            BeginContext(2295, 24, true);
            WriteLiteral(" class=\"assignment\">\r\n\r\n");
            EndContext();
            BeginContext(2481, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(2494, 46, false);
#line 84 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2540, 21, true);
            WriteLiteral("\r\n         \r\n        ");
            EndContext();
            BeginContext(2562, 50, false);
#line 86 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Assignment.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 22, true);
            WriteLiteral("\r\n        , \r\n        ");
            EndContext();
            BeginContext(2635, 46, false);
#line 88 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2681, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 90 "C:\Users\OuO\source\repos\COMP2084GAssignment2\COMP2084GAssignment2\Views\Homework\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2700, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COMP2084GAssignment1.Models.Homework>> Html { get; private set; }
    }
}
#pragma warning restore 1591
