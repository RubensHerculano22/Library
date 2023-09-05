using System;

namespace Library.Model
{
    public class BookVO
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime AlterDate { get; set; }

        public int IdCategory { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
