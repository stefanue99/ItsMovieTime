using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace BussinesTests
{
    [TestClass]
    public class AdministratorBusinessTests
    {
        private Mock<IAdministratorRepository> mockAdministratorRepository = new Mock<IAdministratorRepository>();
        private Administrator administrator = new Administrator
        {
            Id = 84,
            Name = "Uros",
            Surname = "Sreckovic",
            Email = "uros.sreckovic@gmail.com",
            PhoneNumber = "0651248558",
            UserName = "uros",
            Password = "uros123"
        };
        private List<Administrator> listOfAdministrators = new List<Administrator>();
        private AdministratorBusiness administratorBusiness;

        [TestMethod]
        public void AdministratorUpdated()
        {
            //Arange
            mockAdministratorRepository.Setup(a => a.UpdateAdministrator(administrator)).Returns(1);
            this.administratorBusiness = new AdministratorBusiness(mockAdministratorRepository.Object);

            //Act
            var result = this.administratorBusiness.UpdateAdministrator(administrator);

            //Asert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LoginAdministrator()
        {
            //Arange
            listOfAdministrators.Add(new Administrator
            {
                Id = 84,
                Name = "Uros",
                Surname = "Sreckovic",
                Email = "uros.sreckovic@gmail.com",
                PhoneNumber = "0651248558",
                UserName = "uros",
                Password = "uros123"
            });
            listOfAdministrators.Add(new Administrator
            {
                Id = 84,
                Name = "Milos",
                Surname = "Stojkovic",
                Email = "milos.stojkovic@gmail.com",
                PhoneNumber = "0651248558",
                UserName = "milos",
                Password = "stojkovic123"
            });
            listOfAdministrators.Add(new Administrator
            {
                Id = 84,
                Name = "Ivana",
                Surname = "Maksimovic",
                Email = "ivana.maksimovic@gmail.com",
                PhoneNumber = "0651248558",
                UserName = "ivana",
                Password = "maksimovic123"
            });
            mockAdministratorRepository.Setup(x => x.GetAllAdministrators()).Returns(listOfAdministrators);
            this.administratorBusiness = new AdministratorBusiness(mockAdministratorRepository.Object);

            //Act
            var result = this.administratorBusiness.GetAdministratorForLogIn("milos", "stojkovic123");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdministratorInserted()
        {

            //Arange
            mockAdministratorRepository.Setup(x => x.InsertAdministrator(administrator)).Returns(1);
            this.administratorBusiness = new AdministratorBusiness(mockAdministratorRepository.Object);

            //Act
            var result = this.administratorBusiness.InsertAdministrator(administrator);

            //Asert
            Assert.IsTrue(result);

        }
    }
}
