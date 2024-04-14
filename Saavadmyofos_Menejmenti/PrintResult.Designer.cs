namespace Saavadmyofos_Menejmenti
{
    partial class PrintResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintResult));
            panel1 = new Panel();
            label5 = new Label();
            BtnPrint = new Button();
            comboBoxPacientisfullname = new ComboBox();
            pictureBox4 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-80, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 83);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 117, 224);
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(351, 0);
            label5.Name = "label5";
            label5.Size = new Size(268, 68);
            label5.TabIndex = 15;
            label5.Text = "რეცეპტი";
            // 
            // BtnPrint
            // 
            BtnPrint.BackColor = Color.FromArgb(0, 117, 214);
            BtnPrint.FlatStyle = FlatStyle.Popup;
            BtnPrint.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrint.ForeColor = Color.White;
            BtnPrint.Location = new Point(253, 250);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(286, 57);
            BtnPrint.TabIndex = 33;
            BtnPrint.Text = "ამობეჭდვა";
            BtnPrint.UseVisualStyleBackColor = false;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // comboBoxPacientisfullname
            // 
            comboBoxPacientisfullname.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPacientisfullname.ForeColor = SystemColors.WindowFrame;
            comboBoxPacientisfullname.FormattingEnabled = true;
            comboBoxPacientisfullname.Location = new Point(185, 190);
            comboBoxPacientisfullname.Name = "comboBoxPacientisfullname";
            comboBoxPacientisfullname.Size = new Size(428, 36);
            comboBoxPacientisfullname.TabIndex = 34;
            comboBoxPacientisfullname.Tag = "";
            comboBoxPacientisfullname.Text = "პაციენტის სახელი და გვარი";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(328, 376);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // printDocument1
            // 
            printDocument1.OriginAtMargins = true;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // PrintResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(comboBoxPacientisfullname);
            Controls.Add(BtnPrint);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrintResult";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintResult";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button BtnPrint;
        private ComboBox comboBoxPacientisfullname;
        private PictureBox pictureBox4;
        private PrintPreviewDialog printPreviewDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
    }
}