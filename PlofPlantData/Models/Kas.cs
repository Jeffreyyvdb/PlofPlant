using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlofPlantData.Models
{
    public class Kas
    {
        public Kas()
        {
            Verdiepingen = new List<Verdieping>();
            KasData = new List<KasData>();
        }

        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
      
        public ICollection<Verdieping> Verdiepingen { get; set; }
        public ICollection<KasData> KasData { get; set; }

    }
}
