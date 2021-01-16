using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdministratorRepository : IAdministratorRepository
    {
        public int DeleteAdministrator(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Administrators WHERE Id = '{0}';", Id));

            DBConnection.CloseConnection();
            return result;
        }

        public List<Administrator> GetAllAdministrators()
        {
            List<Administrator> listOfAdministrators = new List<Administrator>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Administrators");

            while (sqlDataReader.Read())
            {
                Administrator a = new Administrator();
                a.Id = sqlDataReader.GetInt32(0);
                a.Name = sqlDataReader.GetString(1);
                a.Surname = sqlDataReader.GetString(2);
                a.Email = sqlDataReader.GetString(3);
                a.PhoneNumber = sqlDataReader.GetString(4);
                a.UserName = sqlDataReader.GetString(5);
                a.Password = sqlDataReader.GetString(6);
                listOfAdministrators.Add(a);
            }

            DBConnection.CloseConnection();
            return listOfAdministrators;
        }

        public int InsertAdministrator(Administrator a)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Administrators VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", a.Name, a.Surname, a.Email, a.PhoneNumber, a.UserName, a.Password));

            DBConnection.CloseConnection();
            return result;
        }

        public int UpdateAdministrator(Administrator a)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Administrators SET Name = '{0}', Surname = '{1}', Email = '{2}', PhoneNumber = '{3}', Username = '{4}', Password = '{5}' WHERE Id = '{6}'", a.Name, a.Surname, a.Email, a.PhoneNumber, a.UserName, a.Password, a.Id));

            DBConnection.CloseConnection();
            return result;
        }
    }
}
