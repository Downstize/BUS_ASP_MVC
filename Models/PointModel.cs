using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class PointModel
{
    [Table("point")]
    public class Point
    {
        [Key]
        public int point_id { get; set; }

        [ForeignKey("Route")]
        public int route_number { get; set; }
        public RouteModel Route { get; set; }

        [ForeignKey("Stop")]
        public int stop_number { get; set; }
        public StopModel.Stop Stop { get; set; }

        public int index_number { get; set; }
    }
}