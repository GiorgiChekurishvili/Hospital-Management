namespace Saavadmyofos_Menejmenti
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            txtSaxeli = new TextBox();
            txtGvari = new TextBox();
            txtGamocdileba = new TextBox();
            txtAsaki = new TextBox();
            txtProfesia = new TextBox();
            txtEmail = new TextBox();
            txtMobilurisNomeri = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            txtPiradiNomeri = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 79);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 117, 224);
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(378, 0);
            label5.Name = "label5";
            label5.Size = new Size(245, 68);
            label5.TabIndex = 16;
            label5.Text = "ექიმები";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(264, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 329);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(263, 94);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "სახელი";
            txtUsername.Size = new Size(175, 34);
            txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(453, 94);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "პაროლი";
            txtPassword.Size = new Size(175, 34);
            txtPassword.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(0, 117, 214);
            checkBox1.Location = new Point(643, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(288, 22);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "ლოგინის უფლებები მიეცეს ექიმს?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSaxeli
            // 
            txtSaxeli.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSaxeli.Location = new Point(24, 85);
            txtSaxeli.Multiline = true;
            txtSaxeli.Name = "txtSaxeli";
            txtSaxeli.PlaceholderText = "ექიმის სახელი";
            txtSaxeli.Size = new Size(214, 34);
            txtSaxeli.TabIndex = 0;
            // 
            // txtGvari
            // 
            txtGvari.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGvari.Location = new Point(24, 125);
            txtGvari.Multiline = true;
            txtGvari.Name = "txtGvari";
            txtGvari.PlaceholderText = "გვარი";
            txtGvari.Size = new Size(214, 34);
            txtGvari.TabIndex = 1;
            // 
            // txtGamocdileba
            // 
            txtGamocdileba.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGamocdileba.Location = new Point(24, 245);
            txtGamocdileba.Multiline = true;
            txtGamocdileba.Name = "txtGamocdileba";
            txtGamocdileba.PlaceholderText = "გამოცდილება";
            txtGamocdileba.Size = new Size(117, 34);
            txtGamocdileba.TabIndex = 2;
            // 
            // txtAsaki
            // 
            txtAsaki.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAsaki.Location = new Point(147, 245);
            txtAsaki.Multiline = true;
            txtAsaki.Name = "txtAsaki";
            txtAsaki.PlaceholderText = "ასაკი";
            txtAsaki.Size = new Size(91, 34);
            txtAsaki.TabIndex = 3;
            // 
            // txtProfesia
            // 
            txtProfesia.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProfesia.Location = new Point(24, 205);
            txtProfesia.Multiline = true;
            txtProfesia.Name = "txtProfesia";
            txtProfesia.PlaceholderText = "პროფესია";
            txtProfesia.Size = new Size(214, 34);
            txtProfesia.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(0, 325);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ელ-ფოსტა";
            txtEmail.Size = new Size(265, 103);
            txtEmail.TabIndex = 5;
            // 
            // txtMobilurisNomeri
            // 
            txtMobilurisNomeri.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMobilurisNomeri.Location = new Point(24, 285);
            txtMobilurisNomeri.Multiline = true;
            txtMobilurisNomeri.Name = "txtMobilurisNomeri";
            txtMobilurisNomeri.PlaceholderText = "მობილურის ნომერი";
            txtMobilurisNomeri.Size = new Size(214, 34);
            txtMobilurisNomeri.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 434);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 7;
            button1.Text = "დამატება";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 117, 214);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(121, 434);
            button2.Name = "button2";
            button2.Size = new Size(144, 40);
            button2.TabIndex = 8;
            button2.Text = "რედაქტირება";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 480);
            button3.Name = "button3";
            button3.Size = new Size(262, 55);
            button3.TabIndex = 9;
            button3.Text = "წაშლა";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPiradiNomeri);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtAsaki);
            panel1.Controls.Add(txtGamocdileba);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtMobilurisNomeri);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtProfesia);
            panel1.Controls.Add(txtGvari);
            panel1.Controls.Add(txtSaxeli);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 539);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // txtPiradiNomeri
            // 
            txtPiradiNomeri.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPiradiNomeri.Location = new Point(24, 165);
            txtPiradiNomeri.Multiline = true;
            txtPiradiNomeri.Name = "txtPiradiNomeri";
            txtPiradiNomeri.PlaceholderText = "პირადი ნომერი";
            txtPiradiNomeri.Size = new Size(214, 34);
            txtPiradiNomeri.TabIndex = 10;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 554);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private TextBox txtSaxeli;
        private TextBox txtGvari;
        private TextBox txtGamocdileba;
        private TextBox txtAsaki;
        private TextBox txtProfesia;
        private TextBox txtEmail;
        private TextBox txtMobilurisNomeri;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox txtPiradiNomeri;
    }
}