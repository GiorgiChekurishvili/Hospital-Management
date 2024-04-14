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
    public partial class Patients : Form
    {
        private HospitalContext _db;
        private List<PacientsDTO> pacientsDTO;
        private int pacid;
        public Patients()
        {
            InitializeComponent();
            _db = new HospitalContext();
            PatientsFill();

        }

        public void PatientsFill()
        {
            
            var _patient = _db.Pacientebis.ToList();
            pacientsDTO = new List<PacientsDTO>();

            foreach (var _pacients in _patient)
            {
                PacientsDTO _pacientdto = new PacientsDTO();
                _pacientdto.PacientisId = _pacients.PacientisId;
                _pacientdto.Saxeli = _pacients.Saxeli;
                _pacientdto.Gvari = _pacients.Gvari;
                _pacientdto.PiradiNomeri = _pacients.PiradiNomeri;
                _pacientdto.Sqesi = _pacients.Sqesi;
                _pacientdto.Asaki = _pacients.Asaki;
                _pacientdto.Email = _pacients.Email;
                _pacientdto.MobilurisNomeri = _pacients.MobilurisNomeri;
                _pacientdto.SisxlisJgufi = _pacients.SisxlisJgufi;
                _pacientdto.Dazghveva = _pacients.Dazghveva;
                _pacientdto.GadasakhdeliTankha = _pacients.GadasakhdeliTankha;
                _pacientdto.GadasakhdeliDazghvevit = _pacients.GadasakhdeliDazghvevit;
                _pacientdto.Daemata = _pacients.Daemata;

                pacientsDTO.Add(_pacientdto);
            }
            dataGridView1.DataSource = pacientsDTO;
            dataGridView1.Columns["Pacientisid"].HeaderText = "პაციენტის ID";
            dataGridView1.Columns["Saxeli"].HeaderText = "სახელი";
            dataGridView1.Columns["Gvari"].HeaderText = "გვარი";
            dataGridView1.Columns["PiradiNomeri"].HeaderText = "პირადი ნომერი";
            dataGridView1.Columns["Sqesi"].HeaderText = "სქესი";
            dataGridView1.Columns["Asaki"].HeaderText = "ასაკი";
            dataGridView1.Columns["Email"].HeaderText = "მეილი";
            dataGridView1.Columns["MobilurisNomeri"].HeaderText = "მობილურის ნომერი";
            dataGridView1.Columns["SisxlisJgufi"].HeaderText = "სისხლის ჯგუფი";
            dataGridView1.Columns["Dazghveva"].HeaderText = "დაზღვევა";
            dataGridView1.Columns["GadasakhdeliTankha"].HeaderText = "გადასახდელი თანხა";
            dataGridView1.Columns["GadasakhdeliDazghvevit"].HeaderText = "გადასახდელი დაზღვევის შემდეგ";
            dataGridView1.Columns["Daemata"].HeaderText = "მონაცემები დაემატა";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            PacientsUpdateDelete pacientsUpdateDelete = new PacientsUpdateDelete(pacid);
            pacientsUpdateDelete.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var user = pacientsDTO[index];
            pacid = user.PacientisId;
            PacientsUpdateDelete pacientsUpdateDelete = new PacientsUpdateDelete(pacid);
            pacientsUpdateDelete.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string _name = txtSaxeli.Text.Trim();
            string _surname = txtGvari.Text.Trim();
            long _piradinomeri = 0;

            if (!string.IsNullOrEmpty(_name))
            {
                var filteredPacients = _db.Pacientebis.Where(x => x.Saxeli == _name).ToList();
                dataGridView1.DataSource = filteredPacients;
            }
            else if (!string.IsNullOrEmpty(_surname))
            {
                var filteredPacients = _db.Pacientebis.Where(x => x.Gvari == _surname).ToList();
                dataGridView1.DataSource = filteredPacients;
            }

            else if (!string.IsNullOrEmpty(txtPiradiNomeri.Text))
            {
                _piradinomeri = Convert.ToInt64(txtPiradiNomeri.Text);
                var filteredPacients = _db.Pacientebis.Where(x => x.PiradiNomeri == _piradinomeri);
                dataGridView1.DataSource = filteredPacients.ToList();
            }
            else if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_surname))
            {
                var filteredPacients = _db.Pacientebis.Where(x => x.Saxeli == _name && x.Gvari == _surname).ToList();
                dataGridView1.DataSource = filteredPacients;
            }
            else if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(txtPiradiNomeri.Text))
            {
                _piradinomeri = Convert.ToInt64(txtPiradiNomeri.Text);
                var filteredPacients = _db.Pacientebis.Where(x => x.Saxeli == _name && x.PiradiNomeri == _piradinomeri).ToList();
                dataGridView1.DataSource = filteredPacients;
            }
            else if (!string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(txtPiradiNomeri.Text))
            {
                _piradinomeri = Convert.ToInt64(txtPiradiNomeri.Text);
                var filteredPacients = _db.Pacientebis.Where(x => x.Gvari == _surname && x.PiradiNomeri == _piradinomeri).ToList();
                dataGridView1.DataSource = filteredPacients;
            }
            else if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(txtPiradiNomeri.Text))
            {
                _piradinomeri = Convert.ToInt64(txtPiradiNomeri.Text);
                var filteredPacients = _db.Pacientebis.Where(x => x.Saxeli == _name && x.Gvari == _surname && x.PiradiNomeri == _piradinomeri).ToList();
                dataGridView1.DataSource = filteredPacients;
            }

            else
            {
                
                MessageBox.Show("ინფორმაცია განახლდა");
                dataGridView1.DataSource = null;
                PatientsFill();
            }
        }

        
        
    }
}
