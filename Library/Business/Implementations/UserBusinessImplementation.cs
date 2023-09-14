using Library.Data.Converter.Implementations;
using Library.Model;
using Library.Model.Context;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Business.Implementations
{
    public class UserBusinessImplementation : IUserBusiness
    {
        private readonly IRepository<User> _repository;

        private readonly UserConverter _converter;

        public UserBusinessImplementation(IRepository<User> repository)
        {
            _repository = repository;
            _converter = new UserConverter();
        }

        public List<UserVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public UserVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public UserVO Create(UserVO user)
        {
            var userEntity = _converter.Parse(user);
            userEntity = _repository.Create(userEntity);
            return _converter.Parse(userEntity);
        }
        public UserVO Update(UserVO user)
        {
            var userEntity = _converter.Parse(user);
            userEntity = _repository.Update(userEntity);
            return _converter.Parse(userEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
