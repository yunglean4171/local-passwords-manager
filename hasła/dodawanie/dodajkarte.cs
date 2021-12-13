using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace hasła
{
    public partial class dodajkarte : Form
    {
        public string typ;
        public string key = Properties.Resources.key;
        private readonly main _mejn;
        public dodajkarte(main mejn)
        {
            InitializeComponent();
            this._mejn = mejn;
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(numerkarty.Text) && numerkarty.Text[0] == '4')
            {
                dodajbutton.Text = "Dodaj nową kartę - Visa";
                typ = "[VISA]";
            }
            else if (!string.IsNullOrWhiteSpace(numerkarty.Text) && numerkarty.Text[0] == '5')
            {
                dodajbutton.Text = "Dodaj nową kartę - Mastercard";
                typ = "[MCARD]";
            }
            else
            {
                dodajbutton.Text = "Dodaj nową kartę";
            }
        }

        public void zapisdanychdopliku(string typkarty, string cyfry, string imienazwisko, string data, string kodcvc, string nrkarty)
        {
            using (FileStream fs = File.Create(Environment.ExpandEnvironmentVariables($"%appdata%\\Passdata\\karty\\{tytulkarty.Text} {typkarty} {cyfry}.password")))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(AesOperation.EncryptString(key, imienazwisko) + "\n" + AesOperation.EncryptString(key, nrkarty) + "\n" + AesOperation.EncryptString(key, data) + "\n" + AesOperation.EncryptString(key, Convert.ToString(kodcvc)));
                fs.Write(title, 0, title.Length);
            }
        }

        private void dodajbutton_Click(object sender, EventArgs e)
        {
            string cyferki = numerkarty.Text.Substring(numerkarty.Text.Length - 4);
            zapisdanychdopliku(typ, cyferki, imienazwisko.Text, data.Text, kod.Text, numerkarty.Text);
            this._mejn.zaladujdanekart();
            MessageBox.Show("Pomyślnie dodano nową kartę!");
            this.Close();
        }
    }
}
