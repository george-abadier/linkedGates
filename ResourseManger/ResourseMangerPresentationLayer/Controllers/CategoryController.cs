using Microsoft.AspNetCore.Mvc;
using ResourseMangerServices.Services.ServicesContracts;

namespace ResourseMangerPresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices) {
            _categoryServices = categoryServices;
        }
        public  async Task<IActionResult> GetAll()
        {
            return Json(await   _categoryServices.GetAllAsync());
        }
    }
}
