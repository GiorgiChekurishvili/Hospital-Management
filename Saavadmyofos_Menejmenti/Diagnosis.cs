using System;
using Saavadmyofos_Menejmenti.DTOs;
using Saavadmyofos_Menejmenti.DbModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Saavadmyofos_Menejmenti
{
    public partial class Diagnosis : Form
    {
        private Menu _menu;
        private HospitalContext _db;
        private Wvdoma user;
        private List<WamlebiDTO> _wamlebidto;


        public Diagnosis(Menu menu, Wvdoma currentuser)
        {
            InitializeComponent();
            _menu = menu;
            user = currentuser;
            _db = new HospitalContext();
            _wamlebidto = new List<WamlebiDTO>();

            LoadPacients();
            this.user = user;
            Medicinedatagridview();


        }
        private void LoadPacients()
        {


            var _docs = _db.Eqimebis.FirstOrDefault(x => x.WvdomisId == user.WvdomisId);
            var _pacients = _db.Pacientebis.Select(d => new { d.PacientisId, saxeli = d.Saxeli + " " + d.Gvari + "-" + d.PiradiNomeri, d.EqimisId }).Where(x => x.EqimisId == _docs.EqimisId).ToList();

            comboBoxPacientisfullname.ValueMember = "PacientisId";
            comboBoxPacientisfullname.DisplayMember = "saxeli";
            comboBoxPacientisfullname.DataSource = _pacients;



        }
        private void Fill()
        {

            var _pac = _db.Pacientebis.FirstOrDefault(x => x.PacientisId == int.Parse(comboBoxPacientisfullname.SelectedValue.ToString()));
            if (_pac != null)
            {
                txtAsaki.Text = _pac.Asaki.ToString();
                txtEmail.Text = _pac.Email.ToString();
                txtMobilurisNomeri.Text = _pac.MobilurisNomeri.ToString();
                txtSisxli.Text = _pac.SisxlisJgufi.ToString();
                txtSqesi.Text = _pac.Sqesi.ToString();
            }

        }
        private void Symptomsdatagridview()
        {
            var _sim = _db.Simptomebis.Where(x => x.PacientisId == int.Parse(comboBoxPacientisfullname.SelectedValue.ToString())).Select(x => new { Simptomi = x.Simptomi }).ToList();

            dataviewSimptomebi.DataSource = _sim;
            dataviewSimptomebi.Columns["Simptomi"].HeaderText = "სიმპტომები";
            dataviewSimptomebi.Columns["Simptomi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Medicinedatagridview()
        {
            dataviewWamlebi.DataSource = null;
            dataviewWamlebi.DataSource = _wamlebidto;
            dataviewWamlebi.Columns["ID"].HeaderText = "წამლის ნომერი";
            dataviewWamlebi.Columns["WamlisSaxeli"].HeaderText = "წამალი";
            dataviewWamlebi.Columns["WamlisSaxeli"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Hide();
            _menu.FormClosed += (s, args) => this.Close();

        }

        private void BtnShenaxva_Click(object sender, EventArgs e)
        {
            try
            {
                var pacientisid = _db.Pacientebis.FirstOrDefault(x => x.PacientisId == int.Parse(comboBoxPacientisfullname.SelectedValue.ToString()));
                var eqimisid = _db.Eqimebis.FirstOrDefault(x => x.WvdomisId == user.WvdomisId);
                foreach (var wamlebisdto in _wamlebidto)
                {
                    Wamlebi wamlebi = new Wamlebi();
                    wamlebi.PacientisId = pacientisid.PacientisId;
                    wamlebi.WamlisSaxeli = wamlebisdto.WamlisSaxeli;
                    wamlebi.EqimisId = eqimisid.EqimisId;


                    _db.Add(wamlebi);
                    _db.SaveChanges();
                }
                MessageBox.Show("მონაცემები წარმატებით დაემატა");
            }
            catch
            {
                MessageBox.Show("მონაცემები ვერ დაემატა");
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPacientisfullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
            Symptomsdatagridview();
        }

        private void btnDamateba_Click(object sender, EventArgs e)
        {





            foreach (WamlebiDTO wamlebi in _wamlebidto)
            {

                string wamlissaxeli = txtWamlisSaxeli.Text;



                if (wamlebi.WamlisSaxeli.Equals(wamlissaxeli, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("წამალი უკვე დამატებულია");
                    return;
                }
            }
            WamlebiDTO wamlebiDTO = new WamlebiDTO();

            wamlebiDTO.WamlisSaxeli = txtWamlisSaxeli.Text;
            wamlebiDTO.ID = _wamlebidto.Count + 1;
            _wamlebidto.Add(wamlebiDTO);


            Medicinedatagridview();
            txtWamlisSaxeli.Clear();

        }

        private void btnWashla_Click(object sender, EventArgs e)
        {
            if (_wamlebidto.Count > 0)
            {

                _wamlebidto.RemoveAt(_wamlebidto.Count - 1);



                Medicinedatagridview();
                txtWamlisSaxeli.Clear();


            }
            else
            {
                MessageBox.Show("არაფერია წასაშლელი");
                Medicinedatagridview();
                txtWamlisSaxeli.Clear();
            }
        }

        private void dataviewSimptomebi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnamobechdva_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintResult printResult = new PrintResult(user);
            printResult.Show();
        }
    }

}
