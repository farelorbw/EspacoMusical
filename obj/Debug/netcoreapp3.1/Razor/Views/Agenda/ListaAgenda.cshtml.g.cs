#pragma checksum "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7465eb0dc4c2f438915cffa75665bc11711b8cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agenda_ListaAgenda), @"mvc.1.0.view", @"/Views/Agenda/ListaAgenda.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7465eb0dc4c2f438915cffa75665bc11711b8cb8", @"/Views/Agenda/ListaAgenda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a22a34fd76494270d8addd68ab1e0185cd395f98", @"/Views/_ViewImports.cshtml")]
    public class Views_Agenda_ListaAgenda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Agenda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
  
    ViewData["Title"] = "ListaAgenda";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Telefone</th>
            <th>Data</th>
            <th>Instrumento</th>
            <th>Necessidade</th>
            <th>Usuário</th>
        </tr>
    </thead>

");
#nullable restore
#line 20 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
     foreach (Agenda u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
           Write(u.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
           Write(u.Instrumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
           Write(u.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
           Write(u.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 701, 2);
            WriteAttributeValue("", 672, "/Agenda/EditarAgenda?Id=", 672, 24, true);
#nullable restore
#line 31 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
WriteAttributeValue("", 696, u.Id, 696, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 734, "\"", 771, 2);
            WriteAttributeValue("", 741, "/Agenda/RemoverAgenda?Id=", 741, 25, true);
#nullable restore
#line 32 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
WriteAttributeValue("", 766, u.Id, 766, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\farel\Desktop\SENAC\Projeto Integrador MA\Projeto Integrador MA\atividade 4\espacomusical\Views\Agenda\ListaAgenda.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Agenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
