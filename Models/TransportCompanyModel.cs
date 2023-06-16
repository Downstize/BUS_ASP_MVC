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

        [Required] 
        public string contact_info { get; set; }

        [Required] 
        public string address { get; set; }
    }
}

