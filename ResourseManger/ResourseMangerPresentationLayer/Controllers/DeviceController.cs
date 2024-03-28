using Microsoft.AspNetCore.Mvc;
using ResourseMangerDTOs.DeviceDTOs;
using ResourseMangerModels;
using ResourseMangerServices.Services.ServicesContracts;

namespace ResourseMangerPresentationLayer.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceServices _deviceServices;
        public DeviceController(IDeviceServices deviceServices)
        {
            _deviceServices = deviceServices;
        }
        public async Task<IActionResult> GetAll()
        {
            return Json(await _deviceServices.GetAllAsync());
        }
        //public IActionResult Add()
        //{
        //    ViewBag.message = "enter your new device  data";
        //    return View();
        //}
        [HttpPost]
        public async Task<IActionResult> Add(RecordDevice device)
        {
            //if (ModelState.IsValid)
            //{
            device = new RecordDevice()
            {
                Name = "printer1",
                CategoryId = 1,
                StringProperties = new List<ValuedProperty<string>>() {
        new ValuedProperty<string> (){PropertyId=1,Value="ffff.ffff.ffff.ffff"},
        new ValuedProperty<string> () { PropertyId=3,Value="lenove"}
    },
                Acquisition_Date = DateTime.Now,
                BoolProperties = new HashSet<ValuedProperty<bool>>() { new ValuedProperty<bool>() { PropertyId = 2, Value = true } }

            };
            Response<GetAllDevices> result = await _deviceServices.Create(device);
            ViewBag.message = result.Message;
            if (result.IsSuccess)
            {
                return Redirect("/Device/Getall");
            }

            return Json(new { message = result.Message });


            //}
            ////    return View();
            //return Json(new{ message=$"{ModelState.ErrorCount}" });
        }
        [HttpPut]
        public async Task<IActionResult> Edit(EditDevice device)
        {
            //if (ModelState.IsValid)
            //{
            device = new EditDevice()
            {
                Id = 8,
                Name = "printer5",
                CategoryId = 1,
                StringProperties = new List<ValuedProperty<string>>() {
        new ValuedProperty<string> (){PropertyId=1,Value="ffff.ffff.ffff.ffff"},
        new ValuedProperty<string> () { PropertyId=3,Value="lenove"}
    },
                Acquisition_Date = DateTime.Now,
                BoolProperties = new HashSet<ValuedProperty<bool>>() { new ValuedProperty<bool>() { PropertyId = 2, Value = true } }

            };
            Response<GetAllDevices> result = await _deviceServices.Edit(device);
            ViewBag.message = result.Message;
            if (result.IsSuccess)
            {
                return Redirect("/Device/Getall");
            }

            return Json(new { message = result.Message });


            //}
            ////    return View();
            //return Json(new{ message=$"{ModelState.ErrorCount}" });
        }
        [HttpDelete("{Id:int}")]
        public async Task<IActionResult> Delete(int Id)
        {

            Response<GetAllDevices> result = await _deviceServices.Delete(Id);
            ViewBag.message = result.Message;
            if (result.IsSuccess)
            {
                return Redirect("/Device/Getall");
            }

            return Json(new { message = result.Message });
        }
        [HttpGet("{Id:int}")]
        public async Task<IActionResult> get(int Id)
        {

            Response<GetAllDevices> result = await _deviceServices.GetById(Id);
            ViewBag.message = result.Message;
            if (result.IsSuccess)
            {
                return Json(result.ReturnedValue);
            }

            return Json(new { message = result.Message });
        }
    }
}
