namespace Saavadmyofos_Menejmenti
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            DoctorsPicture = new PictureBox();
            PatientsPicture = new PictureBox();
            DiagnosisPicture = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            treeView1 = new TreeView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DoctorsPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientsPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DoctorsPicture
            // 
            DoctorsPicture.Image = (Image)resources.GetObject("DoctorsPicture.Image");
            DoctorsPicture.Location = new Point(2, 218);
            DoctorsPicture.Name = "DoctorsPicture";
            DoctorsPicture.Size = new Size(263, 230);
            DoctorsPicture.SizeMode = PictureBoxSizeMode.Zoom;
            DoctorsPicture.TabIndex = 0;
            DoctorsPicture.TabStop = false;
            DoctorsPicture.Click += DoctorsPicture_Click;
            // 
            // PatientsPicture
            // 
            PatientsPicture.Image = (Image)resources.GetObject("PatientsPicture.Image");
            PatientsPicture.Location = new Point(262, 218);
            PatientsPicture.Name = "PatientsPicture";
            PatientsPicture.Size = new Size(263, 230);
            PatientsPicture.SizeMode = PictureBoxSizeMode.Zoom;
            PatientsPicture.TabIndex = 0;
            PatientsPicture.TabStop = false;
            PatientsPicture.Click += PatientsPicture_Click;
            // 
            // DiagnosisPicture
            // 
            DiagnosisPicture.Image = (Image)resources.GetObject("DiagnosisPicture.Image");
            DiagnosisPicture.Location = new Point(518, 218);
            DiagnosisPicture.Name = "DiagnosisPicture";
            DiagnosisPicture.Size = new Size(263, 230);
            DiagnosisPicture.SizeMode = PictureBoxSizeMode.Zoom;
            DiagnosisPicture.TabIndex = 0;
            DiagnosisPicture.TabStop = false;
            DiagnosisPicture.Click += DiagnosisPicture_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(390, 480);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 17, 214);
            label1.Location = new Point(77, 159);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 2;
            label1.Text = "ექიმები";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 17, 214);
            label2.Location = new Point(322, 159);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 3;
            label2.Text = "პაციენტები";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 17, 214);
            label3.Location = new Point(585, 159);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 4;
            label3.Text = "დიაგნოზი";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 480);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(0, 117, 224);
            treeView1.ForeColor = Color.FromArgb(0, 117, 224);
            treeView1.LineColor = Color.White;
            treeView1.Location = new Point(-6, -2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(794, 121);
            treeView1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 117, 224);
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(124, 22);
            label5.Name = "label5";
            label5.Size = new Size(563, 68);
            label5.TabIndex = 8;
            label5.Text = "აირჩიეთ ერთ-ერთი";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 554);
            Controls.Add(label5);
            Controls.Add(treeView1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(DiagnosisPicture);
            Controls.Add(PatientsPicture);
            Controls.Add(DoctorsPicture);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)DoctorsPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientsPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiagnosisPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DoctorsPicture;
        private PictureBox PatientsPicture;
        private PictureBox DiagnosisPicture;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TreeView treeView1;
        private Label label5;
    }
}