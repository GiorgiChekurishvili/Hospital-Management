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
using System.Drawing.Printing;

namespace Saavadmyofos_Menejmenti
{
    public partial class PrintResult : Form
    {
        private int _pacientid;
        private Wvdoma _user;
        private HospitalContext _db;
        private Eqimebi _docs;
        public PrintResult(Wvdoma user)
        {
            InitializeComponent();
            _user = user;
            _db = new HospitalContext();
            LoadPatients();
           
        }

        private void LoadPatients()
        {
            _docs = _db.Eqimebis.FirstOrDefault(x => x.WvdomisId == _user.WvdomisId);
            var _pacients = _db.Pacientebis.Select(d => new { d.PacientisId, saxeli = d.Saxeli + " " + d.Gvari + "-" + d.PiradiNomeri, d.EqimisId }).Where(x => x.EqimisId == _docs.EqimisId).ToList();

            comboBoxPacientisfullname.ValueMember = "PacientisId";
            comboBoxPacientisfullname.DisplayMember = "saxeli";
            comboBoxPacientisfullname.DataSource = _pacients;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            _pacientid = int.Parse(comboBoxPacientisfullname.SelectedValue.ToString());
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK && _pacientid > 0)
            {
                printDocument1.Print();
                
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int patientId = Convert.ToInt32(comboBoxPacientisfullname.SelectedValue);


            var patient = _db.Pacientebis.FirstOrDefault(p => p.PacientisId == patientId);


            if (patient != null)
            {
                var medicines = _db.Wamlebis.Where(m => m.PacientisId == patientId).ToList();
                var simptomebi = _db.Simptomebis.Where(s => s.PacientisId == _pacientid).ToList();



                e.Graphics.DrawString("-რეცეპტი", new Font("Century", 18, FontStyle.Bold), Brushes.Red, new Point(200, 40));
                e.Graphics.DrawString($"პაციენტი: {patient.Saxeli} {patient.Gvari}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 105));
                e.Graphics.DrawString($"სქესი: {patient.Sqesi}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 125));
                e.Graphics.DrawString($"ასაკი: {patient.Asaki}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(128, 145));
                e.Graphics.DrawString($"სისხლის ჯგუფი: {patient.SisxlisJgufi}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 165));
                e.Graphics.DrawString($"პირადი ნომერი: {patient.PiradiNomeri}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 185));
                e.Graphics.DrawString($"მობილურის ნომერი: {patient.MobilurisNomeri}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 205));
                e.Graphics.DrawString($"მისამართი: {patient.Email}", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, 225));
                e.Graphics.DrawString($"ექიმი რომელმაც რეცეპტი გამოწერა: {_docs.Saxeli} {_docs.Gvari}", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(120, 245));

                e.Graphics.DrawString("წამლები", new Font("Century", 18, FontStyle.Bold), Brushes.Red, new Point(1, 265));
                e.Graphics.DrawString("სიმპტომები", new Font("Century", 18, FontStyle.Bold), Brushes.Red, new Point(300, 265));
                int shualedi = 20;
                int saboloo = 265;



                foreach (var medicine in medicines)
                {
                    saboloo += shualedi + 10;
                    e.Graphics.DrawString(medicine.WamlisSaxeli, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(1, saboloo));
                }
                

                foreach (var symptoms in simptomebi)
                {
                    saboloo += shualedi + 10;
                    e.Graphics.DrawString(symptoms.Simptomi, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, saboloo));
                }
            }

        }

        
    }
}
