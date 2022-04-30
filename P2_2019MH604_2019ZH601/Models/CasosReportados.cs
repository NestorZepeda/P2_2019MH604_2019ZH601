using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_2019MH604_2019ZH601.Models
{
    public class CasosReportados
    {

        [Key]
        public int idCReportado { get; set; }
        public int IdDpartamento { get; set; }
        public int IdGenero { get; set; }

        public string confirmados { get; set; }
        public string recuperados { get; set; }
        public string fallecidos { get; set; }


    }
}
