using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TenduShop.Model.Models
{
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get;}
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        [Required]
        public string Type { set; get; }
    }
}
