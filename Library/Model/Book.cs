using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Book
    {
        public long id { get; set; }
        public string title { get; set; }
        public int idGenre { get; set; }
        public int year { get; set; }
    }
}
