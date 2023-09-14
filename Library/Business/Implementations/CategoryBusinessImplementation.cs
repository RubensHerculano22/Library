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
    public class CategoryBusinessImplementation : ICategoryBusiness
    {
        private readonly IRepository<Category> _repository;

        private readonly CategoryConverter _converter;

        public CategoryBusinessImplementation(IRepository<Category> repository)
        {
            _repository = repository;
            _converter = new CategoryConverter();
        }

        public List<CategoryVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public CategoryVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public CategoryVO Create(CategoryVO category)
        {
            var categoryEntity = _converter.Parse(category);
            categoryEntity = _repository.Create(categoryEntity);
            return _converter.Parse(categoryEntity);
        }
        public CategoryVO Update(CategoryVO category)
        {
            var categoryEntity = _converter.Parse(category);
            categoryEntity = _repository.Update(categoryEntity);
            return _converter.Parse(categoryEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
