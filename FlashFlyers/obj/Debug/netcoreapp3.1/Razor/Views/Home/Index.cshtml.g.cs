#pragma checksum "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d3784d70f8317e0a10fcc20b7ba49ecaf5946aa"
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
#line 1 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\_ViewImports.cshtml"
using FlashFlyers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\_ViewImports.cshtml"
using FlashFlyers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3784d70f8317e0a10fcc20b7ba49ecaf5946aa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f590f1b73030e7dab155e8c9b859ff3bea1548d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d3784d70f8317e0a10fcc20b7ba49ecaf5946aa3404", async() => {
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css2?family=Roboto+Slab&display=swap"" rel=""stylesheet"">
    <style>
        h1 {
            font-size: 35px;
            color: white;
        }

        .h1 {
            font-size: 35px;
            color: white;
            position: relative;
            right: 0;
        }

        h2 {
            font-size: 100px;
            color: rgb(238,174,36);
        }

        p {
            font-size: 20px;
            padding-top: 10px;
            padding-bottom: 10px;
            color: white;
        }

        body {
            font-family: 'Roboto Slab', serif;
            background: radial-gradient(#001f55, #013375);
        }

        .line {
            border-bottom: 4px solid rgb(238,174,36);
        }

        .button {
            font-size: 35px;
            color: white;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d3784d70f8317e0a10fcc20b7ba49ecaf5946aa5281", async() => {
                WriteLiteral("\r\n    <h2 style=\"position: relative; right:0;\">\r\n        Events\r\n    </h2>\r\n");
#nullable restore
#line 51 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
      
        var last = Model.Last();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
         foreach (var evnt in Model)
        {
            //Hard-coded base directory for now.

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 1239, "\"", 1278, 2);
                WriteAttributeValue("", 1246, "https://localhost:44395/", 1246, 24, true);
#nullable restore
#line 56 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
WriteAttributeValue("", 1270, evnt.Id, 1270, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <h1>");
#nullable restore
#line 56 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                                                       Write(evnt.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1></a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1321, "\"", 1360, 2);
                WriteAttributeValue("", 1328, "https://localhost:44395/", 1328, 24, true);
#nullable restore
#line 57 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
WriteAttributeValue("", 1352, evnt.Id, 1352, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <embed");
                BeginWriteAttribute("src", " src=\"", 1369, "\"", 1389, 1);
#nullable restore
#line 57 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
WriteAttributeValue("", 1375, evnt.FileName, 1375, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 250px; width: 500px; vertical-align: middle;\"></a>\r\n");
#nullable restore
#line 58 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <embed");
                BeginWriteAttribute("src", " src=\"", 1495, "\"", 1518, 2);
#nullable restore
#line 59 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
WriteAttributeValue("", 1501, evnt.Id, 1501, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1511, "_qr.png", 1511, 7, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 250px; width: 250px; vertical-align: middle;\">\r\n                <p>Date: ");
#nullable restore
#line 60 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                    Write(evnt.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Time: ");
#nullable restore
#line 61 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                    Write(evnt.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Building: ");
#nullable restore
#line 62 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                        Write(evnt.Building);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Room: ");
#nullable restore
#line 63 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                    Write(evnt.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Campus: ");
#nullable restore
#line 64 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                      Write(evnt.Campus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p class=\"line\" style=\"position: relative; right: 0;\">Description: ");
#nullable restore
#line 65 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
                                                                              Write(evnt.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 66 "C:\Users\Gaming\Desktop\Rep\capstone-project\FlashFlyers\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
