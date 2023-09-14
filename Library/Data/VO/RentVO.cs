using System;

namespace Library.Model
{
    public class RentVO
    {
        public long Id { get; set; }

        public int IdUser { get; set; }

        public int IdBook { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime DevolutionPlanDate { get; set; }

        public DateTime? DevolutionDate { get; set; }
    }
}
