#pragma checksum "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "389d31082deb5370d2913f5582a90ce8ca3d2bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Details), @"mvc.1.0.view", @"/Views/Departments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Details.cshtml", typeof(AspNetCore.Views_Departments_Details))]
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
#line 1 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\_ViewImports.cshtml"
using PeoplePro2;

#line default
#line hidden
#line 2 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\_ViewImports.cshtml"
using PeoplePro2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389d31082deb5370d2913f5582a90ce8ca3d2bcf", @"/Views/Departments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b2db3662b76133b0cd0e84b81a00ae1ed765aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PeoplePro2.Models.Department>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 116, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Department</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(194, 40, false);
#line 14 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(234, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(275, 36, false);
#line 17 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(311, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(352, 44, false);
#line 20 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Building));

#line default
#line hidden
            EndContext();
            BeginContext(396, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(437, 45, false);
#line 23 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Building.Name));

#line default
#line hidden
            EndContext();
            BeginContext(482, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(523, 45, false);
#line 26 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employees));

#line default
#line hidden
            EndContext();
            BeginContext(568, 28, true);
            WriteLiteral("\n        </dt>\n        <dd>\n");
            EndContext();
#line 29 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
             foreach (var employee in Model.Employees)
            {
                

#line default
#line hidden
            BeginContext(682, 18, false);
#line 31 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
           Write(employee.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(701, 29, true);
            WriteLiteral("                <div> </div>\n");
            EndContext();
#line 33 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(744, 41, true);
            WriteLiteral("        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(785, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1406a8517f1a40c38667ef90d0fd2dd6", async() => {
                BeginContext(841, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Departments\Details.cshtml"
                           WriteLiteral(Model.DepartmentId);

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
            BeginContext(849, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(856, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448584bf93114d2789b8488919086c56", async() => {
                BeginContext(878, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(894, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PeoplePro2.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
