using Financeiro.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.Models
{
    public class TransacaoModel
    {


        public int idTransacao { get; set; }
        [Required(ErrorMessage = "Informe a Data !!!")]
        public string Data_Trans { get; set; }
        public string Tipo_Trans { get; set; }
        public string Valor_Trans { get; set; }
        [Required(ErrorMessage = "Informe a Descrição !!!")]
        public string Descricao_Trans { get; set; }
        public int Conta_idConta { get; set; }
        public string Nome_Conta { get; set; }

        public int Plano_Contas_idPlano { get; set; }
        public string Descricao_Plano_Conta { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public TransacaoModel()
        {

        }
        //Recendo o contexto para acessar as variaveis de sessão
        public TransacaoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<TransacaoModel> ListaTransacao()
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            TransacaoModel item;

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = "select t.idTransacao, t.Data_Trans, t.Tipo_Trans,t.Descricao_Trans as Historico, t.Conta_idConta, c.nome as Conta, t.Plano_Contas_idPlano, p.descricao as Plano_Contas" +
                          "from transacao as t  inner join conta c " +
                          "on t.conta_idconta = c.idConta inner join Plano_Contas p" +
                          "on t.Plano_Contas_idPlano = p.idPlano" +
                          $"where t.usuario_id_trans = {id_usuario_logado}";


            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new TransacaoModel();
                item.idTransacao = int.Parse(dt.Rows[i]["IDTRANSACO"].ToString());
                item.Data_Trans = dt.Rows[i]["DATA_TRANS"].ToString();
                item.Descricao_Trans = dt.Rows[i]["HISTORICO"].ToString();
                item.Conta_idConta = int.Parse(dt.Rows[i]["CONTA_IDCONTA"].ToString());
                item.Nome_Conta = dt.Rows[i]["CONTA"].ToString();
                item.Plano_Contas_idPlano = int.Parse(dt.Rows[i]["PLANO_CONTAS_IDPLANO"].ToString());
                item.Descricao_Plano_Conta = dt.Rows[i]["PLANO_CONTAS"].ToString();
                lista.Add(item);

            }
            return lista;
        }
    }
}
