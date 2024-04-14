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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Saavadmyofos_Menejmenti
{
    public partial class Doctors : Form
    {
        private Menu menu;
        private HospitalContext db;
        private List<DocLoginDTO> DocDTO;
        private int docID;
        private Eqimebi _doc;
        public Wvdoma login;
        public Doctors(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            DocDTO = new List<DocLoginDTO>();
            db = new HospitalContext();
            DoctorsDataview();
        }

        private void DoctorsDataview()
        {
            var _doc = db.Eqimebis.Include(x => x.wvdoma).ToList();
            DocDTO = new List<DocLoginDTO>();


            foreach (var docs in _doc)
            {
                DocLoginDTO dto = new DocLoginDTO();
                dto.EqimisId = docs.EqimisId;
                dto.Saxeli = docs.Saxeli;
                dto.Gvari = docs.Gvari;
                dto.PiradiNomeri = docs.PiradiNomeri;
                dto.Asaki = docs.Asaki;
                dto.Profesia = docs.Profesia;
                dto.GamocdilebaWeli = docs.GamocdilebaWeli;
                dto.Email = docs.Email;
                dto.MobilurisNomeri = docs.MobilurisNomeri;
                if (docs.wvdoma != null)
                {
                    dto.MomkhmareblisSaxeli = docs.wvdoma.MomkhmareblisSaxeli;
                    dto.Paroli = docs.wvdoma.Paroli;
                }
                else
                {

                    dto.MomkhmareblisSaxeli = null;
                    dto.Paroli = null;
                }
                dto.Daemata = docs.Daemata;

                DocDTO.Add(dto);
            }
            dataGridView1.DataSource = DocDTO;
            dataGridView1.Columns["EqimisId"].HeaderText = "Id";
            dataGridView1.Columns["Saxeli"].HeaderText = "სახელი";
            dataGridView1.Columns["Gvari"].HeaderText = "გვარი";
            dataGridView1.Columns["PiradiNomeri"].HeaderText = "პირადი ნომერი";
            dataGridView1.Columns["Asaki"].HeaderText = "ასაკი";
            dataGridView1.Columns["GamocdilebaWeli"].HeaderText = "გამოცდილება წლებში";
            dataGridView1.Columns["Email"].HeaderText = "მეილი";
            dataGridView1.Columns["MobilurisNomeri"].HeaderText = "მობილურის ნომერი";
            dataGridView1.Columns["MomkhmareblisSaxeli"].HeaderText = "მომხმარებლის სახელი";
            dataGridView1.Columns["Paroli"].HeaderText = "პაროლი";
            dataGridView1.Columns["Daemata"].HeaderText = "მონაცემები დაემატა";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
            menu.FormClosed += (s, args) => this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txtUsername.Visible = checkBox1.Checked;
            txtPassword.Visible = checkBox1.Checked;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var doc = DocDTO[row];
            docID = doc.EqimisId;
            Fill();
        }

        private void Fill()
        {
            _doc = db.Eqimebis.Include(x => x.wvdoma).Where(x => x.EqimisId == docID).FirstOrDefault();
            if (_doc != null)
            {

                txtSaxeli.Text = _doc.Saxeli;
                txtGvari.Text = _doc.Gvari;
                txtPiradiNomeri.Text = _doc.PiradiNomeri.ToString();
                txtAsaki.Text = _doc.Asaki.ToString();
                txtProfesia.Text = _doc.Profesia;
                txtGamocdileba.Text = _doc.GamocdilebaWeli.ToString();
                if (_doc.Email != null)
                {
                    txtEmail.Text = _doc.Email;
                }
                else
                {
                    txtEmail.Clear();
                }


                txtMobilurisNomeri.Text = _doc.MobilurisNomeri.ToString();

                if (_doc.wvdoma != null && _doc.wvdoma.MomkhmareblisSaxeli != null && _doc.wvdoma.Paroli != null)
                {
                    txtUsername.Text = _doc.wvdoma.MomkhmareblisSaxeli;
                    txtPassword.Text = _doc.wvdoma.Paroli;
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var piradi = db.Eqimebis.FirstOrDefault(x => x.PiradiNomeri == Convert.ToInt64(txtPiradiNomeri.Text));
                if (piradi != null)
                {
                    MessageBox.Show("სხვა ექიმი ამ პირადი ნომრით უკვე დამატებულია");
                    return;
                }

                if (int.Parse(txtAsaki.Text) < 18)
                {
                    MessageBox.Show("არასრულწლოვანი ექიმი ვერ დაემატება");
                    return;
                }
                var email = db.Eqimebis.FirstOrDefault(x => x.Email == txtEmail.Text);
                if (email != null)
                {
                    MessageBox.Show("სხვა პაციენტი ამ ელ-ფოსტით უკვე დამატებულია");
                    return;
                }

                var phone = db.Eqimebis.FirstOrDefault(x => x.MobilurisNomeri == int.Parse(txtMobilurisNomeri.Text));
                if (phone != null)
                {
                    MessageBox.Show("სხვა პაციენტი ამ ნომრით უკვე დამატებულია");
                    return;
                }

                if (int.Parse(txtAsaki.Text) > 90)
                {
                    MessageBox.Show("90 წელს გადაცილებული ექიმი ვერ დაემატება ");
                    return;
                }
                if (int.Parse(txtAsaki.Text) - int.Parse(txtGamocdileba.Text) < 18)
                {
                    MessageBox.Show("გამოცდილება არ შეესაბამება ასაკს");
                    return;
                }




                if (txtPassword.Text != "" && txtUsername.Text != "")
                {
                    string password = txtPassword.Text;


                    string hashpassword;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                        byte[] hashBytes = sha256.ComputeHash(inputBytes);

                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < hashBytes.Length; i++)
                        {
                            builder.Append(hashBytes[i].ToString("x2"));
                        }
                        hashpassword = builder.ToString();
                    }

                    Wvdoma wvdoma = new Wvdoma
                    {
                        MomkhmareblisSaxeli = txtUsername.Text,
                        Paroli = hashpassword,
                        TipisId = 3
                    };
                    db.Add(wvdoma);
                    db.SaveChanges();
                }

                var login = db.Wvdomas.FirstOrDefault(x => x.MomkhmareblisSaxeli == txtUsername.Text);

                Eqimebi eqimebi = new Eqimebi
                {
                    Saxeli = txtSaxeli.Text,
                    Gvari = txtGvari.Text,
                    PiradiNomeri = Convert.ToInt64(txtPiradiNomeri.Text),
                    Asaki = int.Parse(txtAsaki.Text),
                    Profesia = txtProfesia.Text,
                    GamocdilebaWeli = int.Parse(txtGamocdileba.Text),
                    Email = txtEmail.Text,
                    MobilurisNomeri = int.Parse(txtMobilurisNomeri.Text)

                };



                if (login != null)
                {
                    eqimebi.WvdomisId = login.WvdomisId;
                }
                db.Add(eqimebi);
                db.SaveChanges();

                MessageBox.Show("ექიმი წარმატებით დაემატა");
                dataGridView1.DataSource = null;
                DoctorsDataview();

                txtSaxeli.Clear();
                txtGvari.Clear();
                txtAsaki.Clear();
                txtEmail.Clear();
                txtGamocdileba.Clear();
                txtMobilurisNomeri.Clear();
                txtPassword.Clear();
                txtPiradiNomeri.Clear();
                txtProfesia.Clear();
                txtUsername.Clear();
               
            }
            catch
            {
                MessageBox.Show("ექიმი ვერ დაემატა");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

                if (int.Parse(txtAsaki.Text) < 18)
                {
                    MessageBox.Show("ექიმი არასრულწლოვანი ვერ იქნება");
                    return;
                }
                if (int.Parse(txtAsaki.Text) > 90)
                {
                    MessageBox.Show("90 წელს გადაცილებული ექიმით ვერ განახლდება");
                    return;
                }
                if (int.Parse(txtAsaki.Text) - int.Parse(txtGamocdileba.Text) < 18)
                {
                    MessageBox.Show("გამოცდილება არ შეესაბამება ასაკს");
                    return;
                }


                _doc.Saxeli = txtSaxeli.Text;
                _doc.Gvari = txtGvari.Text;
                _doc.PiradiNomeri = Convert.ToInt64(txtPiradiNomeri.Text);
                _doc.Profesia = txtProfesia.Text;
                _doc.Asaki = int.Parse(txtAsaki.Text);
                _doc.GamocdilebaWeli = int.Parse(txtGamocdileba.Text);

                if (txtEmail.Text != "")
                {
                    _doc.Email = txtEmail.Text;
                }
                else if (txtEmail.Text == "")
                {
                    _doc.Email = null;
                }
                _doc.MobilurisNomeri = int.Parse(txtMobilurisNomeri.Text);

                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    if (_doc.wvdoma == null)
                    {

                        string pass = txtPassword.Text.Trim();
                        string hashpass;
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] inputBytes = Encoding.UTF8.GetBytes(pass);
                            byte[] hashBytes = sha256.ComputeHash(inputBytes);

                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < hashBytes.Length; i++)
                            {
                                builder.Append(hashBytes[i].ToString("x2"));
                            }
                            hashpass = builder.ToString();
                        }

                        Wvdoma wvdoma = new Wvdoma
                        {
                            MomkhmareblisSaxeli = txtUsername.Text,

                            Paroli = hashpass,
                            TipisId = 3
                        };
                        db.Add(wvdoma);
                        db.SaveChanges();
                        var login = db.Wvdomas.FirstOrDefault(x => x.MomkhmareblisSaxeli == txtUsername.Text);

                        _doc.WvdomisId = login.WvdomisId;
                        db.SaveChanges();
                        MessageBox.Show("მონაცემები შეიცვალა");
                        dataGridView1.DataSource = null;
                        DoctorsDataview();

                        txtSaxeli.Clear();
                        txtGvari.Clear();
                        txtAsaki.Clear();
                        txtEmail.Clear();
                        txtGamocdileba.Clear();
                        txtMobilurisNomeri.Clear();
                        txtPassword.Clear();
                        txtPiradiNomeri.Clear();
                        txtProfesia.Clear();
                        txtUsername.Clear();
                    }
                    else
                    {
                        _doc.wvdoma.MomkhmareblisSaxeli = txtUsername.Text;

                        string password = txtPassword.Text.Trim();
                        string hashpassword;
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                            byte[] hashBytes = sha256.ComputeHash(inputBytes);

                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < hashBytes.Length; i++)
                            {
                                builder.Append(hashBytes[i].ToString("x2"));
                            }
                            hashpassword = builder.ToString();
                        }
                        Wvdoma confirmpassword = db.Wvdomas.FirstOrDefault(x => x.Paroli == txtPassword.Text);
                        if (confirmpassword == null)
                        {
                            _doc.wvdoma.Paroli = hashpassword;
                        }
                        else
                        {
                            MessageBox.Show("ვერ მოხერხდა პაროლის შეცვლა, ეს პაროლი უკვე მინიჭებული აქვს ამ ექიმს");
                        }
                        db.SaveChanges();
                        MessageBox.Show("მონაცემები შეიცვალა");
                        dataGridView1.DataSource = null;
                        DoctorsDataview();

                        txtSaxeli.Clear();
                        txtGvari.Clear();
                        txtAsaki.Clear();
                        txtEmail.Clear();
                        txtGamocdileba.Clear();
                        txtMobilurisNomeri.Clear();
                        txtPassword.Clear();
                        txtPiradiNomeri.Clear();
                        txtProfesia.Clear();
                        txtUsername.Clear();
                    }
                }
                else if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    if (_doc.wvdoma != null)
                    {
                        int? userid = _doc.WvdomisId;
                        Wvdoma user = new Wvdoma();
                        user = db.Wvdomas.Find(userid);
                        if (user != null)
                        {
                            db.Wvdomas.Remove(user);
                            db.SaveChanges();
                            MessageBox.Show("მონაცემები შეიცვალა");
                            dataGridView1.DataSource = null;
                            DoctorsDataview();

                            txtSaxeli.Clear();
                            txtGvari.Clear();
                            txtAsaki.Clear();
                            txtEmail.Clear();
                            txtGamocdileba.Clear();
                            txtMobilurisNomeri.Clear();
                            txtPassword.Clear();
                            txtPiradiNomeri.Clear();
                            txtProfesia.Clear();
                            txtUsername.Clear();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("ვერ დაამატებთ ან წაშლით მხოლოდ პაროლს ან მომხმარებლის სახელს");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"ვერ მოხერხდა მონაცემების რედაქტირება:");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int? userid = _doc.WvdomisId;
                Wvdoma user = new Wvdoma();
                user = db.Wvdomas.Find(userid);

                db.Eqimebis.Remove(_doc);
                db.SaveChanges();
                if (user != null)
                {
                    db.Wvdomas.Remove(user);
                    db.SaveChanges();
                }
                var eqimisid = db.Pacientebis.FirstOrDefault(x => x.EqimisId == _doc.EqimisId);
                if (eqimisid != null)
                {
                    eqimisid.EqimisId = 0;
                    db.SaveChanges();
                }
                MessageBox.Show("მონაცემები წაიშალა");

                dataGridView1.DataSource = null;
                DoctorsDataview();
            }
            catch
            {
                MessageBox.Show("მონაცემები ვერ წაიშალა");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
