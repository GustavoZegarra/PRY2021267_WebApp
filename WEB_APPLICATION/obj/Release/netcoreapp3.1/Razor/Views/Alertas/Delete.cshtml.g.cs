#pragma checksum "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64df3df9450ed37e4f847194a659e49506c1ac97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alertas_Delete), @"mvc.1.0.view", @"/Views/Alertas/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64df3df9450ed37e4f847194a659e49506c1ac97", @"/Views/Alertas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57e030ec4995b2d757bb3fc4a18c419af286a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Alertas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB_APPLICATION.Models.Alerta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Eliminar</h1>\r\n\r\n<h3  >Are you sure you want to delete this?</h3>\r\n<div   >\r\n    <h4 >Alerta</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecipitacionProm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrecipitacionProm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecipitacionMax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrecipitacionMax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecipitacionMin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrecipitacionMin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nivel.Riesgo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sensor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sensor.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64df3df9450ed37e4f847194a659e49506c1ac9710544", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64df3df9450ed37e4f847194a659e49506c1ac9710811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 59 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Alertas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAlerta);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64df3df9450ed37e4f847194a659e49506c1ac9712667", async() => {
                    WriteLiteral("Regresar a la lista de Alertas");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB_APPLICATION.Models.Alerta> Html { get; private set; }
    }
}
#pragma warning restore 1591
