#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8741e62c941e35f4b63214aa18a1eb9150c438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Races_Details), @"mvc.1.0.view", @"/Views/Races/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Races/Details.cshtml", typeof(AspNetCore.Views_Races_Details))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8741e62c941e35f4b63214aa18a1eb9150c438", @"/Views/Races/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_Races_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Race>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(172, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
  
    ViewData["Title"] = @Localizer["races_details_title"];

#line default
#line hidden
            BeginContext(237, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(243, 17, false);
#line 11 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(260, 104, true);
            WriteLiteral("</h1>\n\n<div class=\"panel panel-default\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(365, 47, false);
#line 16 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BallotOrder));

#line default
#line hidden
            EndContext();
            BeginContext(412, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(471, 43, false);
#line 19 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayFor(model => model.BallotOrder));

#line default
#line hidden
            EndContext();
            BeginContext(514, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(572, 48, false);
#line 22 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PositionName));

#line default
#line hidden
            EndContext();
            BeginContext(620, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(679, 44, false);
#line 25 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayFor(model => model.PositionName));

#line default
#line hidden
            EndContext();
            BeginContext(723, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(781, 47, false);
#line 28 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(828, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(887, 43, false);
#line 31 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(930, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(988, 48, false);
#line 34 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberNeeded));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1095, 44, false);
#line 37 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberNeeded));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1197, 50, false);
#line 40 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CandidateRaces));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 46, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n");
            EndContext();
#line 43 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
             if (ViewBag.Candidates != null)
            {

#line default
#line hidden
            BeginContext(1352, 21, true);
            WriteLiteral("                <ul>\n");
            EndContext();
#line 46 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                      
                        var candidates = (List<Candidate>)ViewBag.Candidates;
                    

#line default
#line hidden
            BeginContext(1496, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 50 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                     foreach (var candidate in candidates)
                    {
                        if (Model.CandidateRaces.Exists(model => model.CandidateId == candidate.CandidateId))
                        {

#line default
#line hidden
            BeginContext(1714, 65, true);
            WriteLiteral("                            <li>\n                                ");
            EndContext();
            BeginContext(1780, 40, false);
#line 55 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                           Write(Html.DisplayFor(model => candidate.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 35, true);
            WriteLiteral("\n                            </li>\n");
            EndContext();
#line 57 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1903, 22, true);
            WriteLiteral("                </ul>\n");
            EndContext();
#line 60 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1939, 41, true);
            WriteLiteral("        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1980, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc8741e62c941e35f4b63214aa18a1eb9150c43811369", async() => {
                BeginContext(2055, 23, false);
#line 65 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                                                                         Write(Localizer["editButton"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                                                   WriteLiteral(Model.RaceId);

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
            BeginContext(2082, 6, true);
            WriteLiteral(" \n    ");
            EndContext();
            BeginContext(2088, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc8741e62c941e35f4b63214aa18a1eb9150c43813971", async() => {
                BeginContext(2132, 23, false);
#line 66 "C:\projects\plan-your-vote-cms-develop\Web\Views\Races\Details.cshtml"
                                          Write(Localizer["backButton"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2159, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Race> Html { get; private set; }
    }
}
#pragma warning restore 1591
