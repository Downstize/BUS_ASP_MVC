using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

[Table("route")]
public class RouteModel
{
  
    
        [Key]
        public int route_number { get; set; }

        [ForeignKey("TransportCompany")]
        public string company_name { get; set; }
        public TransportCompanyModel.TransportCompany TransportCompany { get; set; }

        public int route_length { get; set; }
        public TimeSpan route_time { get; set; }
    
}