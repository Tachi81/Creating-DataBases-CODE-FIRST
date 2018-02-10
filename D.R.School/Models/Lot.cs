using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.R.School.Models
{
    [Table("Lot")]
    class Lot
    {
        public int LotId { get; set; }
        [Required]
        [StringLength(5)]
        public string NumerLotu { get; set; }
        [ForeignKey("Kierunek")]
        public int KierunekId { get; set; }
        public virtual Kierunek Kierunek { get; set; }
        public int SamolotId { get; set; }        
        [ForeignKey("SamolotId")]
        public virtual Samolot Samolot { get; set; }
        [Required]
        public DateTime DataOdlotu { get; set; }
        [Required]
        public DateTime DataPrzylotu{ get; set; }
    }
}
