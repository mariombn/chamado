﻿using System;
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
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
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
    }
}