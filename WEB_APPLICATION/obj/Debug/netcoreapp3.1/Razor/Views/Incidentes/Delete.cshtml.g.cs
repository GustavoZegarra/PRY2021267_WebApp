#pragma checksum "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb5b3e397d32392a32ef8dd6b8d70bc6d0c8bfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incidentes_Delete), @"mvc.1.0.view", @"/Views/Incidentes/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb5b3e397d32392a32ef8dd6b8d70bc6d0c8bfa", @"/Views/Incidentes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57e030ec4995b2d757bb3fc4a18c419af286a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Incidentes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB_APPLICATION.Models.Incidente>
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
#line 3 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Incidente</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n");
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 648, "\"", 712, 1);
#nullable restore
#line 25 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
WriteAttributeValue("", 654, Url.Action("RenderImage", new { id = @Model.IdIncidente}), 654, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 713, "\"", 719, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"150\" width=\"300\"  />\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaActualizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Resuelto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Resuelto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usuario.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quebrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quebrada.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Motivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Motivo.Detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n           <dt class = \"col-sm-2\">\r\n            Latitud\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GPS.Latitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n           <dt class = \"col-sm-2\">\r\n            Longitud\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GPS.Longitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfb5b3e397d32392a32ef8dd6b8d70bc6d0c8bfa12630", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bfb5b3e397d32392a32ef8dd6b8d70bc6d0c8bfa12897", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "C:\Universidad_UltimoCiclo\TP2\System_admin_api\API_APPLICATION\MAPEO TP2\WEBAPP\PRY2021267_WebApp\WEB_APPLICATION\Views\Incidentes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdIncidente);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfb5b3e397d32392a32ef8dd6b8d70bc6d0c8bfa14759", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB_APPLICATION.Models.Incidente> Html { get; private set; }
    }
}
#pragma warning restore 1591
