#pragma checksum "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57cc02aa4d31ce25e6abef1da22caf18653771e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductosCotroller_Index), @"mvc.1.0.view", @"/Views/ProductosCotroller/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cc02aa4d31ce25e6abef1da22caf18653771e2", @"/Views/ProductosCotroller/Index.cshtml")]
    public class Views_ProductosCotroller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<U3_Actividad1_Fruteria.Models.ViewModels.ProductosIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Productos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("lnkNueva"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Productos/Agregar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnEditar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnBorrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Administrar Productos</h1>\r\n\r\n<section class=\"listado\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cc02aa4d31ce25e6abef1da22caf18653771e25649", async() => {
                WriteLiteral("\r\n        <select id=\"ddlCategorias\" name=\"IdCategoria\" style=\"width:100%;margin: 10px 0\" onchange=\"this.form.submit()\">\r\n            <option");
                BeginWriteAttribute("value", " value=\"", 361, "\"", 369, 0);
                EndWriteAttribute();
                WriteLiteral(">Ver todos los productos</option>\r\n");
#nullable restore
#line 13 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
             foreach (var item in Model.Categorias)
            {
                if (item.Id == Model.IdCategoria)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <option selected");
                BeginWriteAttribute("value", " value=\"", 579, "\"", 595, 1);
#nullable restore
#line 17 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
WriteAttributeValue("", 587, item.Id, 587, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                                                 Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 18 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <option");
                BeginWriteAttribute("value", " value=\"", 707, "\"", 723, 1);
#nullable restore
#line 21 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
WriteAttributeValue("", 715, item.Id, 715, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                                        Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 22 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </select>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cc02aa4d31ce25e6abef1da22caf18653771e210165", async() => {
                WriteLiteral(@"
        <h1>Nuevo Producto...</h1>
        <h2></h2>
        <h2></h2>
        <h2></h2>
        <div class=""image"">
            <img src=""../images/addb.png"" />
        </div>
        <h2></h2>
        <h2></h2>
        <div class=""botones"">
            <img src=""../images/add.png"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 43 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
     foreach (var item in Model.Productos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <h1>");
#nullable restore
#line 46 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2>Tipo: ");
#nullable restore
#line 47 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                 Write(item.IdCategoriaNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h2>Unidad de Medida: ");
#nullable restore
#line 48 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                             Write(item.UnidadMedida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h2>Precio: ");
#nullable restore
#line 49 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                   Write(item.Precio.Value.ToString("$ 0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h2");
            BeginWriteAttribute("title", " title=\"", 1526, "\"", 1551, 1);
#nullable restore
#line 50 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
WriteAttributeValue("", 1534, item.Descripcion, 1534, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Descripción: ");
#nullable restore
#line 51 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
                         Write(item.Descripcion.Length>50?item.Descripcion.Substring( 0,50 )+"...":item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <div class=\"image\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1745, "\"", 1779, 3);
            WriteAttributeValue("", 1751, "../img_frutas/", 1751, 14, true);
#nullable restore
#line 54 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
WriteAttributeValue("", 1765, item.Id, 1765, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1775, ".jpg", 1775, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"botones\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cc02aa4d31ce25e6abef1da22caf18653771e215448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1865, "~/Productos/Editar/", 1865, 19, true);
#nullable restore
#line 57 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
AddHtmlAttributeValue("", 1884, item.Id, 1884, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cc02aa4d31ce25e6abef1da22caf18653771e217156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1945, "~/Productos/Eliminar/", 1945, 21, true);
#nullable restore
#line 58 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
AddHtmlAttributeValue("", 1966, item.Id, 1966, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 61 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\U3-Actividad1-Fruteria\Views\ProductosCotroller\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<U3_Actividad1_Fruteria.Models.ViewModels.ProductosIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
