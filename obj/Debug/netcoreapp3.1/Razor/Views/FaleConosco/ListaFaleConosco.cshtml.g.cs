#pragma checksum "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4939594aae27fab868420b4049842efe9659d88f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FaleConosco_ListaFaleConosco), @"mvc.1.0.view", @"/Views/FaleConosco/ListaFaleConosco.cshtml")]
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
#line 1 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\_ViewImports.cshtml"
using espacomusical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\_ViewImports.cshtml"
using espacomusical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4939594aae27fab868420b4049842efe9659d88f", @"/Views/FaleConosco/ListaFaleConosco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a22a34fd76494270d8addd68ab1e0185cd395f98", @"/Views/_ViewImports.cshtml")]
    public class Views_FaleConosco_ListaFaleConosco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FaleConosco>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
  
    ViewData["Title"] = "ListaFaleConosco";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"shadow-lg p-3 mb-5 bg-white rounded\">");
#nullable restore
#line 6 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
                                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Telefone</th>
            <th>Email</th>
            <th>Data</th>
            <th>Necessidade</th>

        </tr>
    </thead>

");
#nullable restore
#line 21 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
     foreach (FaleConosco u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
           Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
           Write(u.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
           Write(u.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
           Write(u.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 747, 2);
            WriteAttributeValue("", 707, "/FaleConosco/RemoverFaleConosco?Id=", 707, 35, true);
#nullable restore
#line 33 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
WriteAttributeValue("", 742, u.Id, 742, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\FaleConosco\ListaFaleConosco.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FaleConosco>> Html { get; private set; }
    }
}
#pragma warning restore 1591
