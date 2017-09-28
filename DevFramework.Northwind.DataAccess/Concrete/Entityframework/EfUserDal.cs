using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccess.Concrete.Entityframework
{
    public class EfUserDal : EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var result = from ur in context.UserRoles
                    join r in context.Roles
                        on ur.UserId equals user.Id
                    where ur.UserId == user.Id
                    select new UserRoleItem {RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
