using Library.Data.Converter.Contract;
using Library.Model;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data.Converter.Implementations
{
    public class RentConverter : IParser<RentVO, Rent>, IParser<Rent, RentVO> 
    {

        public Rent Parse(RentVO origin)
        {
            if (origin == null) return null;

            return new Rent
            {
                Id = origin.Id,
                IdUser = origin.IdUser,
                IdBook = origin.IdBook,
                RentDate = origin.RentDate,
                DevolutionPlanDate = origin.DevolutionPlanDate,
                DevolutionDate = origin.DevolutionDate
            };
        }

        public List<Rent> Parse(List<RentVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public RentVO Parse(Rent origin)
        {
            return new RentVO
            {
                Id = origin.Id,
                IdUser = origin.IdUser,
                IdBook = origin.IdBook,
                RentDate = origin.RentDate,
                DevolutionPlanDate = origin.DevolutionPlanDate,
                DevolutionDate = origin.DevolutionDate
            };
        }

        public List<RentVO> Parse(List<Rent> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
