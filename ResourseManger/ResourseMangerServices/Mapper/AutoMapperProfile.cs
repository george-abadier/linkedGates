using AutoMapper;
using ResourseMangerDTOs.CategoryDTOs;
using ResourseMangerDTOs.DeviceDTOs;
using ResourseMangerDTOs.UserDTOs;
using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<Category, GetAllCategories>();
            CreateMap<User, GetAllUsers>();
            CreateMap<Device, GetAllDevices>();
            CreateMap<RecordDevice,Device>();
            CreateMap<EditDevice, Device>();
        }
    }
}
