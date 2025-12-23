namespace otopark_
{
    partial class EndOfDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndOfDay));
            btn_print = new Button();
            endOfDayDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)endOfDayDgv).BeginInit();
            SuspendLayout();
            // 
            // btn_print
            // 
            btn_print.Image = (Image)resources.GetObject("btn_print.Image");
            btn_print.ImageAlign = ContentAlignment.MiddleLeft;
            btn_print.Location = new Point(128, 225);
            btn_print.Margin = new Padding(3, 4, 3, 4);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(206, 49);
            btn_print.TabIndex = 4;
            btn_print.Text = "Export to Excel";
            btn_print.TextAlign = ContentAlignment.MiddleRight;
            btn_print.UseVisualStyleBackColor = true;
            btn_print.Click += btn_print_Click;
            // 
            // endOfDayDgv
            // 
            endOfDayDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            endOfDayDgv.Location = new Point(12, 12);
            endOfDayDgv.Name = "endOfDayDgv";
            endOfDayDgv.RowHeadersWidth = 51;
            endOfDayDgv.Size = new Size(449, 188);
            endOfDayDgv.TabIndex = 5;
            // 
            // EndOfDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 310);
            Controls.Add(endOfDayDgv);
            Controls.Add(btn_print);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EndOfDay";
            Text = "End Of Day Report";
            Load += EndOfDay_Load;
            ((System.ComponentModel.ISupportInitialize)endOfDayDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_print;
        public DataGridView endOfDayDgv;
    }
}