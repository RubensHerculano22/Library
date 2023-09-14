using Library.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    [Table("user")]
    public class User : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("active")]
        public int Active { get; set; }
        [Column("registerDate")]
        public DateTime RegisterDate { get; set; }
    }
}
