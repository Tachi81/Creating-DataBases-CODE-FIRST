using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.R.School.Models
{
    class Zalogant
    {
        [Key]
        public string ZalogantId { get; set; }
        [Required]
        [StringLength(11)]
        public string Pesel { get; set; }
        [Required]
        public Stanowisko StanowiskoId { get; set; }
        [Required]
        public DateTime DataZatrudnienia { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public int NrTelefonu { get; set; }



    }
}
