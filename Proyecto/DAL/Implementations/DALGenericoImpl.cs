using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DAL.Implementations
{
    public class DALGenericoImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {

        protected readonly PrograWebContext _Context;

        public DALGenericoImpl(PrograWebContext prograWebContext)
        {
            _Context = prograWebContext;
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _Context.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return _Context.Set<TEntity>().Find(id);
        }


        public bool Remove(TEntity entity)
        {

            try
            {
                _Context.Set<TEntity>().Attach(entity);
                _Context.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TEntity entity)
        {

            try
            {
                _Context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        IEnumerable<TEntity> IDALGenerico<TEntity>.GetAll()
        {
            
           return _Context.Set<TEntity>().ToList(); 
            
          
        }
    }
}
