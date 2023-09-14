using Library.Model;
using System.Collections.Generic;

namespace Library.Business
{
    public interface IRentBusiness
    {
        RentVO Create(RentVO book);

        RentVO FindById(long id);

        List<RentVO> FindAll();

        RentVO Update(RentVO book);

        void Delete(long id);
    }
}
