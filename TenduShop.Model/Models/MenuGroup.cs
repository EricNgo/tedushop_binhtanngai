using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TenduShop.Model.Models
{

    [Table("MenuGroups")]
    class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }


        public virtual IEnumerable<Menu> Menus { get; set; }

    
    }
}
