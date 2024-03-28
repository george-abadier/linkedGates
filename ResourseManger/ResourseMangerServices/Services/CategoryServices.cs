using AutoMapper;
using ResourseMangerModels;
using ResourseMangerServices.Contracts;
using ResourseMangerServices.Services.ServicesContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourseMangerDTOs.CategoryDTOs;

namespace ResourseMangerServices.Services
{
    public class CategoryServices:Services<Category,GetAllCategories,CreateCategory,EditCategory>,ICategoryServices
    {


        public CategoryServices(ICategoryRepository categoryRepository,IMapper  mapper):base(categoryRepository,mapper) {
        }
        //public async Task<Response<List<GetAllCategories>>> GetCategoriesAsync()
        //{
        //    try { 
        //   List<GetAllCategories> categories=_mapper.Map<List<GetAllCategories>>(await _categoryRepository.GetAll().ToListAsync());
        //    if(categories.Count == 0)
        //    {
        //        return new Response<List<GetAllCategories>>("no categories are found");
        //    }
        //    return new  Response<List<GetAllCategories>>(categories);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Response<List<GetAllCategories>>(ex.Message);
        //    }
        //}
    }
}
