using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public bool Remove(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
