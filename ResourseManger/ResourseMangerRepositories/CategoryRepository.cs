using Microsoft.EntityFrameworkCore;
using ResourseMangerModels;
using ResourseMangerServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerRepositories
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
       public CategoryRepository(ResourseMangerContext.ResourseMangerContext    context):base(context) {

        }
        public  override IQueryable<Category> GetAll()
        {
            return _context.Category.Include(Category => Category.Properties);
        }
    }
}
