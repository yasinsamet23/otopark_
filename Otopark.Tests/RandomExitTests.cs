using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using otopark_;

namespace Otopark.Tests
{
    [TestClass]
    public class RandomExitTests
    {
        [TestMethod]
        public void GenerateRandomExit_ShouldBeAfterEntry()
        {
            MainPanel mainpanel = new MainPanel();
            DateTime entry = DateTime.Now;

            DateTime exit = mainpanel.GenerateRandomExit(entry);

            Assert.IsTrue(exit > entry);
        }

        [TestMethod]
        public void GenerateRandomExit_ShouldNotExceed30Days()
        {
            MainPanel mainpanel = new MainPanel();
            DateTime entry = DateTime.Now;

            DateTime exit = mainpanel.GenerateRandomExit(entry);

            TimeSpan diff = exit - entry;

            Assert.IsTrue(diff.TotalDays <= 30);
        }
    }
}