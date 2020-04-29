using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Play.Data
{
    public class Product
    {
        [Key]
        [DisplayName("編號")]
        public int Id { get; set; }

        [DisplayName("品名")]
        public string Name { get; set; }


        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
