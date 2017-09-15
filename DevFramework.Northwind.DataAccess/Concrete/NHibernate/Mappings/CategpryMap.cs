using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategpryMap:ClassMap<Category>
    {
        public CategpryMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryId");

            Map(x => x.CategoryId).Column("CategoryId");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
