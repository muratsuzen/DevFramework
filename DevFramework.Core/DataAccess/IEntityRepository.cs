using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T> where T :class ,IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
