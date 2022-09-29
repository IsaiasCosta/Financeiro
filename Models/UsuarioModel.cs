using Financeiro.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe seu Nome !!!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe seu Email !!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe sua Senha!!!")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe sua Data de Nascimento !!!")]
        public string Data_Nasc { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT IDUSUARIO, NOME,EMAIL,SENHA, DATA_NASC FROM USUARIO WHERE EMAIL='{Email}' AND SENHA='{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    IdUsuario = int.Parse(dt.Rows[0]["IDUSUARIO"].ToString());
                    Nome = dt.Rows[0]["NOME"].ToString();
                    Data_Nasc = (dt.Rows[0]["DATA_NASC"].ToString());
                    return true;
                }
            }
            return false;
        }

        public void RegistrarUsuario()
        {

            string dataNascimento = DateTime.Parse(Data_Nasc).ToString("yyyy/MM/dd");
            string sql = $"INSERT INTO USUARIO (NOME,EMAIL,SENHA, DATA_NASC) VALUES ('{Nome}','{Email}','{Senha}','{dataNascimento}')";
            DAL objDAL = new DAL();
            objDAL.ExecultarComandosSQL(sql);

        }
    }
}
