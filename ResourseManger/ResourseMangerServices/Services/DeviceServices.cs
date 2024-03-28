using AutoMapper;
using ResourseMangerDTOs.DeviceDTOs;
using ResourseMangerDTOs.UserDTOs;
using ResourseMangerModels;
using ResourseMangerServices.Contracts;
using ResourseMangerServices.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Services
{
    public class DeviceServices: Services<Device, GetAllDevices,RecordDevice,EditDevice>, IDeviceServices
    {
        public DeviceServices(IDeviceRepository deviceRepository, IMapper mapper) : base(deviceRepository, mapper)
        {
        }
    }
}
