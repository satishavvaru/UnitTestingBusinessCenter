using BusinessCenter.Data;
using BusinessCenter.Data.Implementation;
using BusinessCenter.Data.Interface;
using BusinessCenter.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class MockEF 
    {
        IUnitOfWork context;

        [TestMethod]
        public void CreateBlog_saves_a_blog_via_context()
        {
            //var mockSet = new Mock<DbSet<SecurityQuestion>>();

            //var mockContext = new Mock<Entities>();
            //mockContext.Setup(m => m.SecurityQuestion).Returns(mockSet.Object);

            //var repo = new SecurityRepository(context);
            ////repo.Add(SecurityQuestion); 
            


            //mockSet.Verify(m => m.Add(It.IsAny<SecurityQuestion>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
        } 




        [TestInitialize]
        public void Initialize()
        {

            //var tempdata = new List<SecurityQuestion> 
            //    { 
            //        new SecurityQuestion { Question = "Your Favorite past time" }, 
            //        new SecurityQuestion { Question = "Your hobbies" }, 
            //        new SecurityQuestion { Question = "Your first school" }, 
            //    }.AsQueryable();

            //var mockSet = new Mock<DbSet<SecurityQuestion>>();
            //mockSet.As<IQueryable<SecurityQuestion>>().Setup(m => m.Provider).Returns(tempdata.Provider);
            //mockSet.As<IQueryable<SecurityQuestion>>().Setup(m => m.Expression).Returns(tempdata.Expression);
            //mockSet.As<IQueryable<SecurityQuestion>>().Setup(m => m.ElementType).Returns(tempdata.ElementType);
            //mockSet.As<IQueryable<SecurityQuestion>>().Setup(m => m.GetEnumerator()).Returns(tempdata.GetEnumerator());

            //var mockContext = new Mock<Entities>();
            //mockContext.Setup(c => c.SecurityQuestion).Returns(mockSet.Object);
        }

        
        /// <summary>
        /// EntityFramework Mock with MOQ
        /// </summary>
        [TestMethod]
        public void GetAllProducts_EFMock()
        {
            var genericrepo = new SecurityRepository(context);
            var questions = genericrepo.GetAll().ToList();

            Assert.AreEqual(3, questions.Count);
            Assert.AreEqual("Your Favorite past time", questions[0].Question);
            Assert.AreEqual("Your hobbies", questions[1].Question);
            Assert.AreEqual("Your first school", questions[2].Question);
        }
    }
}

