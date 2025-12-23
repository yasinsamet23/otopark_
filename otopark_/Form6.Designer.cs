namespace otopark_
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            listBox_message = new ListBox();
            btn_ok = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox_message
            // 
            listBox_message.FormattingEnabled = true;
            listBox_message.ItemHeight = 15;
            listBox_message.Location = new Point(43, 37);
            listBox_message.Name = "listBox_message";
            listBox_message.Size = new Size(328, 79);
            listBox_message.TabIndex = 5;
            listBox_message.SelectedIndexChanged += listBox_message_SelectedIndexChanged;
            // 
            // btn_ok
            // 
            btn_ok.Image = (Image)resources.GetObject("btn_ok.Image");
            btn_ok.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ok.Location = new Point(146, 137);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(128, 37);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "OK";
            btn_ok.TextAlign = ContentAlignment.MiddleRight;
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(45, 187);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 6;
            label1.Text = "Not: form yerine MessageBox kullanılabilir";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 211);
            Controls.Add(label1);
            Controls.Add(listBox_message);
            Controls.Add(btn_ok);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_message;
        private Button btn_ok;
        private Label label1;
    }
}