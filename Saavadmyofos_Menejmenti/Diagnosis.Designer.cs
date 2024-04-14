namespace Saavadmyofos_Menejmenti
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            comboBoxPacientisfullname = new ComboBox();
            panel2 = new Panel();
            label5 = new Label();
            txtWamlisSaxeli = new TextBox();
            btnDamateba = new Button();
            BtnShenaxva = new Button();
            txtAsaki = new TextBox();
            dataviewSimptomebi = new DataGridView();
            dataviewWamlebi = new DataGridView();
            txtSisxli = new TextBox();
            txtMobilurisNomeri = new TextBox();
            txtEmail = new TextBox();
            txtSqesi = new TextBox();
            btnWashla = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewSimptomebi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataviewWamlebi).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(484, 480);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(362, 480);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBoxPacientisfullname
            // 
            comboBoxPacientisfullname.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPacientisfullname.ForeColor = SystemColors.WindowFrame;
            comboBoxPacientisfullname.FormattingEnabled = true;
            comboBoxPacientisfullname.Location = new Point(12, 107);
            comboBoxPacientisfullname.Name = "comboBoxPacientisfullname";
            comboBoxPacientisfullname.Size = new Size(351, 30);
            comboBoxPacientisfullname.TabIndex = 26;
            comboBoxPacientisfullname.Tag = "";
            comboBoxPacientisfullname.Text = "პაციენტის სახელი და გვარი";
            comboBoxPacientisfullname.SelectedIndexChanged += comboBoxPacientisfullname_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 79);
            panel2.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 117, 224);
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(326, 0);
            label5.Name = "label5";
            label5.Size = new Size(310, 68);
            label5.TabIndex = 16;
            label5.Text = "დიაგნოზი";
            // 
            // txtWamlisSaxeli
            // 
            txtWamlisSaxeli.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWamlisSaxeli.Location = new Point(385, 172);
            txtWamlisSaxeli.Multiline = true;
            txtWamlisSaxeli.Name = "txtWamlisSaxeli";
            txtWamlisSaxeli.PlaceholderText = "წამლის სახელი";
            txtWamlisSaxeli.Size = new Size(252, 34);
            txtWamlisSaxeli.TabIndex = 28;
            // 
            // btnDamateba
            // 
            btnDamateba.BackColor = Color.FromArgb(0, 117, 214);
            btnDamateba.FlatStyle = FlatStyle.Popup;
            btnDamateba.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDamateba.ForeColor = Color.White;
            btnDamateba.Location = new Point(666, 171);
            btnDamateba.Name = "btnDamateba";
            btnDamateba.Size = new Size(123, 40);
            btnDamateba.TabIndex = 29;
            btnDamateba.Text = "დამატება";
            btnDamateba.UseVisualStyleBackColor = false;
            btnDamateba.Click += btnDamateba_Click;
            // 
            // BtnShenaxva
            // 
            BtnShenaxva.BackColor = Color.FromArgb(0, 117, 214);
            BtnShenaxva.FlatStyle = FlatStyle.Popup;
            BtnShenaxva.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnShenaxva.ForeColor = Color.White;
            BtnShenaxva.Location = new Point(704, 493);
            BtnShenaxva.Name = "BtnShenaxva";
            BtnShenaxva.Size = new Size(234, 49);
            BtnShenaxva.TabIndex = 33;
            BtnShenaxva.Text = "შენახვა";
            BtnShenaxva.UseVisualStyleBackColor = false;
            BtnShenaxva.Click += BtnShenaxva_Click;
            // 
            // txtAsaki
            // 
            txtAsaki.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAsaki.Location = new Point(385, 107);
            txtAsaki.Multiline = true;
            txtAsaki.Name = "txtAsaki";
            txtAsaki.PlaceholderText = "ასაკი";
            txtAsaki.ReadOnly = true;
            txtAsaki.Size = new Size(112, 36);
            txtAsaki.TabIndex = 34;
            // 
            // dataviewSimptomebi
            // 
            dataviewSimptomebi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewSimptomebi.Location = new Point(12, 249);
            dataviewSimptomebi.Name = "dataviewSimptomebi";
            dataviewSimptomebi.RowHeadersWidth = 51;
            dataviewSimptomebi.Size = new Size(344, 238);
            dataviewSimptomebi.TabIndex = 37;
            dataviewSimptomebi.CellContentClick += dataviewSimptomebi_CellContentClick;
            // 
            // dataviewWamlebi
            // 
            dataviewWamlebi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewWamlebi.Location = new Point(385, 214);
            dataviewWamlebi.Name = "dataviewWamlebi";
            dataviewWamlebi.RowHeadersWidth = 51;
            dataviewWamlebi.Size = new Size(553, 238);
            dataviewWamlebi.TabIndex = 38;
            // 
            // txtSisxli
            // 
            txtSisxli.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSisxli.Location = new Point(525, 107);
            txtSisxli.Multiline = true;
            txtSisxli.Name = "txtSisxli";
            txtSisxli.PlaceholderText = "სისხლი";
            txtSisxli.ReadOnly = true;
            txtSisxli.Size = new Size(112, 36);
            txtSisxli.TabIndex = 39;
            // 
            // txtMobilurisNomeri
            // 
            txtMobilurisNomeri.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMobilurisNomeri.Location = new Point(12, 161);
            txtMobilurisNomeri.Multiline = true;
            txtMobilurisNomeri.Name = "txtMobilurisNomeri";
            txtMobilurisNomeri.PlaceholderText = "მობილურის ნომერი";
            txtMobilurisNomeri.ReadOnly = true;
            txtMobilurisNomeri.Size = new Size(351, 34);
            txtMobilurisNomeri.TabIndex = 40;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(12, 209);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ელ-ფოსტა";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(351, 34);
            txtEmail.TabIndex = 41;
            // 
            // txtSqesi
            // 
            txtSqesi.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSqesi.Location = new Point(652, 109);
            txtSqesi.Multiline = true;
            txtSqesi.Name = "txtSqesi";
            txtSqesi.PlaceholderText = "სქესი";
            txtSqesi.ReadOnly = true;
            txtSqesi.Size = new Size(286, 34);
            txtSqesi.TabIndex = 42;
            // 
            // btnWashla
            // 
            btnWashla.BackColor = Color.FromArgb(192, 0, 0);
            btnWashla.FlatStyle = FlatStyle.Popup;
            btnWashla.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWashla.ForeColor = Color.White;
            btnWashla.Location = new Point(795, 171);
            btnWashla.Name = "btnWashla";
            btnWashla.Size = new Size(123, 40);
            btnWashla.TabIndex = 43;
            btnWashla.Text = "წაშლა";
            btnWashla.UseVisualStyleBackColor = false;
            btnWashla.Click += btnWashla_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 493);
            button1.Name = "button1";
            button1.Size = new Size(321, 49);
            button1.TabIndex = 44;
            button1.Text = "რეცეპტი";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Diagnosis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 554);
            Controls.Add(button1);
            Controls.Add(btnWashla);
            Controls.Add(txtSqesi);
            Controls.Add(txtEmail);
            Controls.Add(txtMobilurisNomeri);
            Controls.Add(txtSisxli);
            Controls.Add(dataviewWamlebi);
            Controls.Add(dataviewSimptomebi);
            Controls.Add(txtAsaki);
            Controls.Add(BtnShenaxva);
            Controls.Add(btnDamateba);
            Controls.Add(txtWamlisSaxeli);
            Controls.Add(panel2);
            Controls.Add(comboBoxPacientisfullname);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diagnosis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagnosis";
            Load += Diagnosis_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewSimptomebi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataviewWamlebi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private ComboBox comboBoxPacientisfullname;
        private Panel panel2;
        private Label label5;
        private TextBox txtWamlisSaxeli;
        private Button btnDamateba;
        private Button BtnShenaxva;
        private TextBox txtAsaki;
        private DataGridView dataviewSimptomebi;
        private DataGridView dataviewWamlebi;
        private TextBox txtSisxli;
        private TextBox txtMobilurisNomeri;
        private TextBox txtEmail;
        private TextBox txtSqesi;
        private Button btnWashla;
        private Button button1;
    }
}