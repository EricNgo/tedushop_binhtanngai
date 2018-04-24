using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TenduShop.Model.Models
{
    [Table("ORDERS")]
    class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAdress { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMobile { get; set; }


        [Required]
        public string CusomterMessage { get; set; }
        [Required]
        public string CreatedDate { get; set; }
        [Required]
        public string CreateBy { get; set; }

        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentStatus { get; set; }
        [Required]
        public bool Status { get; set; }


    }
}
