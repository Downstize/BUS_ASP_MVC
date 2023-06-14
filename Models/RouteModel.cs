using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class RouteModel
{
    [Table("route")]
    public class Route
    {
        [Key]
        public int route_number { get; set; }
        public string company_name { get; set; }
        public int route_length { get; set; }
        public TimeSpan route_time { get; set; }
    }
}