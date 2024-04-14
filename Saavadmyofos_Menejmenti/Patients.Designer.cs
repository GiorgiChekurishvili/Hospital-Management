namespace Saavadmyofos_Menejmenti
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            txtSaxeli = new TextBox();
            txtGvari = new TextBox();
            txtPiradiNomeri = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(965, 332);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 78);
            panel1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 117, 224);
            label5.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(304, 0);
            label5.Name = "label5";
            label5.Size = new Size(348, 68);
            label5.TabIndex = 15;
            label5.Text = "პაციენტები";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(431, 480);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // txtSaxeli
            // 
            txtSaxeli.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSaxeli.Location = new Point(28, 95);
            txtSaxeli.Multiline = true;
            txtSaxeli.Name = "txtSaxeli";
            txtSaxeli.PlaceholderText = "სახელი";
            txtSaxeli.Size = new Size(147, 34);
            txtSaxeli.TabIndex = 20;
            // 
            // txtGvari
            // 
            txtGvari.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGvari.ForeColor = SystemColors.WindowFrame;
            txtGvari.Location = new Point(181, 95);
            txtGvari.Multiline = true;
            txtGvari.Name = "txtGvari";
            txtGvari.PlaceholderText = "გვარი";
            txtGvari.Size = new Size(236, 34);
            txtGvari.TabIndex = 21;
            // 
            // txtPiradiNomeri
            // 
            txtPiradiNomeri.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPiradiNomeri.ForeColor = SystemColors.WindowFrame;
            txtPiradiNomeri.Location = new Point(447, 95);
            txtPiradiNomeri.Multiline = true;
            txtPiradiNomeri.Name = "txtPiradiNomeri";
            txtPiradiNomeri.PlaceholderText = "პირადი ნომერი";
            txtPiradiNomeri.Size = new Size(236, 34);
            txtPiradiNomeri.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(713, 94);
            button1.Name = "button1";
            button1.Size = new Size(197, 40);
            button1.TabIndex = 24;
            button1.Text = "ძებნა/გაფილტვრა";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 554);
            Controls.Add(button1);
            Controls.Add(txtPiradiNomeri);
            Controls.Add(txtGvari);
            Controls.Add(txtSaxeli);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patients";
            Text = "AddPatients";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox4;
        private TextBox txtSaxeli;
        private TextBox txtGvari;
        private TextBox txtPiradiNomeri;
        private Button button1;
    }
}