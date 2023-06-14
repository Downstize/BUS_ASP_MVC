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
        public string license { get; set; }
        public int route_number { get; set; }
        public string driver_name { get; set; }
        public string driver_surname { get; set; }
        public string driver_third_name { get; set; }
        public int experience { get; set; }
        public string gender { get; set; }
        public string driver_age { get; set; }
        public string telephone_number { get; set; }
    }
}