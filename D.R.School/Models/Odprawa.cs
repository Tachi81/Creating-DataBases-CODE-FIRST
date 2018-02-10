using System.Collections.Generic;

namespace D.R.School.Models
{
    public class Odprawa
    {
        public int OdprawaId { get; set; }
        public int NumerBramki { get; set; }
        public ICollection<OdprawaPasazer> OdprawyPasazerow { get; set; }
    }
}