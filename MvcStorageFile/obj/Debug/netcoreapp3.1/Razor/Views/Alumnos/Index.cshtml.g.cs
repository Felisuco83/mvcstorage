#pragma checksum "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7422bad31b0d1377dfa1cecc8fe97dd14cb30b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumnos_Index), @"mvc.1.0.view", @"/Views/Alumnos/Index.cshtml")]
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
#line 1 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\_ViewImports.cshtml"
using MvcStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\_ViewImports.cshtml"
using MvcStorage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7422bad31b0d1377dfa1cecc8fe97dd14cb30b", @"/Views/Alumnos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a368969d3fb8cee6402a915191a639dc7523e6d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumnos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcStorage.Models.Alumno>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d7422bad31b0d1377dfa1cecc8fe97dd14cb30b3815", async() => {
                WriteLiteral("\r\n    <label>Introduzca curso</label>\r\n    <input type=\"text\" name=\"curso\" class=\"form-control\" />\r\n    <button type=\"submit\" class=\"btn btn-info\">\r\n        Buscar alumnos\r\n    </button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-info\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.IdAlumno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PartitionKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.RowKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ETag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdAlumno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PartitionKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RowKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ETag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 85 "C:\Users\Teteman\Source\Repos\mvcstorage\MvcStorageFile\Views\Alumnos\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcStorage.Models.Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
