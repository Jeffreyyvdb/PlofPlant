using System.ComponentModel.DataAnnotations;

namespace PlofPlantData.Models
{
    public class VerdiepingData
    {
        [Key]
        public int Id { get; set; }
        public int VerdiepingId { get; set; }
        public double Ph { get; set; }
        public double Ec { get; set; }
        public double WaterLevel { get; set; }
        public double LichtLevel { get; set; }
        public DateTime DatumToegevoegd { get; set; }

    }
}