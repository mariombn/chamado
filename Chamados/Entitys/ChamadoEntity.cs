using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamados.Entitys
{
    public class ChamadoEntity
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string status { get; set; }
        public string criacaoData { get; set; }
        public string criacaoHora { get; set; }
        public int criacaoUserId { get; set; }
        public int userId { get; set; }
    }
}
