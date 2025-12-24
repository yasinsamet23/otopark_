using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;



namespace otopark_
{
    public partial class EndOfDay : Form
    {
        private MainPanel mainPanel;
        public EndOfDay(MainPanel panel)
        {
            InitializeComponent();
            mainPanel = panel;
        }
        public EndOfDay() 
        {
            InitializeComponent();
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            
            MainPanel.getEndOfDayReport = true;
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // 1️⃣ Sütun başlıkları
            for (int i = 0; i < endOfDayDgv.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = endOfDayDgv.Columns[i].HeaderText;
                worksheet.Cells[1, i + 1].Font.Bold = true;
            }

            // 2️⃣ Satırlar
            for (int r = 0; r < endOfDayDgv.Rows.Count; r++)
            {
                if (endOfDayDgv.Rows[r].IsNewRow) continue;

                for (int c = 0; c < endOfDayDgv.Columns.Count; c++)
                {
                    worksheet.Cells[r + 2, c + 1] = endOfDayDgv.Rows[r].Cells[c].Value;
                    worksheet.Cells[r + 2, c + 1].WrapText = true; // uzun yazı alta insin
                }
            }


            int totalRow = endOfDayDgv.Rows
    .Cast<DataGridViewRow>()
    .Count(r => !r.IsNewRow) + 2;

            worksheet.Cells[totalRow, endOfDayDgv.Columns.Count - 1] = "TOTAL";
            worksheet.Cells[totalRow, endOfDayDgv.Columns.Count - 1].Font.Bold = true;

            worksheet.Cells[totalRow, endOfDayDgv.Columns.Count] =
                mainPanel.totalDailyIncome + " TL";
            worksheet.Cells[totalRow, endOfDayDgv.Columns.Count].Font.Bold = true;



            worksheet.Columns.AutoFit();

            
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string fileName = $"EndOfDayReport_{timestamp}.xlsx";

            
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullPath = Path.Combine(desktopPath, fileName);

            
            workbook.SaveAs(fullPath);

            

            MessageBox.Show($"Excel report created successfully!\n\nFile:\n{fullPath}");


            
           


        }

        

        public void EndOfDay_Load(object sender, EventArgs e)
        {
            endOfDayDgv.AllowUserToAddRows = false;

            if (endOfDayDgv.Columns.Count == 0)
            {
                endOfDayDgv.Columns.Add("plate", "Plate");
                endOfDayDgv.Columns.Add("vehicle", "Vehicle");
                endOfDayDgv.Columns.Add("subscriber", "Subscriber");
                endOfDayDgv.Columns.Add("entryTime", "Entry Time");
                endOfDayDgv.Columns.Add("exitTime", "Exit Time");
                endOfDayDgv.Columns.Add("fee", "Fee");
            }

            endOfDayDgv.Rows.Clear();

            foreach (var p in ReportStore.Payments)
            {
                endOfDayDgv.Rows.Add(
                    p.Plate,
                    p.Vehicle,
                    p.Subscriber,
                    p.EntryTime,
                    p.ExitTime,
                    p.Fee
                );
            }
        }
    }
}
