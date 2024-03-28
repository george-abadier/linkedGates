using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ResourseMangerDTOs;
using ResourseMangerDTOs.DeviceDTOs;
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
    public class Services<T,GetALLT, CreateT, EditT> :IServices<T, GetALLT, CreateT,EditT>   where T : BaseEntity
    {
        protected readonly IRepository<T> _repository;
        protected readonly IMapper _mapper;

        public Services(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        virtual public async Task<Response<GetALLT>> Create(CreateT entity)
        {
            
            Response<T> result = await _repository.Create(_mapper.Map<T>(entity));
            Response<T>saved= await _repository.Save();
            return result.IsSuccess? saved.IsSuccess? new Response<GetALLT>(_mapper.Map<GetALLT>(result.ReturnedValue)): new Response<GetALLT>(saved.Message, saved.IsSuccess): new Response<GetALLT>(result.Message,result.IsSuccess);
        }

        virtual public async Task<Response<GetALLT>> Edit(EditT entity)
        {

            Response<T> result =  _repository.Edit(_mapper.Map<T>(entity));
            Response<T> saved = await _repository.Save();
            return result.IsSuccess ? saved.IsSuccess ? new Response<GetALLT>(_mapper.Map<GetALLT>(result.ReturnedValue)) : new Response<GetALLT>(saved.Message, saved.IsSuccess) : new Response<GetALLT>(result.Message, result.IsSuccess);
        }
        virtual public async Task<Response<GetALLT>> Delete(int id)
        {
            Response<T> entity = await _repository.getById(id);
            if (entity.IsSuccess)
            {
                Response<T> result = _repository.Delete(_mapper.Map<T>(entity.ReturnedValue));
                Response<T> saved = await _repository.Save();
                return result.IsSuccess ? saved.IsSuccess ? new Response<GetALLT>(_mapper.Map<GetALLT>(result.ReturnedValue)) : new Response<GetALLT>(saved.Message, saved.IsSuccess) : new Response<GetALLT>(result.Message, result.IsSuccess);
            }
            return new Response<GetALLT>(entity.Message, entity.IsSuccess);
        }

        virtual public async Task<Response<List<GetALLT>>> GetAllAsync()
        {
            try
            {
                List<GetALLT> categories = _mapper.Map<List<GetALLT>>(await _repository.GetAll().ToListAsync());
                if (categories.Count == 0)
                {
                    return new Response<List<GetALLT>>($"no data are found",false);
                }
                return new Response<List<GetALLT>>(categories);
            }
            catch (Exception ex)
            {
                return new Response<List<GetALLT>>(ex.Message,false);
            }
        }

        virtual async public Task<Response<GetALLT>> GetById(int id)
        {
            Response<T> entity = await _repository.getById(id);
            if (entity.IsSuccess)
            {
                return new Response<GetALLT>(_mapper.Map<GetALLT>(entity.ReturnedValue));
            }
            return new Response<GetALLT>(entity.Message, entity.IsSuccess);
        }
    }
}
