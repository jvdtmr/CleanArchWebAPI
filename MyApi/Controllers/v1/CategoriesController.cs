using AutoMapper;
using Data.Repositories;
using Entities;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CategoriesController : CrudController<CategoryDto, Category>
    {
        private readonly IMapper _mapper;
        public CategoriesController(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
