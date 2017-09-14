using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;
using NHibernate.Linq;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T>:IQueryableRepository<T> where T:class ,IEntity,new ()
    {
        private NHibernateHelper _nhibernateHelper;
        private IQueryable<T> _entities;


        public NhQueryableRepository(NHibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper;
        }

        public IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nhibernateHelper.OpenSession().Query<T>()); }
        }
    }
}
