using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Saavadmyofos_Menejmenti.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saavadmyofos_Menejmenti
{
    public partial class Menu : Form
    {
        private Wvdoma currentuser;
        public Menu(Wvdoma user)
        {
            InitializeComponent();
            currentuser = user;

        }


        private void DoctorsPicture_Click(object sender, EventArgs e)
        {
            if (currentuser.TipisId == 1)
            {
                Doctors doctors = new Doctors(this);
                doctors.Show();
                this.Hide();
                doctors.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("თქვენ არ გაქვთ ადმინის უფლებები ამ ფანჯრის გასახსნელად");
            }
        }

        private void PatientsPicture_Click(object sender, EventArgs e)
        {
            if (currentuser.TipisId == 2)
            {
                AddPatients patients = new AddPatients(this);
                patients.Show();
                this.Hide();
                patients.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("თქვენ არ ხართ მიმღები რომ გახსნათ ეს ფანჯარა");
            }

        }

        private void DiagnosisPicture_Click(object sender, EventArgs e)
        {
            if (currentuser.TipisId == 3)
            {
                Diagnosis diagnosis = new Diagnosis(this, currentuser);
                diagnosis.Show();
                this.Hide();
                diagnosis.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("თქვენ არ ხართ ექიმი რომ გახსნათ ეს ფანჯარა");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login loginmenu = new Login();
            loginmenu.Show();
            this.Hide();
            loginmenu.FormClosed += (s, args) => this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
