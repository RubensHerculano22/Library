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
    public class RentBusinessImplementation : IRentBusiness
    {
        private readonly IRepository<Rent> _repository;

        private readonly RentConverter _converter;

        public RentBusinessImplementation(IRepository<Rent> repository)
        {
            _repository = repository;
            _converter = new RentConverter();
        }

        public List<RentVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public RentVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public RentVO Create(RentVO rent)
        {
            var rentEntity = _converter.Parse(rent);
            rentEntity = _repository.Create(rentEntity);
            return _converter.Parse(rentEntity);
        }
        public RentVO Update(RentVO rent)
        {
            var rentEntity = _converter.Parse(rent);
            rentEntity = _repository.Update(rentEntity);
            return _converter.Parse(rentEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
