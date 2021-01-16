using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IAdministratorRepository
    {
        List<Administrator> GetAllAdministrators();
        int InsertAdministrator(Administrator a);
        int UpdateAdministrator(Administrator a);
        int DeleteAdministrator(int Id);
    }
}
