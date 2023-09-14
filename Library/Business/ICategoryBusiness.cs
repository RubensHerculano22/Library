using Library.Model;
using System.Collections.Generic;

namespace Library.Business
{
    public interface ICategoryBusiness
    {
        CategoryVO Create(CategoryVO book);

        CategoryVO FindById(long id);

        List<CategoryVO> FindAll();

        CategoryVO Update(CategoryVO book);

        void Delete(long id);
    }
}
