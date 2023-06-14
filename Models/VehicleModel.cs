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
        public string model_name { get; set; }
        public int route_number { get; set; }
        public string vh_condition { get; set; }
        public int capacity { get; set; }
    }
}