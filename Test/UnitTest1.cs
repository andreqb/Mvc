using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mvc;
using Mvc.Controllers;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IDataService> _dataService;

        [TestMethod]
        public void ItReturnsData()
        {
            //arrange
            _dataService = new Mock<IDataService>();
            _dataService.Setup(m => m.GetData()).Returns(It.IsAny<List<string>>()).Verifiable();
            var controller = new HomeController(_dataService.Object);

            //act
            controller.TestIndex();

            //assert
            _dataService.Verify();
        }
    }
}