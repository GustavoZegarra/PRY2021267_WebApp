#pragma checksum "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ce28a30ce691cf861bc6f523f0d15d51d69e34b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incidentes_Details), @"mvc.1.0.view", @"/Views/Incidentes/Details.cshtml")]
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
#line 1 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\_ViewImports.cshtml"
using WEB_APPLICATION;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\_ViewImports.cshtml"
using WEB_APPLICATION.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ce28a30ce691cf861bc6f523f0d15d51d69e34b", @"/Views/Incidentes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57e030ec4995b2d757bb3fc4a18c419af286a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Incidentes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB_APPLICATION.Models.Incidente>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Incidente</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Resuelto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Resuelto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quebrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quebrada.IdQuebrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Motivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Motivo.IdMotivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GPS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
       Write(Html.DisplayFor(model => model.GPS.IdGps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ce28a30ce691cf861bc6f523f0d15d51d69e34b11400", async() => {
                WriteLiteral("Edit");
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
#line 70 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Details.cshtml"
                           WriteLiteral(Model.IdIncidente);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ce28a30ce691cf861bc6f523f0d15d51d69e34b13619", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB_APPLICATION.Models.Incidente> Html { get; private set; }
    }
}
#pragma warning restore 1591
