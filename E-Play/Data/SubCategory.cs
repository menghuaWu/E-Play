using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// 次類別Table
/// </summary>
namespace E_Play.Data
{
    public class SubCategory
    {
        [Key]
        [DisplayName("編號")]
        public int Id { get; set; }

        [DisplayName("次類別")]
        public string Name { get; set; }

        

        public int MainCategoryId { get; set; }
        public virtual MainCategory MainCategory { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}
