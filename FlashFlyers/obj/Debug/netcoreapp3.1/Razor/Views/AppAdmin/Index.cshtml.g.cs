#pragma checksum "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68ba1767c7efb3577afc681234813ef55729deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppAdmin_Index), @"mvc.1.0.view", @"/Views/AppAdmin/Index.cshtml")]
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
#line 1 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\_ViewImports.cshtml"
using FlashFlyers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\_ViewImports.cshtml"
using FlashFlyers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68ba1767c7efb3577afc681234813ef55729deb", @"/Views/AppAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f590f1b73030e7dab155e8c9b859ff3bea1548d1", @"/Views/_ViewImports.cshtml")]
    public class Views_AppAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AppAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Modify", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:forestgreen;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:darkred;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
  
    ViewData["Title"] = "AppAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AppAdmin</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b68ba1767c7efb3577afc681234813ef55729deb5838", async() => {
                WriteLiteral("Delete Event By Id");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b68ba1767c7efb3577afc681234813ef55729deb7419", async() => {
                WriteLiteral("Modify Event By Id");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2 style=\"position: relative; right:0;\">\r\n    Events\r\n</h2>\r\n");
#nullable restore
#line 14 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
  
    // this script will generate the html for every event to the AppAdmin
    // this is in order to have a quick glance at events and the option to modify or delete by EventId

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
     foreach (var evnt in Model)
    {
        DateTime eventDate = DateTime.Parse(@evnt.Date);
        DateTime currentDate = DateTime.Now;

        if (eventDate >= currentDate)
        {
            //Hard-coded base directory for now.

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 822, 2);
            WriteAttributeValue("", 790, "https://localhost:44395/", 790, 24, true);
#nullable restore
#line 26 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
WriteAttributeValue("", 814, evnt.Id, 814, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"h1\"> ");
#nullable restore
#line 26 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                                                              Write(evnt.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <br>\r\n            <br>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 903, "\"", 942, 2);
            WriteAttributeValue("", 910, "https://localhost:44395/", 910, 24, true);
#nullable restore
#line 29 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
WriteAttributeValue("", 934, evnt.Id, 934, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <embed");
            BeginWriteAttribute("src", " src=\"", 951, "\"", 971, 1);
#nullable restore
#line 29 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
WriteAttributeValue("", 957, evnt.FileName, 957, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"vertical-align: middle;\"></a>\r\n            <br>\r\n            <br>\r\n");
#nullable restore
#line 32 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Event Id: ");
#nullable restore
#line 33 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                        Write(evnt.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Date: ");
#nullable restore
#line 34 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                    Write(evnt.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Time: ");
#nullable restore
#line 35 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                    Write(evnt.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Building: ");
#nullable restore
#line 36 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                        Write(evnt.Building);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Room: ");
#nullable restore
#line 37 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                    Write(evnt.Room);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("                <p>Likes ");
#nullable restore
#line 39 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                    Write(evnt.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Description: ");
#nullable restore
#line 40 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                           Write(evnt.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 41 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
     //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     //Warning! This is not secure, use this tag for testing and demo purposes only

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b68ba1767c7efb3577afc681234813ef55729deb14077", async() => {
                WriteLiteral("Delete Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                                                                       WriteLiteral(evnt.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                if (!evnt.Approved) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b68ba1767c7efb3577afc681234813ef55729deb16720", async() => {
                WriteLiteral("Approve Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                                                                                                       WriteLiteral(evnt.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b68ba1767c7efb3577afc681234813ef55729deb19249", async() => {
                WriteLiteral("Disapprove Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                                                                                                  WriteLiteral(evnt.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"line\" style=\"position: relative; right: 0;\"></p>\r\n                <br>\r\n");
#nullable restore
#line 50 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\AppAdmin\Index.cshtml"
            }
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
