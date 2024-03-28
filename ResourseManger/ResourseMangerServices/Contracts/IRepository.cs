using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Contracts
{
    public interface IRepository<T>where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<Response<T>> Create(T entity);
        Response<T> Edit(T entity);
        Response<T> Delete(T entity);
        public Task<Response<T>> getById(int id);
        Task <Response<T>>Save();
    }
}
