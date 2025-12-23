namespace otopark_
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            btn_payment = new Button();
            dgvvehicleInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvvehicleInfo).BeginInit();
            SuspendLayout();
            // 
            // btn_payment
            // 
            btn_payment.Image = (Image)resources.GetObject("btn_payment.Image");
            btn_payment.ImageAlign = ContentAlignment.MiddleLeft;
            btn_payment.Location = new Point(100, 219);
            btn_payment.Margin = new Padding(3, 4, 3, 4);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(206, 49);
            btn_payment.TabIndex = 13;
            btn_payment.Text = "Payment received";
            btn_payment.TextAlign = ContentAlignment.MiddleRight;
            btn_payment.UseVisualStyleBackColor = true;
            btn_payment.Click += btn_payment_Click;
            // 
            // dgvvehicleInfo
            // 
            dgvvehicleInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvvehicleInfo.Location = new Point(48, 51);
            dgvvehicleInfo.Name = "dgvvehicleInfo";
            dgvvehicleInfo.RowHeadersWidth = 51;
            dgvvehicleInfo.Size = new Size(354, 80);
            dgvvehicleInfo.TabIndex = 14;
            
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 281);
            Controls.Add(dgvvehicleInfo);
            Controls.Add(btn_payment);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Payment System";
            ((System.ComponentModel.ISupportInitialize)dgvvehicleInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_payment;
        private DataGridView dgvvehicleInfo;
    }
}