#pragma checksum "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5bc72afbcd26751ec4676f7696bb17abc7c5648"
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
#nullable restore
#line 3 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bc72afbcd26751ec4676f7696bb17abc7c5648", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f590f1b73030e7dab155e8c9b859ff3bea1548d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Like", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bc72afbcd26751ec4676f7696bb17abc7c56485537", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bc72afbcd26751ec4676f7696bb17abc7c56486695", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 14 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <embed");
                BeginWriteAttribute("src", " src=\"", 464, "\"", 493, 2);
#nullable restore
#line 15 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
WriteAttributeValue("", 470, Model.Id, 470, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 481, "_with_qr.png", 481, 12, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"vertical-align: middle;\">\r\n    <!--Likes-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bc72afbcd26751ec4676f7696bb17abc7c56487699", async() => {
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
#line 17 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                                           WriteLiteral(User.Identity.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <p>Likes: ");
#nullable restore
#line 18 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
         Write(Model.Likes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 19 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p> This event is happening on ");
#nullable restore
#line 20 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                              Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" at ");
#nullable restore
#line 20 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                             Write(Model.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral(" at ");
#nullable restore
#line 20 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                            Write(Model.Building);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                                                            Write(Model.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <div id=\'map\' style=\'width: 900px; height: 600px;\'></div>\r\n    <br />\r\n\r\n");
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
#line 37 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                        Write(Model.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 37 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                          Write(Model.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                    zoom: 16 //focused in enough to show building names\r\n                });\r\n\r\n                //location marker\r\n                var marker = new mapboxgl.Marker()\r\n                    .setLngLat([");
#nullable restore
#line 43 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                           Write(Model.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 43 "C:\Users\Josh\Desktop\capstone-project\FlashFlyers\Views\Event\Index.cshtml"
                                             Write(Model.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("])//kent state, kent campus, msb building\r\n                    .addTo(map);\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bc72afbcd26751ec4676f7696bb17abc7c564814692", async() => {
                    WriteLiteral("<h2>Main Events</h2>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
