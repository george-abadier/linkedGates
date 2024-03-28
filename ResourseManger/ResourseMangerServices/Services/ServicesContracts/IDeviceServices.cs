using ResourseMangerDTOs.DeviceDTOs;
using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Services.ServicesContracts
{
    public interface IDeviceServices:IServices<Device, GetAllDevices,RecordDevice,EditDevice>
    {
    }
}
