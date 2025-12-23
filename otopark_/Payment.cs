using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark_
{
    public partial class Payment : Form
    {
        private MainPanel mainPanel;
        public Payment(MainPanel panel)
        {
            InitializeComponent();
            mainPanel = panel;

            
            if (dgvvehicleInfo.Columns.Count == 0)
            {
                dgvvehicleInfo.Columns.Add("plate", "Plate");
                dgvvehicleInfo.Columns.Add("vehicle", "Vehicle");
                dgvvehicleInfo.Columns.Add("subscriber", "Subscriber");
                dgvvehicleInfo.Columns.Add("entryTime", "Entry Time");
                dgvvehicleInfo.Columns.Add("exitTime", "Exit Time");
                dgvvehicleInfo.Columns.Add("fee", "Fee (TL)");
            }
        }

        


        public void AddRow(string plate, string vehicle, bool subscriber, DateTime entryTime, DateTime exitTime, double fee)
        {
            dgvvehicleInfo.Rows.Add(
                plate,
                vehicle,
                subscriber ? "Yes" : "No",
                entryTime.ToString("g"),
                exitTime.ToString("g"),
                fee.ToString("0.00") + " TL"
            );
        }




        public void btn_payment_Click(object sender, EventArgs e)
        {

            
            mainPanel.Space_Area += 1;



            if (dgvvehicleInfo.Rows.Count == 0)
                return;

            


            // Son satırı al
            DataGridViewRow row = dgvvehicleInfo.Rows[dgvvehicleInfo.Rows.Count - 2];


            // Günlük toplam kazanç arttılır
            string feeText = row.Cells["fee"].Value.ToString()
                    .Replace(" TL", "");
                    

            double feeValue = Convert.ToDouble(feeText);

            mainPanel.totalDailyIncome += feeValue;




            VehiclePayment payment = new VehiclePayment
            {
                Plate = row.Cells["plate"].Value.ToString(),
                Vehicle = row.Cells["vehicle"].Value.ToString(),
                Subscriber = row.Cells["subscriber"].Value.ToString(),
                EntryTime = row.Cells["entryTime"].Value.ToString(),
                ExitTime = row.Cells["exitTime"].Value.ToString(),
                Fee = row.Cells["fee"].Value.ToString()
            };

           
            ReportStore.Payments.Add(payment);

            this.Close();
        }

        
    }
}
