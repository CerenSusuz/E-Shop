using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EShop.Core.Signatures;
using EShop.DataAccess.Contexts.EF;
using Microsoft.EntityFrameworkCore;

namespace EShop.DataAccess.Repositories.EF
{
    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity:class,IBaseEntity, new()
    {
        private readonly EShopContext _context;
        private readonly DbSet<TEntity> _entities;

        public EfRepository(EShopContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        //tüm entities döner
        public IQueryable<TEntity> Table => _entities;
        
        // tabloyu cache almadan ver
        public IQueryable<TEntity> AsNoTracking => _entities.AsNoTracking();

        public async Task<TEntity> GetAsync(int id)
        {
            var entity = await _entities.FindAsync(id);
            if (entity != null)
                _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRangeAsync(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}