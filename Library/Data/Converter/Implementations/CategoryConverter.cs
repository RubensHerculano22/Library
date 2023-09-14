using Library.Data.Converter.Contract;
using Library.Model;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data.Converter.Implementations
{
    public class CategoryConverter : IParser<CategoryVO, Category>, IParser<Category, CategoryVO> 
    {

        public Category Parse(CategoryVO origin)
        {
            if (origin == null) return null;

            return new Category
            {
                Id = origin.Id,
                Name = origin.Name
            };
        }

        public List<Category> Parse(List<CategoryVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public CategoryVO Parse(Category origin)
        {
            return new CategoryVO
            {
                Id = origin.Id,
                Name = origin.Name
            };
        }

        public List<CategoryVO> Parse(List<Category> origin)
        {
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
