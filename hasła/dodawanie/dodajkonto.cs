using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hasła
{
    public partial class dodajkonto : Form
    {
        private readonly main _mejn;
        public dodajkonto(main mejn)
        {
            InitializeComponent();
            this._mejn = mejn;
        }

        public string key = Properties.Resources.key;
        public void zapisdanychdopliku(string login, string haslo, string mail, string dodatkoweinfo, string typ)
        {
            using (FileStream fs = File.Create(Environment.ExpandEnvironmentVariables($"%appdata%\\Passdata\\konta\\[{typ}] {login}.password")))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(AesOperation.EncryptString(key, login) + "\n" + AesOperation.EncryptString(key, haslo) + "\n" + AesOperation.EncryptString(key, mail) + "\n" + AesOperation.EncryptString(key, dodatkoweinfo));
                fs.Write(title, 0, title.Length);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            zapisdanychdopliku(login.Text, haslo.Text, mail.Text, dodatkoweinfo.Text, typkonta.Text);
            this._mejn.zaladujkonta();
            MessageBox.Show("Pomyślnie dodano nowe konto!");
            this.Close();
        }
    }
}
