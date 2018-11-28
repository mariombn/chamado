using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chamados.Entitys;
using MySql.Data.MySqlClient;

namespace Chamados.Services
{
    public class ChamadoService
    {
        public bool criarChamado(string titulo, string descricao, int usuarioId)
        {
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            string data = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("HH:mm");

            connection.Open();
            command.CommandText = "" +
                "INSERT INTO chamados (titulo, descricao, criacao_data, criacao_hora, criacao_user_id) " +
                "VALUES ('" + titulo + "', '" + descricao + "', '" + data + "', '" + hora + "', " + usuarioId.ToString() + ")";
            command.ExecuteNonQuery();
            return true;
        }

        public List<ChamadoEntity> listarTodos()
        {
            List<ChamadoEntity> chamados = new List<ChamadoEntity>();
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            string idnumber;
            idnumber = "0";
            connection.Open();
            
            command.CommandText = "SELECT id, titulo, descricao, status, criacao_data, criacao_hora, criacao_user_id, user_id FROM chamados ORDER BY status";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ChamadoEntity chamado = new ChamadoEntity();
                    chamado.id = Int32.Parse(reader.GetValue(0).ToString());
                    chamado.titulo = reader.GetValue(1).ToString();
                    chamado.descricao = reader.GetValue(2).ToString();
                    chamado.status = reader.GetValue(3).ToString();
                    chamado.criacaoData = reader.GetValue(4).ToString();
                    chamado.criacaoHora = reader.GetValue(5).ToString();
                    chamado.criacaoUserId = Int32.Parse(reader.GetValue(6).ToString());
                    //chamado.userId = Int32.Parse(reader.GetValue(7).ToString()); // TODO: Precisa ver como fazer para tratar o valor que está NULL no banco
                    chamados.Add(chamado);
                }
            }
            else
            {
                throw new Exception("Nenhum Chamado Encontrado");
            }

            return chamados;
        }

        public ChamadoEntity obterPorId(int id)
        {
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            string idnumber;
            idnumber = "0";
            connection.Open();
            ChamadoEntity chamado = new ChamadoEntity();
            command.CommandText = "SELECT id, titulo, descricao, status, criacao_data, criacao_hora, criacao_user_id, user_id FROM chamados WHERE id = " + id.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    chamado.id = Int32.Parse(reader.GetValue(0).ToString());
                    chamado.titulo = reader.GetValue(1).ToString();
                    chamado.descricao = reader.GetValue(2).ToString();
                    chamado.status = reader.GetValue(3).ToString();
                    chamado.criacaoData = reader.GetValue(4).ToString();
                    chamado.criacaoHora = reader.GetValue(5).ToString();
                    chamado.criacaoUserId = Int32.Parse(reader.GetValue(6).ToString());
                    if (reader.GetValue(7).ToString() != "")
                    {
                        chamado.userId = Int32.Parse(reader.GetValue(7).ToString());
                    } else
                    {
                        chamado.userId = 0;
                    }
                }
            }
            else
            {
                throw new Exception("Chamado não encontrado");
            }
            connection.Close();
            return chamado;
        }

        public bool atendeChamado(int chamadoId, int userId)
        {
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            string data = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("HH:mm");

            connection.Open();
            command.CommandText = "" +
                "UPDATE chamados SET status = 'atendimento', user_id = " + userId.ToString() + " WHERE id = " + chamadoId.ToString();
            command.ExecuteNonQuery();
            return true;
        }

        public bool fechaChamado(int chamadoId)
        {
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            string data = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("HH:mm");

            connection.Open();
            command.CommandText = "" +
                "UPDATE chamados SET status = 'fechado' WHERE id = " + chamadoId.ToString();
            command.ExecuteNonQuery();
            return true;
        }
    }
}
