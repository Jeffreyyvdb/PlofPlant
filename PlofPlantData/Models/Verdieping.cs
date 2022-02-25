using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlofPlantData.Models
{
    public class Verdieping
    {
        public Verdieping()
        {
            VerdiepingData = new List<VerdiepingData>();
            Planten = new List<Plant>();
        }

        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public ICollection<Plant> Planten { get; set; }
        public ICollection<VerdiepingData> VerdiepingData { get; set; }
    }
}
