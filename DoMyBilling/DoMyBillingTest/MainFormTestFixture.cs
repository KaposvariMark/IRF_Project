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
            TestCase("Company", "Reciever", 10, "CORE-2124"),
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

        [
            Test,
            TestCase(0, 568, 0),
            TestCase(5, 899, 44.95),
            TestCase(18, 999999999, 179999999.82),
            TestCase(27, 1, 0.27),
        ]
        public void TestCalcVAT(int vat, int price, double expectedResult)
        {
            // Arrange
            var mainForm = new MainForm();

            // Act
            var actualResult = mainForm.CalcVAT(vat, price);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase(2, 2, "B2"),
            TestCase(3532, 3, "C3532"),
            TestCase(1, 1082, "AOP1"),
            TestCase(27, 19, "S27"),
        ]
        public void TestGetCell(int row, int col, string expectedResult)
        {
            // Arrange
            var mainForm = new MainForm();

            // Act
            var actualResult = mainForm.GetCell(row, col);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
