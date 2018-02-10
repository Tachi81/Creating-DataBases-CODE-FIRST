using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.R.School.Models
{
    [Table("Kierunek")]
    class Kierunek
    {
        public int KierunekId { get; set; }
        [Required]
        [StringLength (50)]
        public string MiejsceOdlotu { get; set; }
        [Required]
        [StringLength(50)]
        public string MiejscePrzylotu { get; set; }
    }
}
