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
        public string RegisterDate { get; set; }
        [Column("alterDate")]
        public string AlterDate { get; set; }
        [Column("idCategory")]
        public string IdCategory { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("publishDate")]
        public string PublishDate { get; set; }
    }
}
