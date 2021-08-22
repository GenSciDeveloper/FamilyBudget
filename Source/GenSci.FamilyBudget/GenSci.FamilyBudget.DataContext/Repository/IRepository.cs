using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenSci.FamilyBudget.DataContext.Repository
{
    /// <summary>
    /// Repository pattern interface.
    /// </summary>
    /// <typeparam name="TEntity">Entity class.</typeparam>
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        /// <summary>
        /// Property to get all data from table.
        /// </summary>
        IQueryable<TEntity> All { get; }

        /// <summary>
        /// Get filtered data from table.
        /// </summary>
        /// <param name="predicate">Data filter.</param>
        /// <returns>Filtered data.</returns>
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);

        /// <summary>
        /// Add entity to the <see cref="TEntity"/> table.
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        /// <summary>
        /// Remove entity from the <see cref="TEntity"/> table.
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// Update entity in the <see cref="TEntity"/> table.
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Get entity from <see cref="TEntity"/> table by identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity FindById(int id);

        /// <summary>
        /// Commit database operation.
        /// </summary>
        Task SaveAsync();
    }
}