using Library.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    [Table("book")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("registerDate")]
        public DateTime RegisterDate { get; set; }
        [Column("alterDate")]
        public DateTime AlterDate { get; set; }
        [Column("idCategory")]
        public int IdCategory { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("publishDate")]
        public DateTime PublishDate { get; set; }
    }
}
