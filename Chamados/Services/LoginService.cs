using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chamados.Entitys;
using MySql.Data.MySqlClient;

namespace Chamados.Services
{
    class LoginService
    {
        public UsuarioEntity efetuarLogin(string login, string senha)
        {
            var connection = Util.getConnection();
            var command = connection.CreateCommand();
            string idnumber;
            idnumber = "0";
            connection.Open();
            UsuarioEntity usuario = new UsuarioEntity();
            command.CommandText = "SELECT id, login, senha FROM usuarios WHERE login = '" + login + "' AND senha = '" + senha + "'";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuario.id = Int32.Parse(reader.GetValue(0).ToString());
                    usuario.login = reader.GetValue(1).ToString();
                    usuario.senha = reader.GetValue(2).ToString();
                }
            }
            else
            {
                throw new Exception("Usuário ou senha invalidos");
            }

            return usuario;
        }
    }
}
