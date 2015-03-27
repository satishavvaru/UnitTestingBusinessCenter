using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessCenter.Data.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public GenericRepository( )
        {
            
        }

        protected DbContext Entities;
        protected readonly IDbSet<T> DbSet;

        /// <summary>
        /// Initializes a new Instance of Generic Repository With Specified Generic Entity
        /// </summary>
        /// <param name="context">Unit of work object</param>
        public GenericRepository(IUnitOfWork context)
        {
            Entities = context.getContext();
            DbSet = Entities.Set<T>();
        }


        /// <summary>
        /// Gets all the records of T type Entity
        /// </summary>
        /// <returns>IEnumerable of records</returns>
        public virtual IEnumerable<T> GetAll()
        {

            return DbSet.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = DbSet.Where(predicate).AsEnumerable();
            return query;
        }


        /// <summary>
        /// Adds a particular Record to the DbSet Object(Database)
        /// </summary>
        /// <param name="entity">Entity type object which has to be inserted into database</param>
        /// <returns></returns>
        public virtual T Add(T entity)
        {
            return DbSet.Add(entity);
        }

        /// <summary>
        /// Deletes the particular Record from the database
        /// </summary>
        /// <param name="entity">Entity type object which has to be deleted from database</param>
        /// <returns></returns>
        public virtual T Delete(T entity)
        {
            return DbSet.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Commits saved values to the database
        /// </summary>
        public virtual void Save()
        {
            Entities.SaveChanges();
        }
    }
}
