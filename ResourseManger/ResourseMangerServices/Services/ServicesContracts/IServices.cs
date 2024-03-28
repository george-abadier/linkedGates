using ResourseMangerDTOs.DeviceDTOs;
using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Services.ServicesContracts
{
    public interface IServices<T, GetALLT,CreateT, EditT>
    {
        Task<Response<List<GetALLT>>> GetAllAsync();
        Task<Response<GetALLT>> Create(CreateT   entity);
        Task<Response<GetALLT>> Edit(EditT entity);
        Task<Response<GetALLT>> Delete(int id);
        Task<Response<GetALLT>> GetById(int id);
    }
}
