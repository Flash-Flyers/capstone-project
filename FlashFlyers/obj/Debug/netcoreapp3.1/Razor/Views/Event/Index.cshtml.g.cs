#pragma checksum "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a28728e564734c6bcf943a1f52e1af1759e2ca3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Index), @"mvc.1.0.view", @"/Views/Event/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28728e564734c6bcf943a1f52e1af1759e2ca3c", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f590f1b73030e7dab155e8c9b859ff3bea1548d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EventController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Like", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a28728e564734c6bcf943a1f52e1af1759e2ca3c4118", async() => {
                WriteLiteral("\r\n    <script src=\'https://api.mapbox.com/mapbox-gl-js/v1.12.0/mapbox-gl.js\'></script>\r\n    <link href=\'https://api.mapbox.com/mapbox-gl-js/v1.12.0/mapbox-gl.css\' rel=\'stylesheet\' />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a28728e564734c6bcf943a1f52e1af1759e2ca3c5276", async() => {
                WriteLiteral("\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 277, "\"", 321, 2);
                WriteAttributeValue("", 284, "https://www.flashflyerz.com/", 284, 28, true);
#nullable restore
#line 10 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
WriteAttributeValue("", 312, Model.Id, 312, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <h1>");
#nullable restore
#line 10 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                    Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1></a>\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 357, "\"", 401, 2);
                WriteAttributeValue("", 364, "https://www.flashflyerz.com/", 364, 28, true);
#nullable restore
#line 11 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
WriteAttributeValue("", 392, Model.Id, 392, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <embed");
                BeginWriteAttribute("src", " src=\"", 410, "\"", 439, 2);
#nullable restore
#line 11 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
WriteAttributeValue("", 416, Model.Id, 416, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 427, "_with_qr.png", 427, 12, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"vertical-align: middle;\"></a>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p> This event is happening on ");
#nullable restore
#line 13 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                              Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" at ");
#nullable restore
#line 13 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                             Write(Model.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral(" at ");
#nullable restore
#line 13 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                            Write(Model.Building);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                                            Write(Model.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <div id=\'map\' style=\'width: 900px; height: 600px;\'></div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a28728e564734c6bcf943a1f52e1af1759e2ca3c8659", async() => {
                    WriteLiteral("Like This Event");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                           WriteLiteral(Model.Id);

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
                WriteLiteral(@"
    <p class=""line"" style=""position: relative; right: 0;""></p>
    <script>
            //MapBox
            //Needs Access Token to work
                mapboxgl.accessToken = 'pk.eyJ1IjoiamV2YW5zNjMiLCJhIjoiY2tnbzY4cnN5MGF6ODJ3cGt5aGZ6eGp0aiJ9.TArDSi86NVbWXcmy9Ezb_w';//access token goes here
                var map = new mapboxgl.Map({
                    container: 'map',
                    style: 'mapbox://styles/mapbox/streets-v11', //for street view style
                    //style: 'mapbox://styles/mapbox/satellite-v9', //for satelite view style
                    //center: [-81.341531, 41.145157], //generic center for kent campus
                    center: [");
#nullable restore
#line 26 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                        Write(Model.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 26 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                          Write(Model.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                    zoom: 16 //focused in enough to show building names\r\n                });\r\n\r\n                //location marker\r\n                var marker = new mapboxgl.Marker()\r\n                    .setLngLat([");
#nullable restore
#line 32 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                           Write(Model.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 32 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                             Write(Model.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("])//kent state, kent campus, msb building\r\n                    .addTo(map);\r\n    </script>\r\n    <a href=\"https://www.flashflyerz.com/\" class=\"h1\"");
                BeginWriteAttribute("style", " style=\"", 1891, "\"", 1899, 0);
                EndWriteAttribute();
                WriteLiteral("><h2>Main Events</h2></a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
