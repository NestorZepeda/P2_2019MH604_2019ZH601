using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_2019MH604_2019ZH601.Models
{
    public class Generos
    {
        [Key]
        public int IdGenero { get; set; }
        public string Genero { get; set; }
    }
}
