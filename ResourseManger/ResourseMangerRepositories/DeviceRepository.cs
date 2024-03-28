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
    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        public DeviceRepository(ResourseMangerContext.ResourseMangerContext context) : base(context)
        {
       
    }
        public override IQueryable<Device> GetAll()
        {
            return _context.Devices.Include(Device => Device.BoolProperties).Include(Device => Device.StringProperties).Include(Device=>Device.DoubleProperties).Include(Device=>Device.User);
        }
    }
}
