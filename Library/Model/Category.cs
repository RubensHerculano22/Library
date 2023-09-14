using Library.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    [Table("category")]
    public class Category : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
    }
}
