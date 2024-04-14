namespace Saavadmyofos_Menejmenti
{
    partial class AddPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatients));
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            txtSaxeli = new TextBox();
            txtAsaki = new TextBox();
            ComboboxSqesi = new ComboBox();
            txtGvari = new TextBox();
            combosisxli = new ComboBox();
            comboBoxEqimi = new ComboBox();
            txtEmail = new TextBox();
            txtMobilurisNomeri = new TextBox();
            txtDazghveva = new TextBox();
            txtGadasakhdeliTanxa = new TextBox();
            comboBoxSimptomebi = new ComboBox();
            BtnShenaxva = new Button();
            txtSxvaSimptomebi = new TextBox();
            btnPacientebi = new Button();
            txtpiradinomeri = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(484, 489);
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
            pictureBox1.Location = new Point(362, 489);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 79);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 117, 224);
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(316, 0);
            label5.Name = "label5";
            label5.Size = new Size(348, 68);
            label5.TabIndex = 15;
            label5.Text = "პაციენტები";
            // 
            // txtSaxeli
            // 
            txtSaxeli.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSaxeli.Location = new Point(24, 92);
            txtSaxeli.Multiline = true;
            txtSaxeli.Name = "txtSaxeli";
            txtSaxeli.PlaceholderText = "სახელი";
            txtSaxeli.Size = new Size(286, 34);
            txtSaxeli.TabIndex = 17;
            // 
            // txtAsaki
            // 
            txtAsaki.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAsaki.Location = new Point(198, 199);
            txtAsaki.Multiline = true;
            txtAsaki.Name = "txtAsaki";
            txtAsaki.PlaceholderText = "ასაკი";
            txtAsaki.Size = new Size(112, 36);
            txtAsaki.TabIndex = 19;
            // 
            // ComboboxSqesi
            // 
            ComboboxSqesi.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboboxSqesi.ForeColor = SystemColors.WindowFrame;
            ComboboxSqesi.FormattingEnabled = true;
            ComboboxSqesi.Items.AddRange(new object[] { "მდედრობითი", "მამრობითი" });
            ComboboxSqesi.Location = new Point(24, 258);
            ComboboxSqesi.Name = "ComboboxSqesi";
            ComboboxSqesi.Size = new Size(286, 36);
            ComboboxSqesi.TabIndex = 22;
            ComboboxSqesi.Text = "სქესი";
            // 
            // txtGvari
            // 
            txtGvari.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGvari.Location = new Point(24, 147);
            txtGvari.Multiline = true;
            txtGvari.Name = "txtGvari";
            txtGvari.PlaceholderText = "გვარი";
            txtGvari.Size = new Size(286, 34);
            txtGvari.TabIndex = 23;
            // 
            // combosisxli
            // 
            combosisxli.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combosisxli.ForeColor = SystemColors.WindowFrame;
            combosisxli.FormattingEnabled = true;
            combosisxli.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            combosisxli.Location = new Point(24, 199);
            combosisxli.Name = "combosisxli";
            combosisxli.Size = new Size(168, 36);
            combosisxli.TabIndex = 24;
            combosisxli.Text = "სისხლი";
            // 
            // comboBoxEqimi
            // 
            comboBoxEqimi.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxEqimi.ForeColor = SystemColors.WindowFrame;
            comboBoxEqimi.FormattingEnabled = true;
            comboBoxEqimi.Location = new Point(325, 147);
            comboBoxEqimi.Name = "comboBoxEqimi";
            comboBoxEqimi.Size = new Size(257, 30);
            comboBoxEqimi.TabIndex = 25;
            comboBoxEqimi.Tag = "";
            comboBoxEqimi.SelectedIndexChanged += comboBoxEqimi_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(24, 418);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ელ-ფოსტა";
            txtEmail.Size = new Size(558, 34);
            txtEmail.TabIndex = 26;
            // 
            // txtMobilurisNomeri
            // 
            txtMobilurisNomeri.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMobilurisNomeri.Location = new Point(24, 366);
            txtMobilurisNomeri.Multiline = true;
            txtMobilurisNomeri.Name = "txtMobilurisNomeri";
            txtMobilurisNomeri.PlaceholderText = "მობილურის ნომერი";
            txtMobilurisNomeri.Size = new Size(558, 34);
            txtMobilurisNomeri.TabIndex = 27;
            // 
            // txtDazghveva
            // 
            txtDazghveva.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDazghveva.Location = new Point(325, 199);
            txtDazghveva.Multiline = true;
            txtDazghveva.Name = "txtDazghveva";
            txtDazghveva.PlaceholderText = "დაზღვევა";
            txtDazghveva.Size = new Size(257, 34);
            txtDazghveva.TabIndex = 28;
            // 
            // txtGadasakhdeliTanxa
            // 
            txtGadasakhdeliTanxa.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGadasakhdeliTanxa.Location = new Point(325, 260);
            txtGadasakhdeliTanxa.Multiline = true;
            txtGadasakhdeliTanxa.Name = "txtGadasakhdeliTanxa";
            txtGadasakhdeliTanxa.PlaceholderText = "გადასახდელი თანხა";
            txtGadasakhdeliTanxa.Size = new Size(257, 34);
            txtGadasakhdeliTanxa.TabIndex = 29;
            // 
            // comboBoxSimptomebi
            // 
            comboBoxSimptomebi.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSimptomebi.ForeColor = SystemColors.WindowFrame;
            comboBoxSimptomebi.FormattingEnabled = true;
            comboBoxSimptomebi.Items.AddRange(new object[] { "სიცხე", "ყელის ტკივილი", "ხველება", "ცემინება", "თავის ტკივილი", "სუნთქვის გაძნელება", "ქოშინი", "არითმია", "სხვა" });
            comboBoxSimptomebi.Location = new Point(325, 98);
            comboBoxSimptomebi.Name = "comboBoxSimptomebi";
            comboBoxSimptomebi.Size = new Size(182, 30);
            comboBoxSimptomebi.TabIndex = 30;
            comboBoxSimptomebi.Text = "სიმპტომები";
            comboBoxSimptomebi.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // BtnShenaxva
            // 
            BtnShenaxva.BackColor = Color.FromArgb(0, 117, 214);
            BtnShenaxva.FlatStyle = FlatStyle.Popup;
            BtnShenaxva.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnShenaxva.ForeColor = Color.White;
            BtnShenaxva.Location = new Point(664, 502);
            BtnShenaxva.Name = "BtnShenaxva";
            BtnShenaxva.Size = new Size(286, 40);
            BtnShenaxva.TabIndex = 32;
            BtnShenaxva.Text = "შენახვა";
            BtnShenaxva.UseVisualStyleBackColor = false;
            BtnShenaxva.Click += BtnShenaxva_Click;
            // 
            // txtSxvaSimptomebi
            // 
            txtSxvaSimptomebi.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSxvaSimptomebi.ForeColor = SystemColors.WindowFrame;
            txtSxvaSimptomebi.Location = new Point(513, 98);
            txtSxvaSimptomebi.Multiline = true;
            txtSxvaSimptomebi.Name = "txtSxvaSimptomebi";
            txtSxvaSimptomebi.PlaceholderText = "სხვა სიმპტომები";
            txtSxvaSimptomebi.ReadOnly = true;
            txtSxvaSimptomebi.Size = new Size(182, 34);
            txtSxvaSimptomebi.TabIndex = 33;
            // 
            // btnPacientebi
            // 
            btnPacientebi.BackColor = Color.FromArgb(0, 117, 214);
            btnPacientebi.FlatStyle = FlatStyle.Popup;
            btnPacientebi.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientebi.ForeColor = Color.White;
            btnPacientebi.Location = new Point(24, 471);
            btnPacientebi.Name = "btnPacientebi";
            btnPacientebi.Size = new Size(286, 71);
            btnPacientebi.TabIndex = 34;
            btnPacientebi.Text = "პაციენტების სია";
            btnPacientebi.UseVisualStyleBackColor = false;
            btnPacientebi.Click += btnPacientebi_Click;
            // 
            // txtpiradinomeri
            // 
            txtpiradinomeri.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpiradinomeri.Location = new Point(24, 316);
            txtpiradinomeri.Multiline = true;
            txtpiradinomeri.Name = "txtpiradinomeri";
            txtpiradinomeri.PlaceholderText = "პირადი ნომერი";
            txtpiradinomeri.Size = new Size(558, 34);
            txtpiradinomeri.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(606, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(333, 305);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(701, 92);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 37;
            button1.Text = "დამატება";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(827, 92);
            button2.Name = "button2";
            button2.Size = new Size(123, 40);
            button2.TabIndex = 38;
            button2.Text = "წაშლა";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 554);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtpiradinomeri);
            Controls.Add(btnPacientebi);
            Controls.Add(txtSxvaSimptomebi);
            Controls.Add(BtnShenaxva);
            Controls.Add(comboBoxSimptomebi);
            Controls.Add(txtGadasakhdeliTanxa);
            Controls.Add(txtDazghveva);
            Controls.Add(txtMobilurisNomeri);
            Controls.Add(txtEmail);
            Controls.Add(comboBoxEqimi);
            Controls.Add(combosisxli);
            Controls.Add(txtGvari);
            Controls.Add(ComboboxSqesi);
            Controls.Add(txtAsaki);
            Controls.Add(txtSaxeli);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPatients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "დამატება";
            Load += AddPatients_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private TextBox txtSaxeli;
        private TextBox txtAsaki;
        private ComboBox ComboboxSqesi;
        private TextBox txtGvari;
        private ComboBox combosisxli;
        private ComboBox comboBoxEqimi;
        private TextBox txtEmail;
        private TextBox txtMobilurisNomeri;
        private TextBox txtDazghveva;
        private TextBox txtGadasakhdeliTanxa;
        private ComboBox comboBoxSimptomebi;
        private Button BtnShenaxva;
        private TextBox txtSxvaSimptomebi;
        private Button btnPacientebisSia;
        private Button btnPacientebi;
        private TextBox txtpiradinomeri;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}