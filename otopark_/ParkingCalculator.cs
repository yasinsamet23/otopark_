using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace otopark_
{
    public class ParkingCalculator
    {
        
        Dictionary<string, (int[] weekday, int[] weekend)> tariffs =
            new Dictionary<string, (int[], int[])>()
            {
                { "Motorcycle",            (new[] { 15, 25, 35, 50 },  new[] { 20, 30, 45, 60 }) },
                { "Car",                   (new[] { 30, 50, 80, 120 }, new[] { 40, 65, 100, 150 }) },
                { "SUV / Light Commercial",(new[] { 40, 70, 110, 160 },new[] { 55, 90, 140, 200 }) },
                { "Minibus / Midibus",     (new[] { 60, 90, 140, 220 },new[] { 80, 120, 180, 280 }) },
                { "Bus / Truck",           (new[] { 100, 150, 250, 350 },new[] { 130, 200, 320, 450 }) }
            };

        
        public double CalculateFee(string vehicleType, DateTime entry, DateTime exit, bool isSubscriber)
        {
            if (!tariffs.ContainsKey(vehicleType)) return -1;
            if (exit <= entry) return -1;

            TimeSpan duration = exit - entry;
            double totalFee = 0;
            double remainingMinutes = duration.TotalMinutes;

            var tariff = tariffs[vehicleType];

            int safetyCounter = 0; 
            while (remainingMinutes > 0 && safetyCounter < 100)
            {
                safetyCounter++;

                DateTime segmentStart = entry;
                DateTime segmentEnd = entry.Date.AddDays(1); 

                if (segmentEnd > exit)
                    segmentEnd = exit;

                double segmentHours = (segmentEnd - segmentStart).TotalHours;

                if (segmentHours <= 0)
                    break; // Güvenlik — segment bozuksa çık

                bool weekend = (segmentStart.DayOfWeek == DayOfWeek.Saturday ||
                                segmentStart.DayOfWeek == DayOfWeek.Sunday);
                int[] priceSet = weekend ? tariff.weekend : tariff.weekday;

                if (segmentHours <= 1) totalFee += priceSet[0];
                else if (segmentHours <= 3) totalFee += priceSet[1];
                else if (segmentHours <= 8) totalFee += priceSet[2];
                else totalFee += priceSet[3];

                remainingMinutes -= segmentHours * 60;
                entry = segmentEnd;
            }

            if (safetyCounter >= 100)
            {
                MessageBox.Show("Parking fee calculation aborted (loop safety triggered).");
                return -1;
            }

            if (isSubscriber)
                totalFee *= 0.75;

            return Math.Round(totalFee, 2);
        }
    }
}