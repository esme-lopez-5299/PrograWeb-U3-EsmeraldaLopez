#pragma checksum "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8cb2675e6e6d587b1b7e13a65707bef3bd9793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8cb2675e6e6d587b1b7e13a65707bef3bd9793", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZooPlanet.Models.Especies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administrador/Agregar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    int x = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Especies</h1>\r\n\r\n<table>\r\n    <colgroup>\r\n        <col style=\"width:50px\" />\r\n        <col style=\"width:40px\" />\r\n        <col />\r\n        <col style=\"width:50%\" />\r\n    </colgroup>\r\n    <caption>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8cb2675e6e6d587b1b7e13a65707bef3bd97933829", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i> Agregar Especie");
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
            WriteLiteral("\r\n    </caption>\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th colspan=\"2\">Especie</th>\r\n            <th>Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"center\">");
#nullable restore
#line 30 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
                               Write(x++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:40px\"><img");
            BeginWriteAttribute("src", " src=\"", 738, "\"", 771, 3);
            WriteAttributeValue("", 744, "/clases/", 744, 8, true);
#nullable restore
#line 31 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 752, item.IdClase, 752, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 767, ".png", 767, 4, true);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
               Write(item.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"center\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 879, "\"", 918, 2);
            WriteAttributeValue("", 886, "/Administrador/Editar/", 886, 22, true);
#nullable restore
#line 34 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 908, item.Id, 908, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i> Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 981, "\"", 1022, 2);
            WriteAttributeValue("", 988, "/Administrador/Eliminar/", 988, 24, true);
#nullable restore
#line 35 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1012, item.Id, 1012, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-remove\"></i> Eliminar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1128, 2);
            WriteAttributeValue("", 1096, "/Administrador/Imagen/", 1096, 22, true);
#nullable restore
#line 36 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1118, item.Id, 1118, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-image\"></i> Imagen</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\PROGRAMACION-WEB\Practicas\PrograWeb-U3-EsmeraldaLopez\PrograWeb-U3-EsmeraldaLopez\ZooPlanet\Areas\Admin\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZooPlanet.Models.Especies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
