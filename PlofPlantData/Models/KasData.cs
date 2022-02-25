using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlofPlantData.Models
{
    public class KasData
    {
        [Key]
        public int Id { get; set; }
        public int KasId { get; set; }
        public double Temp { get; set; }
        public double Co2 { get; set; }
        public double Luchtvochtigheid { get; set; }
        public bool IsDeurOpen { get; set; }
        public DateTime DatumToegevoegd { get; set; }
    }
}
