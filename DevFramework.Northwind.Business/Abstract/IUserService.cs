using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
