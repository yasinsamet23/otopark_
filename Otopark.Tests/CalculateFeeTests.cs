using Microsoft.VisualStudio.TestTools.UnitTesting;
using otopark_;
using System;


namespace Otopark.Tests
{
    [TestClass]
    public class CalculateFeeTests
    {
        private ParkingCalculator calc;

        [TestInitialize]
        public void Setup()
        {
            calc = new ParkingCalculator();
        }

        // Hafta içi – Binek – 2 saat – Abonelik yok
        [TestMethod]
        public void CalculateFee_Weekday_Car_2Hours_NoSubscription()
        {
            DateTime entry = new DateTime(2025, 10, 20).AddHours(10); // Pazartesi
            DateTime exit = entry.AddHours(2);

            double fee = calc.CalculateFee("Car", entry, exit, false);

            Assert.AreEqual(50, fee);
        }

        // Hafta sonu – SUV – 5 saat – Abonelik yok
        [TestMethod]
        public void CalculateFee_Weekend_SUV_5Hours_NoSubscription()
        {
            DateTime entry = new DateTime(2025, 10, 19).AddHours(9); 
            DateTime exit = entry.AddHours(5);

            double fee = calc.CalculateFee("SUV / Light Commercial", entry, exit, false);

            Assert.AreEqual(140, fee);
        }

        // Abonelik indirimi %25
        [TestMethod]
        public void CalculateFee_Car_2Hours_WithSubscription()
        {
            DateTime entry = new DateTime(2025, 10, 21).AddHours(10); // Salı
            DateTime exit = entry.AddHours(2);

            double fee = calc.CalculateFee("Car", entry, exit, true);

            Assert.AreEqual(37.5, fee);
        }

        // Geçersiz araç tipi
        [TestMethod]
        public void CalculateFee_InvalidVehicleType_ReturnsMinusOne()
        {
            DateTime entry = DateTime.Now;
            DateTime exit = entry.AddHours(1);

            double fee = calc.CalculateFee("Plane", entry, exit, false);

            Assert.AreEqual(-1, fee);
        }

        // Çıkış zamanı girişten önceyse
        [TestMethod]
        public void CalculateFee_ExitBeforeEntry_ReturnsMinusOne()
        {
            DateTime entry = DateTime.Now;
            DateTime exit = entry.AddMinutes(-10);

            double fee = calc.CalculateFee("Car", entry, exit, false);

            Assert.AreEqual(-1, fee);
        }
    }
}
