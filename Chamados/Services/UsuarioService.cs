using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chamados.Entitys;
using MySql.Data.MySqlClient;

namespace Chamados.Services
{
    class UsuarioService
    {
        public UsuarioEntity obterPorId(int id)
        {
            var connection = Util.getConnection();
            var command = connection.CreateCommand();
            string idnumber;
            idnumber = "0";
            connection.Open();
            UsuarioEntity usuario = new UsuarioEntity();
            command.CommandText = "SELECT id, login, senha FROM usuarios WHERE id = " + id.ToString();
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
                throw new Exception("Usuário não encontrado");
            }
            connection.Close();
            return usuario;
        }

        public bool inserir(string login, string senha, string csenha)
        {
            if (senha != csenha)
            {
                throw new Exception("As senhas informadas não estao iguais.");
            }

            var connection = Util.getConnection();
            var command = connection.CreateCommand();

            connection.Open();
            command.CommandText = "" +
                "INSERT INTO usuarios (login, senha) " +
                "VALUES ('" + login + "', '" + csenha + "')";
            command.ExecuteNonQuery();
            return true;
        }

        public bool trocaSenha(int id, string novaSenha, string confirmacaoSenha)
        {
            if (novaSenha != confirmacaoSenha)
            {
                throw new Exception("As senhas informadas não estao iguais.");
            }

            var connection = Util.getConnection();
            var command = connection.CreateCommand();

            connection.Open();
            command.CommandText = "" +
                "UPDATE usuarios SET senha = '" + novaSenha + "' WHERE id = " + id.ToString();
            command.ExecuteNonQuery();
            return true;
        }
    }
}
