#pragma checksum "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01acf89bae14b14ebb8a579a67267c644b97b00e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Editar), @"mvc.1.0.view", @"/Views/Categorias/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01acf89bae14b14ebb8a579a67267c644b97b00e", @"/Views/Categorias/Editar.cshtml")]
    public class Views_Categorias_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<U3_Actividad1_Fruteria.Models.Categorias>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Categorias"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Categorias/Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Editar.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01acf89bae14b14ebb8a579a67267c644b97b00e4089", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>Editar Categoría</h1>\r\n\r\n        <input type=\"hidden\" id=\"id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 234, "\"", 251, 1);
#nullable restore
#line 10 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Editar.cshtml"
WriteAttributeValue("", 242, Model.Id, 242, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <label>Nombre:</label>\r\n        <input type=\"text\" id=\"txtNombre\" name=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 346, "\"", 367, 1);
#nullable restore
#line 13 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Editar.cshtml"
WriteAttributeValue("", 354, Model.Nombre, 354, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required=\"required\" />\r\n\r\n        <div class=\"botones\">\r\n            <p id=\"error\">\r\n                ");
#nullable restore
#line 17 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Editar.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <input type=\"submit\" value=\"Guardar\" id=\"btnGuardar\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01acf89bae14b14ebb8a579a67267c644b97b00e6099", async() => {
                    WriteLiteral("\r\n                <input type=\"button\" value=\"Cancelar\" id=\"btnCancelar\" formnovalidate=\"formnovalidate\" />\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("            \r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<U3_Actividad1_Fruteria.Models.Categorias> Html { get; private set; }
    }
}
#pragma warning restore 1591
