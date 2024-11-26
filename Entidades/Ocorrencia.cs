using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Ocorrencias")]
    public class Ocorrencia
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataDaOcorrencia { get; set; }
        public string Descricao { get; set; }
        public int ClienteId1 { get; set; }
        public int ClienteId2 { get; set; }
        public string Conclusao { get; set; }
    }
}
