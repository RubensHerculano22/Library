using Library.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    [Table("rent")]
    public class Rent : BaseEntity
    {
        [Column("idUser")]
        public int IdUser { get; set; }
        [Column("idBook")]
        public int IdBook { get; set; }
        [Column("rentDate")]
        public DateTime RentDate { get; set; }
        [Column("devolutionPlanDate")]
        public DateTime DevolutionPlanDate { get; set; }
        [Column("devolutionDate")]
        public DateTime? DevolutionDate { get; set; }
    }
}
