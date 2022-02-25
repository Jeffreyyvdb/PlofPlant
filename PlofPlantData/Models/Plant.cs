using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlofPlantData.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
    }
}
