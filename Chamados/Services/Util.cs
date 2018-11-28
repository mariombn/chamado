using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Chamados.Services
{
    public class Util
    {
        public static MySqlConnection getConnection()
        {
            var connString = "Server=localhost;Database=chamado;Uid=root;Pwd=local";
            var connection = new MySqlConnection(connString);
            return connection;
        }
    }
}
