using GenSci.FamilyBudget.DataContext.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GenSci.FamilyBudget.DataContext.Repository
{
    /// <summary>
    /// Repository for User table operations.
    /// </summary>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Database application context.
        /// </summary>
        private readonly AppContext _appContext;

        /// <summary>
        /// Database data set from <see cref="TEntity"/> table.
        /// </summary>
        private readonly DbSet<TEntity> _dbSet;

        public Repository(AppContext appContext)
        {
            _appContext = appContext;
            _dbSet = appContext.Set<TEntity>();
        }

        IQueryable<TEntity> IRepository<TEntity>.All => _dbSet.AsNoTracking();

        TEntity IRepository<TEntity>.FindById(int id) => _dbSet.Find(id);

        IQueryable<TEntity> IRepository<TEntity>.Get(Func<TEntity, bool> predicate) => _dbSet.AsNoTracking().Where(predicate).AsQueryable();

        void IRepository<TEntity>.Add(TEntity entity) => _dbSet.Add(entity);

        void IRepository<TEntity>.Delete(TEntity entity) => _dbSet.Remove(entity);

        void IRepository<TEntity>.Update(TEntity entity) => _appContext.Entry(entity).State = EntityState.Modified;

        async Task IRepository<TEntity>.SaveAsync() => await _appContext.SaveChangesAsync();
    }
}
