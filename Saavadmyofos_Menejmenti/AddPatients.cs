using System;
using Saavadmyofos_Menejmenti.DbModels;
using Saavadmyofos_Menejmenti.DTOs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Saavadmyofos_Menejmenti
{
    public partial class AddPatients : Form
    {
        private Menu menu;
        private HospitalContext _db;
        private List<SimptomebiDTO> _simptomebiDTO;
        private int _symptomID;
        public AddPatients(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            _db = new HospitalContext();
            _simptomebiDTO = new List<SimptomebiDTO>();
            SimptomebiList();
            LoadDoctors();
        }
        private void LoadDoctors()
        {


            var doctors = _db.Eqimebis.Select(d => new { d.EqimisId, saxeli = d.Saxeli + " " + d.Gvari + "-" + d.Profesia }).ToList();


            comboBoxEqimi.ValueMember = "EqimisId";
            comboBoxEqimi.DisplayMember = "saxeli";
            comboBoxEqimi.DataSource = doctors;


        }
        private void SimptomebiList()
        {

            dataGridView1.DataSource = _simptomebiDTO;
            dataGridView1.Columns["ID"].HeaderText = "სიმპტომის ნომერი";
            dataGridView1.Columns["Simptomi"].HeaderText = "სიმპტომები";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSxvaSimptomebi.Text = "";
            txtSxvaSimptomebi.ReadOnly = true;

            if (comboBoxSimptomebi.Text == "სხვა")
            {
                txtSxvaSimptomebi.ReadOnly = false;

            }
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
            menu.FormClosed += (s, args) => this.Close();
        }

        private void BtnShenaxva_Click(object sender, EventArgs e)
        {
            try
            {


                var piradi = _db.Pacientebis.FirstOrDefault(x => x.PiradiNomeri == Convert.ToInt64(txtpiradinomeri.Text));
                if (piradi != null)
                {
                    MessageBox.Show("სხვა პაციენტი ამ პირადი ნომრით უკვე დამატებულია");
                    return;
                }
                var email = _db.Pacientebis.FirstOrDefault(x => x.Email == txtEmail.Text);
                if (email != null)
                {
                    MessageBox.Show("სხვა პაციენტი ამ ელ-ფოსტით უკვე დამატებულია");
                    return;
                }

                var phone = _db.Pacientebis.FirstOrDefault(x => x.MobilurisNomeri == int.Parse(txtMobilurisNomeri.Text));
                if (phone != null)
                {
                    MessageBox.Show("სხვა პაციენტი ამ ნომრით უკვე დამატებულია");
                    return;
                }
                if (_simptomebiDTO.Count == 0 || _simptomebiDTO == null)
                {
                    MessageBox.Show("პაციენტს სიმპტომები არ აქვს გაწერილი");
                    return;

                }

                Pacientebi pacientebi = new Pacientebi
                {
                    Saxeli = txtSaxeli.Text,
                    Gvari = txtGvari.Text,
                    PiradiNomeri = Convert.ToInt64(txtpiradinomeri.Text),
                    Asaki = int.Parse(txtAsaki.Text),
                    Sqesi = ComboboxSqesi.SelectedItem.ToString(),
                    MobilurisNomeri = int.Parse(txtMobilurisNomeri.Text),
                    Email = txtEmail.Text,
                    SisxlisJgufi = combosisxli.SelectedItem.ToString(),
                    EqimisId = int.Parse(comboBoxEqimi.SelectedValue.ToString()),
                    Dazghveva = int.Parse(txtDazghveva.Text),
                    GadasakhdeliTankha = int.Parse(txtGadasakhdeliTanxa.Text)
                };
                _db.Add(pacientebi);
                _db.SaveChanges();
                MessageBox.Show("პაციენტი წარმატებით დაემატა");


                var pacientid = _db.Pacientebis.FirstOrDefault(x => x.PiradiNomeri == Convert.ToInt64(txtpiradinomeri.Text));

                foreach (var simptomebiDTO in _simptomebiDTO)
                {
                    Simptomebi simptomebi = new Simptomebi();
                    simptomebi.PacientisId = pacientid.PacientisId;
                    simptomebi.Simptomi = simptomebiDTO.Simptomi;

                    _db.Add(simptomebi);
                    _db.SaveChanges();
                }

                txtSaxeli.Clear();
                txtGvari.Clear();
                txtAsaki.Clear();
                txtEmail.Clear();
                txtDazghveva.Clear();
                txtMobilurisNomeri.Clear();
                txtGadasakhdeliTanxa.Clear();
                txtpiradinomeri.Clear();
                txtSxvaSimptomebi.Clear();
                _simptomebiDTO.Clear();


            }
            catch
            {
                MessageBox.Show("პაციენტი ვერ დაემატა");
                return;
            }

        }


        private void btnPacientebi_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
        }





        private void comboBoxEqimi_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void AddPatients_Load(object sender, EventArgs e)
        {

        }

        private void dataviewSimptomebi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simptomebi;


            ;
            if (txtSxvaSimptomebi.ReadOnly == false)
            {
                simptomebi = txtSxvaSimptomebi.Text;
            }
            else
            {
                simptomebi = comboBoxSimptomebi.Text;
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


            foreach (SimptomebiDTO simptomebidto in _simptomebiDTO)
            {
                string selectedItem = comboBoxSimptomebi.SelectedItem.ToString();
                string enteredText = txtSxvaSimptomebi.Text;

                if (simptomebidto.Simptomi.Equals(selectedItem, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("სიმპტომი უკვე დამატებულია");
                    return;
                }

                if (simptomebidto.Simptomi.Equals(enteredText, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("სიმპტომი უკვე დამატებულია");
                    return;
                }
            }
            SimptomebiDTO simptomebiDTO = new SimptomebiDTO();

            simptomebiDTO.Simptomi = simptomebi.Trim();
            simptomebiDTO.ID = _simptomebiDTO.Count + 1;
            _simptomebiDTO.Add(simptomebiDTO);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _simptomebiDTO;
            dataGridView1.Columns["ID"].HeaderText = "სიმპტომის ნომერი";
            dataGridView1.Columns["Simptomi"].HeaderText = "სიმპტომები";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_simptomebiDTO.Count > 0)
            {
                
                _simptomebiDTO.RemoveAt(_simptomebiDTO.Count - 1);

                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _simptomebiDTO;
                dataGridView1.Columns["ID"].HeaderText = "სიმპტომის ნომერი";
                dataGridView1.Columns["Simptomi"].HeaderText = "სიმპტომები";


            }
            else
            {
                MessageBox.Show("არაფერია წასაშლელი");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _simptomebiDTO;
                dataGridView1.Columns["ID"].HeaderText = "სიმპტომის ნომერი";
                dataGridView1.Columns["Simptomi"].HeaderText = "სიმპტომები";
            }
        }
    }
    
}
