using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.R.School.Models
{
    class Stanowisko
    {
        [Key]
        public string StanowiskoId { get; set; }
        public string NazwaStanowiska { get; set; }
    }
}
