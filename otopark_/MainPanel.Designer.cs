




namespace otopark_
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            dtp_entry = new DateTimePicker();
            cBox_subscription = new CheckBox();
            btn_end_of_day = new Button();
            btn_user_login = new Button();
            lbl_fill = new Label();
            lbl_total = new Label();
            cBox_vehicle_type = new ComboBox();
            btn_calculate = new Button();
            lbl_user_name = new Label();
            SuspendLayout();
            // 
            // dtp_entry
            // 
            dtp_entry.Location = new Point(246, 133);
            dtp_entry.Name = "dtp_entry";
            dtp_entry.Size = new Size(226, 27);
            dtp_entry.TabIndex = 1;
            
            // 
            // cBox_subscription
            // 
            cBox_subscription.AutoSize = true;
            cBox_subscription.Location = new Point(307, 181);
            cBox_subscription.Name = "cBox_subscription";
            cBox_subscription.Size = new Size(113, 24);
            cBox_subscription.TabIndex = 3;
            cBox_subscription.Text = "Subscription";
            cBox_subscription.UseVisualStyleBackColor = true;
            
            // 
            // btn_end_of_day
            // 
            btn_end_of_day.Font = new Font("Segoe UI", 9F);
            btn_end_of_day.Image = (Image)resources.GetObject("btn_end_of_day.Image");
            btn_end_of_day.ImageAlign = ContentAlignment.MiddleLeft;
            btn_end_of_day.Location = new Point(534, 12);
            btn_end_of_day.Name = "btn_end_of_day";
            btn_end_of_day.Size = new Size(156, 45);
            btn_end_of_day.TabIndex = 4;
            btn_end_of_day.Text = "End Of Day Report";
            btn_end_of_day.TextAlign = ContentAlignment.MiddleRight;
            btn_end_of_day.UseVisualStyleBackColor = true;
            btn_end_of_day.Click += btn_end_of_day_Click;
            // 
            // btn_user_login
            // 
            btn_user_login.Font = new Font("Segoe UI", 9F);
            btn_user_login.Image = (Image)resources.GetObject("btn_user_login.Image");
            btn_user_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_user_login.Location = new Point(12, 12);
            btn_user_login.Name = "btn_user_login";
            btn_user_login.RightToLeft = RightToLeft.No;
            btn_user_login.Size = new Size(124, 45);
            btn_user_login.TabIndex = 7;
            btn_user_login.Text = "User Login";
            btn_user_login.TextAlign = ContentAlignment.MiddleRight;
            btn_user_login.UseVisualStyleBackColor = true;
            btn_user_login.Click += btn_user_login_Click;
            // 
            // lbl_fill
            // 
            lbl_fill.AutoSize = true;
            lbl_fill.Location = new Point(12, 318);
            lbl_fill.Name = "lbl_fill";
            lbl_fill.Size = new Size(172, 20);
            lbl_fill.TabIndex = 10;
            lbl_fill.Text = "Occupancy Rate : 50/100";
            
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(568, 304);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(141, 20);
            lbl_total.TabIndex = 11;
            lbl_total.Text = "Total daily revenue :";
            
            // 
            // cBox_vehicle_type
            // 
            cBox_vehicle_type.FormattingEnabled = true;
            cBox_vehicle_type.Location = new Point(246, 87);
            cBox_vehicle_type.Name = "cBox_vehicle_type";
            cBox_vehicle_type.Size = new Size(187, 28);
            cBox_vehicle_type.TabIndex = 14;
            
            // 
            // btn_calculate
            // 
            btn_calculate.Font = new Font("Segoe UI", 11F);
            btn_calculate.Image = (Image)resources.GetObject("btn_calculate.Image");
            btn_calculate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_calculate.Location = new Point(246, 223);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(187, 45);
            btn_calculate.TabIndex = 15;
            btn_calculate.Text = "Calculate Fee";
            btn_calculate.TextAlign = ContentAlignment.MiddleRight;
            btn_calculate.UseVisualStyleBackColor = true;
            btn_calculate.Click += btn_calculate_Click;
            // 
            // lbl_user_name
            // 
            lbl_user_name.AutoSize = true;
            lbl_user_name.Location = new Point(12, 69);
            lbl_user_name.Name = "lbl_user_name";
            lbl_user_name.Size = new Size(0, 20);
            lbl_user_name.TabIndex = 16;
            
            // 
            // MainPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(893, 463);
            Controls.Add(lbl_user_name);
            Controls.Add(btn_calculate);
            Controls.Add(cBox_vehicle_type);
            Controls.Add(lbl_total);
            Controls.Add(lbl_fill);
            Controls.Add(btn_user_login);
            Controls.Add(btn_end_of_day);
            Controls.Add(cBox_subscription);
            Controls.Add(dtp_entry);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Payment System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_entry;
        private CheckBox cBox_subscription;
        private Button btn_end_of_day;
        private Button btn_user_login;
        private Label lbl_fill;
        private Label lbl_total;
        private ComboBox cBox_vehicle_type;
        private Button btn_calculate;
        private Label lbl_user_name;
    }
}
