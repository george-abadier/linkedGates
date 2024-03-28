
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
    public class Repository<T>:IRepository<T>    where T : BaseEntity
    {
        protected readonly ResourseMangerContext.ResourseMangerContext _context;
        protected readonly DbSet<T> _DBset;
        public Repository(ResourseMangerContext.ResourseMangerContext context)
        {
            _context = context;
            _DBset = _context.Set<T>();
        }

        virtual public  async Task<Response<T>> Create(T entity)
        {
            try
            {
                T   Entity = (await _DBset.AddAsync(entity)).Entity;
                return new  Response<T>(Entity);
            }catch(Exception ex)
            {
                return new Response<T>(ex.Message, false);
            }
        }

        virtual public  IQueryable<T> GetAll()
        {
            return _DBset;
        }
        virtual public Response<T> Edit(T entity)
        {
            try {
                T Entity = _DBset.Update(entity).Entity;
                return new Response<T>(Entity);

            }
            catch(Exception ex) {
                return new Response<T>(ex.Message, false);
            }
        }
        public async Task<Response<T>> Save()
        {
            try
            {
                await _context.SaveChangesAsync();
                return  new Response<T>(null);
            }
            catch (Exception ex)
            {

                return new Response<T>(ex.Message,false);
            }
        }

        virtual  public  Response<T> Delete(T entity)
        {
            try
            {
                entity=_DBset.Remove(entity).Entity;
                return new Response<T>(entity);
            }catch(Exception  ex)
            {
                return new Response<T>(ex.Message, false);
            }
        }
        virtual public  async   Task< Response<T>> getById(int id)
        {
            try
            {
                T   entity =await _DBset.FindAsync(id);
                return new Response<T>(entity);
            }
            catch (Exception ex)
            {
                return new Response<T>(ex.Message, false);
            }
        }
    }
}
