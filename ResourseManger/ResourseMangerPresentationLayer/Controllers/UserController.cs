using Microsoft.AspNetCore.Mvc;
using ResourseMangerServices.Services;
using ResourseMangerServices.Services.ServicesContracts;

namespace ResourseMangerPresentationLayer.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public  async Task< IActionResult> GetAll()
        {
            return Json(   await _userServices.GetAllAsync());
        }
    }
}
