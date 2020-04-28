using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// 主類別Table
/// </summary>
namespace E_Play.Data
{
    public class MainCategory
    {
        [Key]
        [DisplayName("編號")]
        public int Id { get; set; }


        [DisplayName("主類別")]
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }

    }
}
