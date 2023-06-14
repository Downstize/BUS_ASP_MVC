using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class StopModel
{
    [Table("stop")]
    public class Stop
    {
        [Key]
        public int stop_number { get; set; }
        public string stop_name { get; set; }
        public string coordinates { get; set; }
    }
}