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
    public class PlanoContaModel
    {

        public int IdPlano { get; set; }
        [Required(ErrorMessage = "Informe a Descrição !!!")]
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public int Usuario_id { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public PlanoContaModel()
        {

        }
        //Recendo o contexto para acessar as variaveis de sessão
        public PlanoContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<PlanoContaModel> ListaPlanoConta()
        {
            List<PlanoContaModel> lista = new List<PlanoContaModel>();
            PlanoContaModel item;

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT IDPLANO, DESCRICAO, TIPO, USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = {id_usuario_logado}";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            for (int i=0; i < dt.Rows.Count;i++)
            {
                item = new PlanoContaModel();
                item.IdPlano = int.Parse(dt.Rows[i]["IDPLANO"].ToString());
                item.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                item.Tipo = dt.Rows[i]["TIPO"].ToString();
                item.Usuario_id = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());
                lista.Add(item);

            }
            return lista;
        }
        public void Insert()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $" INSERT INTO PLANO_CONTAS (DESCRICAO, TIPO, USUARIO_ID)VALUES('{Descricao}','{Tipo}','{id_usuario_logado}')";
            DAL objDAJ= new DAL();
            objDAJ.ExecultarComandosSQL(sql);

        }
        public void Excluir(int id_conta)
        {
            new DAL().ExecultarComandosSQL("DELETE FROM PLANO_CONTAS WHERE IDPLANO = " + id_conta);

        }
    }
  }

