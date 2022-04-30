using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P2_2019MH604_2019ZH601.Models
{
    public class Departamentos
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Departamento { get; set; }
    }
}
