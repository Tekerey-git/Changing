#pragma checksum "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1849efe57f409384dd29798e3bd31dff45c2db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Battalions_Details), @"mvc.1.0.view", @"/Views/Battalions/Details.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\_ViewImports.cshtml"
using HistorySiteIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\_ViewImports.cshtml"
using HistorySiteIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1849efe57f409384dd29798e3bd31dff45c2db6", @"/Views/Battalions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9257876a442848029e07b31e38a8c5b3cb22379", @"/Views/_ViewImports.cshtml")]
    public class Views_Battalions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistorySiteIdentity.Models.Battalion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
   Layout = @"~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
  
    ViewData["Title"] = "Описание";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Описание</h1>\r\n\r\n<div>\r\n    <h4>Батальон</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"Name\" class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalStrenght));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalStrenght));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdditionalInformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdditionalInformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CoordX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"geomapX\" class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.CoordX));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CoordY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd id=\"geomapY\" class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.CoordY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd id=\"geomapXY\" class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.CoordinatesXY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd id=\"Adress1\" class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
     if (Model.Image != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img style=\'width:180px; height:220px;\'");
            BeginWriteAttribute("src", " src=\"", 1849, "\"", 1916, 2);
            WriteAttributeValue("", 1855, "data:image/jpeg;base64,", 1855, 23, true);
#nullable restore
#line 58 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
WriteAttributeValue("", 1878, Convert.ToBase64String(Model.Image), 1878, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 59 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1849efe57f409384dd29798e3bd31dff45c2db610892", async() => {
                WriteLiteral("Редактирование");
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
#line 62 "C:\Users\User\Desktop\Новая папка (3)\HistorySiteIdentity\HistorySiteIdentity\HistorySiteIdentity\Views\Battalions\Details.cshtml"
                           WriteLiteral(Model.BattalionId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1849efe57f409384dd29798e3bd31dff45c2db613104", async() => {
                WriteLiteral("Вернуться к списку");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistorySiteIdentity.Models.Battalion> Html { get; private set; }
    }
}
#pragma warning restore 1591
