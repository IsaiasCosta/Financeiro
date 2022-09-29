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
    public class ContaModel
    {
        public int IdConta { get; set; }
        [Required(ErrorMessage = "Informe o nome do banco ou instuição financeira !!!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o valor a ser adicionado na conta !!!")]
        public string Saldo { get; set; }
        public int Usuario_IdUsuario { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public ContaModel()
        {

        }
        // REcebe o consteto paraacesso avariaveis de sessão
        public ContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<ContaModel> ListaConta()
        {
            List<ContaModel> lista = new List<ContaModel>();
            ContaModel item;
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT IDCONTA, NOME,SALDO,USUARIO_IDUSUARIO FROM CONTA WHERE  USUARIO_IDUSUARIO ={id_usuario_logado}";

            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ContaModel();

                item.IdConta = int.Parse(dt.Rows[i]["IDCONTA"].ToString());
                item.Nome = dt.Rows[i]["NOME"].ToString();
                item.Saldo = dt.Rows[i]["SALDO"].ToString();
                item.Usuario_IdUsuario = int.Parse(dt.Rows[i]["USUARIO_IDUSUARIO"].ToString());

                lista.Add(item);
            }
            return lista;

        }

        public void Insert()

        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO CONTA (NOME,SALDO,USUARIO_IDUSUARIO)VALUES ('{Nome}','{Saldo}','{id_usuario_logado}')";
            DAL objDAL = new DAL();
            objDAL.ExecultarComandosSQL(sql);

        }

        public void Excluir(int IdConta)
        {
            new DAL().ExecultarComandosSQL("DELETE FROM CONTA  WHERE IDCONTA = " + IdConta);

        }
    }
}
