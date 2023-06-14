using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bus_project.Models;

public class TransportCompanyModel
{
    [Table("transport_company")]
    public class TransportCompany
    {
        [Key]
        public string company_name { get; set; }
        public string contact_info { get; set; }
        public string address { get; set; }
    }
}