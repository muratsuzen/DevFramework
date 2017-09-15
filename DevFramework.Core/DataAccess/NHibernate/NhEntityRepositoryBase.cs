using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;
using NHibernate.Linq;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity>:IEntityRepository<TEntity>
        where TEntity:class ,IEntity,new()
    {
        private NHibernateHelper _hibernateHelper;

        public NhEntityRepositoryBase(NHibernateHelper hibernateHelper)
        {
            _hibernateHelper = hibernateHelper;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _hibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _hibernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using (var session = _hibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(expression);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var session = _hibernateHelper.OpenSession())
            {
                return expression == null
                    ? session.Query<TEntity>().ToList()
                    : session.Query<TEntity>().Where(expression).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _hibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
