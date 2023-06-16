using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class VehicleModel
{
    [Table("vehicle")]
    public class Vehicle
    {
        [Key] 
        public int reg_number { get; set; }

        [ForeignKey("Model")]
        public string model_name { get; set; }

        [ForeignKey("Route")] 
        public int route_number { get; set; }


        [Required] 
        public string vh_condition { get; set; }

        [Required] 
        public int capacity { get; set; }
    }
    
}