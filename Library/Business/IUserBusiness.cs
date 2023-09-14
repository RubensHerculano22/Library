using Library.Model;
using System.Collections.Generic;

namespace Library.Business
{
    public interface IUserBusiness
    {
        UserVO Create(UserVO book);

        UserVO FindById(long id);

        List<UserVO> FindAll();

        UserVO Update(UserVO book);

        void Delete(long id);
    }
}
