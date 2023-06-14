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
        public int route_number { get; set; }
        public int stop_number { get; set; }
        public int index_number { get; set; }
    }
}