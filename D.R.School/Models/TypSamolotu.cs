using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.R.School.Models
{
    [Table("TypSamolotu")]
    class TypSamolotu
    {
        [Key]
        public int TypId { get; set; }

        public string Nazwa { get; set; }
        public int IloscMiejsc { get; set; }

        public ICollection<Samolot> Samoloty { get; set; }
    }
}
