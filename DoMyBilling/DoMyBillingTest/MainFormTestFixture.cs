using DoMyBilling;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMyBillingTest
{
    class MainFormTestFixture
    {
        [
            Test,
            TestCase("Comp", "Recv", 10, "CORE-2124"),
            TestCase("Met Csoport", "77 Csoport", 32, "ME77-13212"),
            TestCase("Duna Aszfalt", "Kis Béla", 115, "DUKI-159624"),
            TestCase("Kerox Kft. ", "Videoton Holding", 8, "KEVI-1692"),
        ]
        public void TestGenerateID(string cName, string rName, int n, string expectedResult)
        {
            // Arrange
            var mainForm = new MainForm();

            // Act
            var actualResult = mainForm.GenerateID(cName, rName, n);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
