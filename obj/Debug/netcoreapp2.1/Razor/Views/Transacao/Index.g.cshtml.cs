#pragma checksum "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3a0a303e5c3375cd70c3510868f3d8a2d62a093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Index), @"mvc.1.0.view", @"/Views/Transacao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Index.cshtml", typeof(AspNetCore.Views_Transacao_Index))]
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
#line 1 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\_ViewImports.cshtml"
using Financeiro;

#line default
#line hidden
#line 2 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\_ViewImports.cshtml"
using Financeiro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3a0a303e5c3375cd70c3510868f3d8a2d62a093", @"/Views/Transacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24062242909bd6dcec09cba3787d3ef76caf28e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 430, true);
            WriteLiteral(@"
<h3>Minhas Transações de Contas </h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>idTransacao</th>
            <th>Data_Trans</th>
            <th>Tipo_Trans </th>
            <th>Valor_Trans</th>
            <th>Historico</th>
            <th>Conta_idConta</th>
            <th>Plano_Contas </th>

        </tr>
    </thead>


");
            EndContext();
#line 25 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
      
        foreach (var item in (List<TransacaoModel>)ViewBag.ListaTransacao)
        {

#line default
#line hidden
            BeginContext(568, 112, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 680, "\"", 726, 3);
            WriteAttributeValue("", 690, "Editar(", 690, 7, true);
#line 30 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
WriteAttributeValue("", 697, item.idTransacao.ToString(), 697, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 725, ")", 725, 1, true);
            EndWriteAttribute();
            BeginContext(727, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 818, "\"", 865, 3);
            WriteAttributeValue("", 828, "Excluir(", 828, 8, true);
#line 31 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
WriteAttributeValue("", 836, item.idTransacao.ToString(), 836, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 864, ")", 864, 1, true);
            EndWriteAttribute();
            BeginContext(866, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(915, 27, false);
#line 32 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                   Write(item.idTransacao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(942, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(974, 26, false);
#line 33 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                   Write(item.Data_Trans.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1000, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1032, 26, false);
#line 34 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                   Write(item.Tipo_Trans.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1058, 34, true);
            WriteLiteral("</td>\r\n                    <td>R$ ");
            EndContext();
            BeginContext(1093, 75, false);
#line 35 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                      Write(item.Valor_Trans.ToString().Replace("R", "Receita").Replace("D", "Despesa"));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1200, 31, false);
#line 36 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                   Write(item.Descricao_Trans.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1231, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1263, 26, false);
#line 37 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                   Write(item.Nome_Conta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1289, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1321, 37, false);
#line 38 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
                   Write(item.Descricao_Plano_Conta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1358, 54, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n            </tbody>\r\n");
            EndContext();
#line 42 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\Transacao\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1430, 467, true);
            WriteLiteral(@"

</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""RegistrarTransacao()"">Criar Plano de Conta </button>

<script>
    function RegistrarTransacao() { window.location.href = ""../Transacao/Registrar""; } 
    function Excluir(idTransacao) { window.location.href = ""../Transacao/ExcluirTransacao/"" + idTransacao; }
    function Editar(idTransacao) { window.location.href = ""../Transacao/Registrar/""; + idTransacao }

</script>



");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
