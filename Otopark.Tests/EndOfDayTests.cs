using otopark_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Tests
{
    [TestClass]
    public class EndOfDayTests
    {

        [TestMethod]
        public void EndOfDay_ShouldLoadPaymentsIntoGrid()
        {
            
            ReportStore.Payments.Clear();

            ReportStore.Payments.Add(new VehiclePayment
            {
                Plate = "34 ABC 123",
                Vehicle = "Car",
                Subscriber = "No",
                EntryTime = "10:00",
                ExitTime = "12:00",
                Fee = "50 TL"
            });

            EndOfDay endOfDay = new EndOfDay();

            
            endOfDay.EndOfDay_Load(null, EventArgs.Empty);

            
            Assert.AreEqual(1, endOfDay.endOfDayDgv.Rows.Count);
        }

    }
}
