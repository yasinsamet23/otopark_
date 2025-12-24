using System;
using System.Windows.Forms;






namespace otopark_
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();



        }
        private Payment form3Instance;
        private bool isUserLoggedIn = false;

        
        private int totalCapacity = 100;
        private int currentFilled = 55;
        private double totalDailyRevenue = 0;


        private readonly Random rnd = new Random();

        public static bool getEndOfDayReport = true;






        private int space_area = 50;
        public int Space_Area
        {
            get { return space_area; }

            set
            {
                space_area = value;
                lbl_fill.Text = $"Empty Space : {space_area}/100";
            }

        }

        
        private double total_daily_income = 0;
        public double totalDailyIncome
        {
            get { return total_daily_income; }

            set
            {
                total_daily_income = value;
                lbl_total.Text = $"Total Daily Revenue : {total_daily_income} TL";

            }

        }

        private System.Windows.Forms.Timer occupancyTimer;







        public DateTime GenerateRandomExit(DateTime entry)
        {
            int minMinutes = 5;                     // en az 5 dk
            int maxMinutes = 30 * 24 * 60;          // 30 gün
            int minutes = rnd.Next(minMinutes, maxMinutes + 1);

            return entry.AddMinutes(minutes);
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            cBox_vehicle_type.Items.Add("Motorcycle");
            cBox_vehicle_type.Items.Add("Car");
            cBox_vehicle_type.Items.Add("SUV / Light Commercial");
            cBox_vehicle_type.Items.Add("Minibus / Midibus");
            cBox_vehicle_type.Items.Add("Bus / Truck");


            cBox_vehicle_type.SelectedIndex = 1;



            dtp_entry.Format = DateTimePickerFormat.Custom;
            dtp_entry.CustomFormat = "dd.MM.yyyy HH:mm";
            dtp_entry.ShowUpDown = false;

            lbl_fill.Text = $"Empty space : {Space_Area}/100";



            occupancyTimer = new System.Windows.Forms.Timer();
            occupancyTimer.Interval = 30000; // 30 saniye
            occupancyTimer.Tick += OccupancyTimer_Tick;
            occupancyTimer.Start();

            lbl_total.Text = $"Total Daily Revenue : {total_daily_income} TL";
        }












        private void btn_end_of_day_Click(object sender, EventArgs e)
        {
            if (!isUserLoggedIn)
            {
                MessageBox.Show("You must login first!");
                return;
            }

            EndOfDay endOfDay = new EndOfDay(this);
            endOfDay.ShowDialog();


        }




        public string RandomPlate()
        {
            int provinceCode = rnd.Next(1, 82);
            string letters = "";
            for (int i = 0; i < 3; i++)
                letters += (char)rnd.Next('A', 'Z' + 1);

            int number = rnd.Next(1, 1000);

            return provinceCode.ToString("00") + " " + letters + " " + number.ToString("000");
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            if (!isUserLoggedIn)
            {
                MessageBox.Show("You must login first!");
                return;
            }


            if (Space_Area == 100)
            {
                MessageBox.Show(
                    "The car park is completely empty; please wait for a vehicle to enter before making a calculation.",
                    "Parking Empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning

                );
                btn_calculate.Enabled = false;


                return;
            }

            



                string plate = "";
            string vehicle = cBox_vehicle_type.SelectedItem.ToString();
            bool subscriber = cBox_subscription.Checked;
            DateTime entryTime = dtp_entry.Value;
            DateTime exitTime = GenerateRandomExit(entryTime);
            ParkingCalculator parkingCalculator = new ParkingCalculator();

            double fee = parkingCalculator.CalculateFee(vehicle, entryTime, exitTime, subscriber);

            if (fee < 0)
            {
                MessageBox.Show("Error calculating fee!");
                return;
            }

            if (subscriber)
                plate = RandomPlate();


            Payment form3 = new Payment(this);
            form3.AddRow(plate, vehicle, subscriber, entryTime, exitTime, fee);
            form3.ShowDialog();










            // Günlük toplam hasýlatý burada artýrmak istemiyorsan þimdilik dokunma

            //girdilere göre ödeme hesapla
            /*
            1) Motosiklet
Süre	Hafta Ýçi	Hafta Sonu
0–1 saat	15 TL	20 TL
1–3 saat	25 TL	30 TL
3–8 saat	35 TL	45 TL
8–24 saat	50 TL	60 TL

            2) Binek Otomobil
Süre	Hafta Ýçi	Hafta Sonu
0–1 saat	30 TL	40 TL
1–3 saat	50 TL	65 TL
3–8 saat	80 TL	100 TL
8–24 saat	120 TL	150 TL

            3) SUV / Hafif Ticari
Süre	Hafta Ýçi	Hafta Sonu
0–1 saat	40 TL	55 TL
1–3 saat	70 TL	90 TL
3–8 saat	110 TL	140 TL
8–24 saat	150 TL	200 TL

            4) Minibüs / Midibüs
Süre	Hafta Ýçi	Hafta Sonu
0–1 saat	60 TL	80 TL
1–3 saat	90 TL	120 TL
3–8 saat	140 TL	180 TL
8–24 saat	220 TL	280 TL

            5) Otobüs / Kamyon (Aðýr vasýta)
Süre	Hafta Ýçi	Hafta Sonu
0–1 saat	100 TL	130 TL
1–3 saat	150 TL	200 TL
3–8 saat	250 TL	320 TL
8–24 saat	350 TL	450 TL

            Not:
Abonelere özel toplam tutardan %25 indirim uygulanýr.

             */
        }








        private void btn_user_login_Click(object sender, EventArgs e)
        {
            if (!isUserLoggedIn)
            {
                LogIn form2 = new LogIn();
                form2.ShowDialog();

                if (form2.HasLoggedIn)
                {
                    isUserLoggedIn = true;
                    lbl_user_name.Text = "Welcome, " + LogIn.Usernameinput;
                    btn_user_login.Text = "Logout";
                }
            }
            else
            {
                // Logout iþlemi
                if(getEndOfDayReport==false)
                {
                    MessageBox.Show("You must export the end-of-day report to Excel before logging out.");
                    return;
                }

                isUserLoggedIn = false;
                lbl_user_name.Text = "";
                btn_user_login.Text = "User Login";
                MessageBox.Show("User Logout Completed!");
            }


        }

        private void OccupancyTimer_Tick(object sender, EventArgs e)
        {
            Space_Area = Math.Max(0, Space_Area - 5);
            btn_calculate.Enabled = true;
        }

        
    }
}
