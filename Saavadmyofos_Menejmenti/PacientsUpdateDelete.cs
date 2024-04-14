using Microsoft.EntityFrameworkCore;
using Saavadmyofos_Menejmenti.DbModels;
using Saavadmyofos_Menejmenti.DTOs;
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
    public partial class PacientsUpdateDelete : Form
    {
        private HospitalContext db;

        private int _pacientid;
        private Pacientebi pacient;
        
        public PacientsUpdateDelete(int pacientid)
        {
            InitializeComponent();
            _pacientid = pacientid;
            db = new HospitalContext();
            
            LoadDoctors();
            Fill();
            
        }
        private void LoadDoctors()
        {

            var doctors = db.Eqimebis.Select(d => new { d.EqimisId, saxeli = d.Saxeli + " " + d.Gvari + "-" + d.Profesia }).ToList();


            comboBoxEqimi.ValueMember = "EqimisId";
            comboBoxEqimi.DisplayMember = "saxeli";
            comboBoxEqimi.DataSource = doctors;


        }

        private void Fill()
        {
            pacient = db.Pacientebis.FirstOrDefault(x => x.PacientisId == _pacientid);
            if (pacient != null)
            {
                label1.Text += pacient.PacientisId;
                txtSaxeli.Text = pacient.Saxeli;
                txtGvari.Text = pacient.Gvari;
                txtpiradinomeri.Text = pacient.PiradiNomeri.ToString();
                txtAsaki.Text = pacient.Asaki.ToString();
                txtMobilurisNomeri.Text = pacient.MobilurisNomeri.ToString();
                txtEmail.Text = pacient.Email;
                txtDazghveva.Text = pacient.Dazghveva.ToString();
                txtGadasakhdeliTanxa.Text = pacient.GadasakhdeliTankha.ToString();
                comboboxsisxli.SelectedItem = pacient.SisxlisJgufi;
                ComboboxSqesi.SelectedItem = pacient.Sqesi;
                if (comboBoxEqimi.SelectedValue != "" || comboBoxEqimi.SelectedValue != null)
                {
                    comboBoxEqimi.SelectedValue = pacient.EqimisId;
                }
                
                
            }




        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pacient.Saxeli = txtSaxeli.Text;
                pacient.Gvari = txtGvari.Text;
                pacient.PiradiNomeri = Convert.ToInt64(txtpiradinomeri.Text);
                pacient.Asaki = int.Parse(txtAsaki.Text);
                pacient.MobilurisNomeri = int.Parse(txtMobilurisNomeri.Text);
                if (txtEmail.Text != "")
                {
                    pacient.Email = txtEmail.Text;
                }

                if (txtDazghveva.Text != "")
                {
                    pacient.Dazghveva = int.Parse(txtDazghveva.Text);
                }
                pacient.GadasakhdeliTankha = int.Parse(txtGadasakhdeliTanxa.Text);


                pacient.SisxlisJgufi = comboboxsisxli.SelectedItem.ToString();
                pacient.Sqesi = ComboboxSqesi.SelectedItem.ToString();
                pacient.EqimisId = Convert.ToInt32(comboBoxEqimi.SelectedValue);
                db.SaveChanges();

                string simptomi;
                if (txtSxvaSimptomebi.ReadOnly == false)
                {
                    simptomi = txtSxvaSimptomebi.Text;
                }
                else
                {
                    simptomi = comboBoxSimptomebi.Text;
                }
                if (comboBoxSimptomebi.Text == "სხვა" && txtSxvaSimptomebi.Text == "")
                {
                    MessageBox.Show("სიმპტომი ვერ დაემატა");
                    return;
                }
                if (comboBoxSimptomebi.Text == "სიმპტომები")
                {
                    MessageBox.Show("აირჩიეთ სიმპტომი");
                    return;
                }

                Simptomebi simptomebi = new Simptomebi
                {
                    Simptomi = simptomi,
                    PacientisId = pacient.PacientisId
                };
                db.Add(simptomebi);
                db.SaveChanges();
                MessageBox.Show("პაციენტის მონაცემები წარმატებით შეიცვალა");


            }
            catch
            {
                MessageBox.Show("პაციენტის მონაცემები არ შეიცვალა");
            }
           
        }




        private void comboBoxSimptomebi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSxvaSimptomebi.Text = "";
            txtSxvaSimptomebi.ReadOnly = true;

            if (comboBoxSimptomebi.Text == "სხვა")
            {
                txtSxvaSimptomebi.ReadOnly = false;

            }
        }

        private void comboBoxEqimi_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void PacientsUpdateDelete_Load(object sender, EventArgs e)
        {
            

        }





        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

            var findsymptom = db.Simptomebis.Where(x => x.PacientisId == pacient.PacientisId).ToList();
            if (findsymptom != null)
            {
                    foreach (var find in findsymptom)
                    {
                        db.Simptomebis.Remove(find);
                        db.SaveChanges();
                    }
            }
            db.Remove(pacient);

            
                db.SaveChanges();
                MessageBox.Show("პაციენტი წარმატებით წაიშალა");
            }
            catch
            {
                MessageBox.Show("პაციენტი არ წაიშალა");
            }
        }
    }
}
