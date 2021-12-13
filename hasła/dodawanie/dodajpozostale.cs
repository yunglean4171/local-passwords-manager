using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hasła
{
    public partial class dodajpozostale : Form
    {
        private readonly main _mejn;
        public dodajpozostale(main mejn)
        {
            InitializeComponent();
            this._mejn = mejn;
        }
        public string key = Properties.Resources.key;
        public void zapisdanychdopliku(string tytul, string dane)
        {
            using (FileStream fs = File.Create(Environment.ExpandEnvironmentVariables($"%appdata%\\Passdata\\pozostale\\{tytul}.password")))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(AesOperation.EncryptString(key, tytul) + "\n" + AesOperation.EncryptString(key, dane));
                fs.Write(title, 0, title.Length);
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            zapisdanychdopliku(tytul.Text, dane.Text);
            this._mejn.zaladujpozostale();
            MessageBox.Show("Pomyślnie dodano nowe dane!");
            this.Close();
        }
    }
}
