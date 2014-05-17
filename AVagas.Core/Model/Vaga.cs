using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVagas.Core.Model
{
    public class Vaga
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public bool Coberto { get; set; }
        public bool Disponivel { get; set; }
        public decimal Valor { get; set; }
        public string Foto { get; set; }
    }
}
