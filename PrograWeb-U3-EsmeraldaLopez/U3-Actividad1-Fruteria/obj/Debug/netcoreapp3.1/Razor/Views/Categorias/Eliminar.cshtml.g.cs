#pragma checksum "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Eliminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc318c99966b3ed78a7c7014c259c7d6d74ace5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Eliminar), @"mvc.1.0.view", @"/Views/Categorias/Eliminar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc318c99966b3ed78a7c7014c259c7d6d74ace5", @"/Views/Categorias/Eliminar.cshtml")]
    public class Views_Categorias_Eliminar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<U3_Actividad1_Fruteria.Models.Categorias>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Categorias"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Categorias/Eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Eliminar.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc318c99966b3ed78a7c7014c259c7d6d74ace54103", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>Eliminar Categoría</h1>\r\n\r\n        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 230, "\"", 247, 1);
#nullable restore
#line 10 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Eliminar.cshtml"
WriteAttributeValue("", 238, Model.Id, 238, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <p>¿Está seguro de eliminar la categoría \"<span id=\"nombreCategoria\">");
#nullable restore
#line 12 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Eliminar.cshtml"
                                                                        Write(Model.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\"?</p>\r\n\r\n        <div class=\"botones\">\r\n            <p id=\"error\">\r\n                ");
#nullable restore
#line 16 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\Categorias\Eliminar.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <input type=\"submit\" value=\"Si\" id=\"btnSi\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc318c99966b3ed78a7c7014c259c7d6d74ace55991", async() => {
                    WriteLiteral("\r\n                <input type=\"button\" value=\"No\" id=\"btnNo\" formnovalidate=\"formnovalidate\" />\r\n            ");
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
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
