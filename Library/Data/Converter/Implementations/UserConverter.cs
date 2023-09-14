using Library.Data.Converter.Contract;
using Library.Model;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data.Converter.Implementations
{
    public class UserConverter : IParser<UserVO, User>, IParser<User, UserVO> 
    {

        public User Parse(UserVO origin)
        {
            if (origin == null) return null;

            return new User
            {
                Id = origin.Id,
                Name = origin.Name,
                Email = origin.Email,
                Password = origin.Password,
                Active = origin.Active,
                RegisterDate = origin.RegisterDate
            };
        }

        public List<User> Parse(List<UserVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public UserVO Parse(User origin)
        {
            return new UserVO
            {
                Id = origin.Id,
                Name = origin.Name,
                Email = origin.Email,
                Password = origin.Password,
                Active = origin.Active,
                RegisterDate = origin.RegisterDate
            };
        }

        public List<UserVO> Parse(List<User> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
