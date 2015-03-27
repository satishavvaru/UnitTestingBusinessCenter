using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCenter.Data.Implementation;
using BusinessCenter.Data.Interface;
using BusinessCenter.Data;
using System.Data.Common;
using BusinessCenter.Data.Common;
using System.Data.Entity;
using System.Data;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class SecurityRepositoryTest
    {
        DbConnection connection;
        TestContext databaseContext;
        SecurityRepository objRepo;
        UnitOfWork uow;
        DbContext context;

        [TestInitialize]
        public void Initialize()
        {
            connection = Effort.DbConnectionFactory.CreateTransient();
            databaseContext = new TestContext(connection);
            Mock<UnitOfWork> mockUnitofWork = new Mock<UnitOfWork>(databaseContext);
            // uow = new UnitOfWork(context);
            //uow = new UnitOfWork(context);
            //uow = new UnitOfWork(databaseContext);
            //  objRepo = new SecurityRepository(uow);

            context = uow.getContext();
            objRepo = new SecurityRepository(mockUnitofWork.Object);
        }

        [TestMethod]
        public void GetAllTestMethod()
        {
            //Act
            var result = objRepo.GetAll().ToList();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Your Favorite past time", result[0].Question);
            Assert.AreEqual("Your hobbies", result[1].Question);
            Assert.AreEqual("Your first school", result[3].Question);
        }
    }

    //DbConnection connection;
    //   TestContext databaseContext;
    //   CountryRepository objRepo;

    //   [TestInitialize]
    //   public void Initialize()
    //   {
    //       connection = Effort.DbConnectionFactory.CreateTransient();
    //       databaseContext = new TestContext(connection);
    //       objRepo = new CountryRepository(databaseContext);
    //   }

    //   [TestMethod]
    //   public void Country_Repository_Get_ALL()
    //   {
    //       //Act
    //       var result = objRepo.GetAll().ToList();

    //       //Assert

    //       Assert.IsNotNull(result);
    //       Assert.AreEqual(3, result.Count);
    //       Assert.AreEqual("US", result[0].Name);
    //       Assert.AreEqual("India", result[1].Name);
    //       Assert.AreEqual("Russia", result[2].Name);
    //   }
}

