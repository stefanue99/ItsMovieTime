using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AdministratorBusiness : IAdministratorBusiness
    {
        private readonly IAdministratorRepository administrationRepository;
        public AdministratorBusiness(IAdministratorRepository _administrationRepository) 
        {
            this.administrationRepository = _administrationRepository;
        }
        public bool DeleteAdministrator(int id)
        {
            if (this.administrationRepository.DeleteAdministrator(id) > 0) 
            {
                return true;
            }
            return false;
        }
        public List<Administrator> GetAllAdministrators()
        {
            return this.administrationRepository.GetAllAdministrators();
        }

        public bool InsertAdministrator(Administrator a)
        {
            if (this.administrationRepository.InsertAdministrator(a) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateAdministrator(Administrator a)
        {
            if (this.administrationRepository.UpdateAdministrator(a) > 0)
            {
                return true;
            }
            return false;
        }
        public bool GetAdministratorForLogIn(string username, string password)
        {
            Administrator admin = this.administrationRepository.GetAllAdministrators().FirstOrDefault(a => a.UserName == username && a.Password == password);
            if (admin != null)
            {
                return true;
            }
            return false;
        }
    }
}
