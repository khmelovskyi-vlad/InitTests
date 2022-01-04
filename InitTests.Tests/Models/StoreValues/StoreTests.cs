using InitTests.Models.StoreValues;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitTests.Tests.Models.StoreValues
{
    internal class StoreTests
    {
        [Test]
        public void GetProduct_FindProduct_ShouldReturnProduct()
        {
            //Arrange

            var id = Guid.NewGuid();

            var store = new Store();

            //Act

            var product = store.GetProduct(id);

            //Assert

            Assert.AreEqual(product.Id, id);
        }
    }
}
