#pragma checksum "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8907fedd932cb1af5d723a27be66bfcdea14094b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_Details), @"mvc.1.0.view", @"/Views/Schedule/Details.cshtml")]
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
#line 1 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\_ViewImports.cshtml"
using InhouseMembership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\_ViewImports.cshtml"
using InhouseMembership.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8907fedd932cb1af5d723a27be66bfcdea14094b", @"/Views/Schedule/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22117e055594331436dddb7f777211edb4cee31", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InhouseMembership.Models.Schedule>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CoachProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEnrollment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
  
    DateTime currentTime = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\n\n<div class=\"card-body bg-secondary\">\n    <h4>Schedule</h4>\n    <hr />\n    <dl class=\"row\">\n\n        <dt class=\"col-sm-2 text-white\">\n            ");
#nullable restore
#line 20 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-white\">\n            ");
#nullable restore
#line 26 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 29 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2 text-white\">\n            ");
#nullable restore
#line 32 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 35 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n");
#nullable restore
#line 38 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
         if (!User.IsInRole("Member"))
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2 text-white\">\n                Enrolled members\n            </dt>\n            <dd class=\"col-sm-10\">\n");
#nullable restore
#line 44 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
                 foreach (Enrollment erollment in Model.Enrollments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4>");
#nullable restore
#line 46 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
                   Write(erollment.Member.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 47 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\n");
#nullable restore
#line 50 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n        \n\n\n\n");
#nullable restore
#line 56 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
         if (!User.IsInRole("Coach"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2 text-white\">\n                Coach Name\n            </dt>\n            <!-- get the coach name by passing coach id into UserManager -->\n    <dd class=\"col-sm-10\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8907fedd932cb1af5d723a27be66bfcdea14094b9575", async() => {
                WriteLiteral("View Coach Profile of ");
#nullable restore
#line 63 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
                                                                                                            Write(Html.DisplayFor(model => UserManager.FindByIdAsync(model.CoachId).Result.UserName));

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 63 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
                                       WriteLiteral(Model.CoachId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </dd>\n");
#nullable restore
#line 65 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dl>\n</div>\n<div class=\"text-white\">\n    <!-- if the event time is before current time, show the event has ended -->\n");
#nullable restore
#line 71 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
     if (User.IsInRole("Member"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
         if (Model.EventDate <= currentTime)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>(Event has ended!)</h3>\n");
#nullable restore
#line 76 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- otherwise, show enroll button -->\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8907fedd932cb1af5d723a27be66bfcdea14094b13307", async() => {
                WriteLiteral("<h3>Enroll in New Schedule</h3>");
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
#nullable restore
#line 80 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
                                               WriteLiteral(Model.ScheduleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 81 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
         

    }

    else if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- for an admin, give the option to edit the event -->\n");
#nullable restore
#line 88 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
         if (Model.EventDate <= currentTime)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>(Event has ended!)</h3>\n");
#nullable restore
#line 91 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8907fedd932cb1af5d723a27be66bfcdea14094b16643", async() => {
                WriteLiteral("Edit Schedule");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
                               WriteLiteral(Model.ScheduleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8907fedd932cb1af5d723a27be66bfcdea14094b18971", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 94 "H:\GitHub\HIT339_Assignment_2\InhouseMembership\Views\Schedule\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InhouseMembership.Models.Schedule> Html { get; private set; }
    }
}
#pragma warning restore 1591
