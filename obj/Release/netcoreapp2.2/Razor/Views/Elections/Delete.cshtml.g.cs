#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fe22a8bdb68f528fcb4817d591e89aa9ce0052f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elections_Delete), @"mvc.1.0.view", @"/Views/Elections/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elections/Delete.cshtml", typeof(AspNetCore.Views_Elections_Delete))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\_ViewImports.cshtml"
using Web.CmsControllers;

#line default
#line hidden
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe22a8bdb68f528fcb4817d591e89aa9ce0052f", @"/Views/Elections/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Election>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(176, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
  
    ViewData["Title"] = @Localizer["elections_delete_title"];

#line default
#line hidden
            BeginContext(244, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(250, 17, false);
#line 11 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(267, 11, true);
            WriteLiteral("</h1>\n\n<h3>");
            EndContext();
            BeginContext(279, 26, false);
#line 13 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
Write(Localizer["deleteWarning"]);

#line default
#line hidden
            EndContext();
            BeginContext(305, 103, true);
            WriteLiteral("</h3>\n<div class=\"panel panel-default\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(409, 48, false);
#line 17 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ElectionName));

#line default
#line hidden
            EndContext();
            BeginContext(457, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(516, 44, false);
#line 20 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ElectionName));

#line default
#line hidden
            EndContext();
            BeginContext(560, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(618, 45, false);
#line 23 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(663, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(722, 41, false);
#line 26 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(763, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(821, 43, false);
#line 29 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(864, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(923, 39, false);
#line 32 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(962, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1020, 47, false);
#line 35 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1126, 43, false);
#line 38 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(1199, 261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fe22a8bdb68f528fcb4817d591e89aa9ce0052f9592", async() => {
                BeginContext(1225, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1234, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fe22a8bdb68f528fcb4817d591e89aa9ce0052f9981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 43 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ElectionId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1278, 29, true);
                WriteLiteral("\n        <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1307, "", 1340, 1);
#line 44 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
WriteAttributeValue("", 1314, Localizer["deleteButton"], 1314, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1340, 37, true);
                WriteLiteral(" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(1377, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fe22a8bdb68f528fcb4817d591e89aa9ce0052f12286", async() => {
                    BeginContext(1421, 23, false);
#line 45 "C:\projects\plan-your-vote-cms-develop\Web\Views\Elections\Delete.cshtml"
                                              Write(Localizer["backButton"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1448, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1460, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Election> Html { get; private set; }
    }
}
#pragma warning restore 1591
