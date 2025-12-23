using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using otopark_;
using System.Text.RegularExpressions;

namespace Otopark.Tests
{
    [TestClass]
    public class RandomPlateTests
    {
        [TestMethod]
        public void RandomPlate_ShouldMatchTurkishPlateFormat()
        {
            MainPanel mainpanel = new MainPanel();

            string plate = mainpanel.RandomPlate();

            // Örnek: 34 ABC 123
            string pattern = @"^\d{2} [A-Z]{3} \d{3}$";

            Assert.IsTrue(Regex.IsMatch(plate, pattern));
        }

        [TestMethod]
        public void RandomPlate_ShouldNotBeEmpty()
        {
            MainPanel mainpanel = new MainPanel();

            string plate = mainpanel.RandomPlate();

            Assert.IsFalse(string.IsNullOrWhiteSpace(plate));
        }
    }
}
