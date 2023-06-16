using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class DriverModel
{
    [Table("driver")]
 
        public class Driver
    {
        [Key]
        public int driver_shift_id { get; set; }

    [Required]
    public string license { get; set; }

    [ForeignKey("Route")]
    public int route_number { get; set; }
    public RouteModel Route { get; set; }

    [Required]
    public string driver_name { get; set; }

    [Required]
    public string driver_surname { get; set; }

    [Required]
    public string driver_third_name { get; set; }

    [Required]
    public int experience { get; set; }

    [Required]
    public string gender { get; set; }

    [Required]
    public string driver_age { get; set; }

    [Required]
    public string telephone_number { get; set; }
}
}

