#pragma checksum "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1da2a9deee04b7bd9e6114bafefcb11014f36ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incidentes_Index), @"mvc.1.0.view", @"/Views/Incidentes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1da2a9deee04b7bd9e6114bafefcb11014f36ee", @"/Views/Incidentes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57e030ec4995b2d757bb3fc4a18c419af286a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Incidentes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WEB_APPLICATION.Models.Incidente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 22 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 31 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quebrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Motivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Latitud\r\n            </th>\r\n            <th>\r\n                Longitud\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 58 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 67 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuario.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quebrada.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Motivo.Detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GPS.Latitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n                <td>\r\n                ");
#nullable restore
#line 79 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GPS.Longitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1da2a9deee04b7bd9e6114bafefcb11014f36ee9672", async() => {
                WriteLiteral("Details");
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
#line 83 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
                                          WriteLiteral(item.IdIncidente);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1da2a9deee04b7bd9e6114bafefcb11014f36ee11917", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
                                         WriteLiteral(item.IdIncidente);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WEB_APPLICATION.Models.Incidente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
