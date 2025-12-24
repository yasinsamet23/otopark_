using otopark_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class PaymentTests
    {
        [TestInitialize]
        public void Setup()
        {
            ReportStore.Payments.Clear();
        }


        
        [TestMethod]
        public void Payment_ShouldIncreaseEmptySpace()
        {
            
            MainPanel panel = new MainPanel();
            int initialEmptySpace = panel.Space_Area;

            Payment paymentForm = new Payment(panel);

            DateTime entry = DateTime.Now;
            DateTime exit = entry.AddHours(1);

            paymentForm.AddRow(
                "34 ABC 123",
                "Car",
                false,
                entry,
                exit,
                50
            );

            
            paymentForm.btn_payment_Click(null, EventArgs.Empty);

            
            Assert.AreEqual(initialEmptySpace + 1, panel.Space_Area);
        }



        [TestMethod]
        public void Payment_ShouldIncreaseTotalDailyIncome()
        {
            
            MainPanel panel = new MainPanel();
            double initialRevenue = panel.totalDailyIncome;

            Payment paymentForm = new Payment(panel);

            DateTime entry = DateTime.Now;
            DateTime exit = entry.AddHours(2);

            paymentForm.AddRow(
                "06 XYZ 456",
                "Car",
                false,
                entry,
                exit,
                50
            );

            
            paymentForm.btn_payment_Click(null, EventArgs.Empty);

            
            Assert.AreEqual(initialRevenue + 50, panel.totalDailyIncome);
        }




        [TestMethod]
        public void Payment_ShouldAddPaymentToReportStore()
        {

            ReportStore.Payments.Clear();
            
            MainPanel panel = new MainPanel();

            Payment paymentForm = new Payment(panel);

            DateTime entry = DateTime.Now;
            DateTime exit = entry.AddHours(3);

            paymentForm.AddRow(
                "35 AAA 999",
                "SUV / Light Commercial",
                true,
                entry,
                exit,
                75
            );


            paymentForm.btn_payment_Click(null, EventArgs.Empty);
            
            

            
            Assert.AreEqual(1, ReportStore.Payments.Count);
        }



    }
}
