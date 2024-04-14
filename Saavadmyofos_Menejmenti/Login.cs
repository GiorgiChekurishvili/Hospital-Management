using System.Text;
using System.Security.Cryptography;
using Saavadmyofos_Menejmenti.DbModels;
using System.Linq.Expressions;

namespace Saavadmyofos_Menejmenti
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string hashpassword;
            username = txtUsername.Text;
            password = txtPassword.Text;
            
            HospitalContext db = new HospitalContext();
            var user = db.Wvdomas.Where(x => x.MomkhmareblisSaxeli == username).FirstOrDefault();
            if (user != null)
            {
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
                if (hashpassword == user.Paroli)
                {
                    Menu menuform = new Menu(user);
                    menuform.Show();
                    this.Hide();
                    menuform.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("შეყვანილია არასწორი პაროლი");
                }
            }
            else
            {
                MessageBox.Show("შეყვანილია არასწორი მომხმარებლის სახელი");
            }

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
