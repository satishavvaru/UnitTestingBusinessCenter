using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessCenter.Data.Interface;
using BusinessCenter.Data.Common;
using BusinessCenter.Data;
using BusinessCenter.Service;
using BusinessCenter.Service.Implementation;
using BusinessCenter.Service.Interface;
using BusinessCenter.Data.Implementation;

namespace UnitTestProject1
{
    [TestClass]
    public class SecurityQuestionServiceTest
    {
        private Mock<ISecurityRepository> _mockRepository;
        Mock<IUnitOfWork> _mockUnitWork;
        List<SecurityQuestion> listSecurityQuestion;

        private ISecurityQuestionsService _service;
       
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<ISecurityRepository>();
            _mockUnitWork = new Mock<IUnitOfWork>();

            _service = new SecurityQuestionService(_mockRepository.Object);
  
            //listSecurityQuestion = new List<SecurityQuestion>() {
            //    new SecurityQuestion() { id = 1, Question = "Your Favorite past time"},
            //    new SecurityQuestion() { id = 2, Question = "Your hobbies"},
            //    new SecurityQuestion() { id = 3, Question = "Your first school"}
            //};
            
        }

        [TestMethod]
        public void Country_Get_All()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listSecurityQuestion);

            //Act
            List<SecurityQuestion> results = _service.GetAll() as List<SecurityQuestion>;

            //Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(3, results.Count);
        }
    }
}

