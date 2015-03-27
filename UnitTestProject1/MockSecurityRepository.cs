using BusinessCenter.Data;
using BusinessCenter.Data.Implementation;
using BusinessCenter.Data.Interface;
using BusinessCenter.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    //[TestClass]
    //public class MockSecurityRepository : GenericRepository<SecurityQuestion>
    //{
    //    /// <summary>
    //    /// Constructor
    //    /// </summary>
    //    public MockSecurityRepository()
    //    {
    //        // create some mock products to play with
    //        IList<SecurityQuestion> questions = new List<SecurityQuestion>
    //            {
    //                new SecurityQuestion {  Question ="Your Favorite past time" },
    //                new SecurityQuestion {  Question ="Your hobbies" },
    //                new SecurityQuestion {  Question= "Your first school" }
    //            };

    //        // Mock the security Repository using Moq
    //        Mock<SecurityRepository> mockSecurityRepository = new Mock<SecurityRepository>();

    //        // Return all the security questions

    //        mockSecurityRepository.Setup(mr => mr.GetAll()).Returns(questions);

    //        // Complete the setup of our Mock Product Repository
    //        this.MockSecurityRepository = mockSecurityRepository.Object;
    //    }

    //    /// <summary>
    //    /// Gets or sets the test context which provides
    //    /// information about and functionality for the current test run.
    //    ///</summary>
    //    public TestContext TestContext { get; set; }

    //    /// <summary>
    //    /// Our Mock Secuirty Repository for use in testing
    //    /// </summary>
    //    public readonly ISecurityRepository MockSecurityRepository;

    //    /// <summary>
    //    /// Can we return a question By Id?
    //    /// </summary>
    //    [TestMethod]
      
    //    /// <summary>
    //    /// Can we return a question By Name?
    //    /// </summary>
    //    [TestMethod]
    //    public void CanReturnQuestionByName()
    //    {
    //        // Try finding a question by Name
    //        SecurityQuestion testquestion = this.MockSecurityRepository.GetAll() FindByName("Silverlight Unleashed");

    //        Assert.IsNotNull(testquestion); // Test if null
    //        Assert.IsInstanceOfType(testquestion, typeof(SecurityQuestion)); // Test type
    //        Assert.AreEqual(3, testquestion.id); // Verify it is the right product
    //    }

    //    /// <summary>
    //    /// Can we return all questions?
    //    /// </summary>
    //    [TestMethod]
    //    public void CanReturnAllQuestions()
    //    {
    //        // Try finding all products
    //        IList<SecurityQuestion> testquestions = this.MockSecurityRepository.GetAll();

    //        Assert.IsNotNull(testquestions); // Test if null
    //        Assert.AreEqual(3, testquestions.Count); // Verify the correct Number
    //    }

    //    /// <summary>
    //    /// Can we insert a new question?
    //    /// </summary>
    //    [TestMethod]
    //    public void CanInsertQuestion()
    //    {
    //        // Create a new product, not I do not supply an id
    //        SecurityQuestion newQuestion = new SecurityQuestion { Question = "Your Favorite past time" };

    //        int productCount = this.MockSecurityRepository.FindAll().Count;
    //        Assert.AreEqual(3, productCount); // Verify the expected Number pre-insert

    //        // try saving our new product
    //        this.MockSecurityRepository.Save(newQuestion);

    //        // demand a recount
    //        productCount = this.MockSecurityRepository.FindAll().Count;
    //        Assert.AreEqual(4, productCount); // Verify the expected Number post-insert

    //        // verify that our new question has been saved
    //        SecurityQuestion testProduct = this.MockSecurityRepository.FindByName("Pro C#");
    //        Assert.IsNotNull(testProduct); // Test if null
    //        Assert.IsInstanceOfType(testProduct, typeof(SecurityQuestion)); // Test type
    //        Assert.AreEqual(4, testProduct.id); // Verify it has the expected productid
    //    }

    //    /// <summary>
    //    /// Can we update a question?
    //    /// </summary>
    //    [TestMethod]
    //    public void CanUpdateQuestion()
    //    {
    //        // Find a product by id
    //        SecurityQuestion testquestion = this.MockSecurityRepository

    //        // Change one of its properties
    //        testquestion.Question = "Your Favorite past time";

    //        // Save our changes.
    //        this.MockSecurityRepository.Save(testquestion);

    //        // Verify the change
    //        Assert.AreEqual("C# 3.5 Unleashed", this.MockSecurityRepository.FindById(1).Name);
    //    }
    //}
}
