#pragma checksum "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc78135f87fa8efe3437d4a151e1e72c2aad1ff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlanoConta_Index), @"mvc.1.0.view", @"/Views/PlanoConta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlanoConta/Index.cshtml", typeof(AspNetCore.Views_PlanoConta_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc78135f87fa8efe3437d4a151e1e72c2aad1ff5", @"/Views/PlanoConta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24062242909bd6dcec09cba3787d3ef76caf28e6", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoConta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(45, 262, true);
            WriteLiteral(@"
<h3>Plano de Contas </h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>ID</th>
            <th>Descri????o</th>
            <th>Tipo </th>
        </tr>
    </thead>


");
            EndContext();
#line 21 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
      
        foreach (var item in (List<PlanoContaModel>)ViewBag.ListaPlanoConta)
        {

#line default
#line hidden
            BeginContext(404, 112, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 516, "\"", 558, 3);
            WriteAttributeValue("", 526, "Editar(", 526, 7, true);
#line 26 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 533, item.IdPlano.ToString(), 533, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 557, ")", 557, 1, true);
            EndWriteAttribute();
            BeginContext(559, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 650, "\"", 693, 3);
            WriteAttributeValue("", 660, "Excluir(", 660, 8, true);
#line 27 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 668, item.IdPlano.ToString(), 668, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 692, ")", 692, 1, true);
            EndWriteAttribute();
            BeginContext(694, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(743, 23, false);
#line 28 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
                   Write(item.IdPlano.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(766, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(798, 25, false);
#line 29 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
                   Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(823, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(855, 66, false);
#line 30 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
                   Write(item.Tipo.ToString().Replace("R","Receita").Replace("D","Despesa"));

#line default
#line hidden
            EndContext();
            BeginContext(921, 52, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n");
            EndContext();
#line 33 "C:\Users\IcsDevTec\source\repos\Financeiro\Financeiro\Views\PlanoConta\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(991, 464, true);
            WriteLiteral(@"

</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarPlanoConta()"">Criar Plano de Conta </button>

<script>
    function CriarPlanoConta() { window.location.href = ""../PlanoConta/CriarPlanoConta""; }
    function Editar(id_conta) { window.location.href = ""../PlanoConta/CriarPlanoConta/""; + id_conta }
    function Excluir(id_conta) { window.location.href = ""../PlanoConta/ExcluirPlanoConta/"" + id_conta; }

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
