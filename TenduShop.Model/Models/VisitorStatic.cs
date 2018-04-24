using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TenduShop.Model.Models
{
    [Table("VisitorStatics")]
    public class VisitorStatic
    {
        [Key]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisitedDate { set; get; }

        [MaxLength(50)]
        public string IpAdress { set; get; }

    }
}
