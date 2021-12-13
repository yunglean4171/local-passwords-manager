using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hasła
{
    public partial class dodajmaila : Form
    {
        private readonly main _mejn;
        public dodajmaila(main mejn)
        {
            InitializeComponent();
            this._mejn = mejn;
        }
        public string key = Properties.Resources.key;
        public void zapisdanychdopliku(string mail, string haslo, string dodatkoweinfo)
        {
            using (FileStream fs = File.Create(Environment.ExpandEnvironmentVariables($"%appdata%\\Passdata\\maile\\{mail}.password")))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(AesOperation.EncryptString(key, mail) + "\n" + AesOperation.EncryptString(key, haslo) + "\n" + AesOperation.EncryptString(key, dodatkoweinfo));
                fs.Write(title, 0, title.Length);
            }
        }
        private void dodajbutton_Click(object sender, EventArgs e)
        {
            zapisdanychdopliku(mail.Text, haslo.Text, dodatkoweinfo.Text);
            this._mejn.zaladujmaile();
            MessageBox.Show("Pomyślnie dodano nowego maila!");
            this.Close();
        }
    }
}
