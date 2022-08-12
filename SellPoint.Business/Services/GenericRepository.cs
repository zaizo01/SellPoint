using Microsoft.EntityFrameworkCore;
using SellPoint.Business.Interfaces;
using SellPoint.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPoint.Business.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> Create(T entity)
        {
            try
            {
                context.Set<T>().Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<T> Delete(int id)
        {
            try
            {
                var entity = await GetById(id);
                if (entity == null) throw new Exception("The entity is null");
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                var record = await context.Set<T>().FindAsync(id);
                if (record is null) throw new Exception("El registro no existe.");
                return record;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(T entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
