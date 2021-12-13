using System;
using System.Windows.Forms;
using System.IO;

namespace hasła
{
    public partial class main : Form
    {
        public string key = Properties.Resources.key;
        public main()
        {
            InitializeComponent();
        }
        void Log(string text)
        {
            wyswietlacz.Invoke(new MethodInvoker(delegate () { wyswietlacz.AppendText(text + "\r\n"); wyswietlacz.ScrollToCaret(); }));
        }
        void checkifdatafolderexists()
        {
            bool folder = Directory.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata"));
            if (!folder)
            {              
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata"));
            }
            else
            {
                Log("Pomyślnie załadowano wszystkie dane!");
            }
        }
        void checkifkartyfolderexists()
        {
            bool folder = Directory.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\karty"));
            if (!folder)
            {
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\karty"));
                zaladujdanekart();
            }
            else
            {
                zaladujdanekart();
            }
        }
        public void zaladujdanekart()
        {
            wyswietlaniekart.Items.Clear();
            string[] files = Directory.GetFiles(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\karty"));
            foreach (string filePath in files)
            {
                wyswietlaniekart.Items.Add(Path.GetFileName(filePath).Replace(".password", ""));
            }
        }
        void checkifmailefolderexists()
        {
            bool folder = Directory.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\maile"));
            if (!folder)
            {
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\maile"));
                zaladujmaile();
            }
            else
            {
                zaladujmaile();
            }
        }
        public void zaladujmaile()
        {
            wyswietlaniemaili.Items.Clear();
            string[] files = Directory.GetFiles(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\maile"));
            foreach (string filePath in files)
            wyswietlaniemaili.Items.Add(Path.GetFileName(filePath).Replace(".password", ""));
        }
        void checkifkontafolderexists()
        {
            bool folder = Directory.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\konta"));
            if (!folder)
            {
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\konta"));
                zaladujkonta();
            }
            else
            {
                zaladujkonta();
            }
        }
        public void zaladujkonta()
        {
            wyswietlaniekont.Items.Clear();
            string[] files = Directory.GetFiles(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\konta"));
            foreach (string filePath in files)
            wyswietlaniekont.Items.Add(Path.GetFileName(filePath).Replace(".password", ""));
        }

        void checkifpozostalefolderexists()
        {
            bool folder = Directory.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\pozostale"));
            if (!folder)
            {
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\pozostale"));
                zaladujpozostale();
            }
            else
            {
                zaladujpozostale();
            }
        }
        public void zaladujpozostale()
        {
            wyswietlaniepozostale.Items.Clear();
            string[] files = Directory.GetFiles(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\pozostale"));
            foreach (string filePath in files)
            wyswietlaniepozostale.Items.Add(Path.GetFileName(filePath).Replace(".password", ""));
        }
        private void main_Load(object sender, EventArgs e)
        {
            checkifdatafolderexists();
            checkifkartyfolderexists();
            checkifmailefolderexists();
            checkifkontafolderexists();
            checkifpozostalefolderexists();
            zaladujdanekart();
            zaladujmaile();
            zaladujkonta();
            zaladujpozostale();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            dodajkarte dk = new dodajkarte(this);
            dk.Show();
        }

        private void usunkarte_Click_1(object sender, EventArgs e)
        {
            Object wybranakarta = wyswietlaniekart.SelectedItem;
            string kartadousuniecia = wybranakarta + ".password";
            if (!File.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\karty\" + kartadousuniecia)))
            {
                Log("Wystapił problem podczas usuwania karty!");
            }
            else
            {
                try
                {
                    File.Delete(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\karty\" + kartadousuniecia));
                    Log("Pomyślnie usunięto dane karty");
                    zaladujdanekart();
                }

                catch (IOException error)
                {
                    Log(error.Message);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Object wybranakarta = wyswietlaniekart.SelectedItem;
            var plik = Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\karty\" + wybranakarta + ".password");
            if(!File.Exists(plik))
            {
                Log("Wystapił problem podczas wyświetlania danych karty!");
            }
            else
            {
                string linia, linia1, linia2, linia3;
                using (var sr = new StreamReader(plik))
                {
                    linia = sr.ReadLine();
                    Log("\n\nImię i nazwisko posiadacza karty: " + AesOperation.DecryptString(key, linia));
                    linia1 = sr.ReadLine();
                    Log("Numer karty: " + AesOperation.DecryptString(key, linia1));                    
                    linia2 = sr.ReadLine();
                    Log("Data ważności karty: " + AesOperation.DecryptString(key, linia2));
                    linia3 = sr.ReadLine();
                    Log("Kod Kod CVC/CVV/CID karty: " + AesOperation.DecryptString(key, linia3));
                }
            }
        }
        private void usunwyswdane_Click(object sender, EventArgs e)
        {
            wyswietlacz.Text = null;
            Log("Pomyślnie usunięto wszystkie dane z wyświetlacza");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            dodajmaila dm = new dodajmaila(this);
            dm.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Object wybranymail = wyswietlaniemaili.SelectedItem;
            string maildousuniecia = wybranymail + ".password";
            if (!File.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\maile\" + maildousuniecia)))
            {
                Log("Wystapił problem podczas usuwania konta mailowego!");
            }
            else
            {
                try
                {
                    File.Delete(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\maile\" + maildousuniecia));
                    Log("Pomyślnie usunięto konto mailowe");
                    zaladujmaile();
                }

                catch (IOException error)
                {
                    Log(error.Message);
                }
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Object wybranymail = wyswietlaniemaili.SelectedItem;
            var plik = Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\maile\" + wybranymail + ".password");
            if (!File.Exists(plik))
            {
                Log("Wystapił problem podczas wyświetlania danych konta mailowego!");
            }
            else
            {
                string linia, linia1, linia2;
                using (var sr = new StreamReader(plik))
                {
                    linia = sr.ReadLine();
                    Log("\n\nAdres email: " + AesOperation.DecryptString(key, linia));
                    linia1 = sr.ReadLine();
                    Log("Hasło: " + AesOperation.DecryptString(key, linia1));
                    linia2 = sr.ReadLine();
                    Log("Dodatkowe informacje:");
                    Log(AesOperation.DecryptString(key, linia2));
                }
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            dodajkonto dkn = new dodajkonto(this);
            dkn.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Object wybranekonto = wyswietlaniekont.SelectedItem;
            string kontodousuniecia = wybranekonto + ".password";
            if (!File.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\konta\" + kontodousuniecia)))
            {
                Log("Wystapił problem podczas usuwania konta do gier!");
            }
            else
            {
                try
                {
                    File.Delete(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\konta\" + kontodousuniecia));
                    Log("Pomyślnie usunięto konto do gier");
                    zaladujkonta();
                }

                catch (IOException error)
                {
                    Log(error.Message);
                }
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Object wybranekonto = wyswietlaniekont.SelectedItem;
            var plik = Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\konta\" + wybranekonto + ".password");
            if (!File.Exists(plik))
            {
                Log("Wystapił problem podczas wyświetlania danych konta do gier!");
            }
            else
            {
                string linia, linia1, linia2, linia3;
                using (var sr = new StreamReader(plik))
                {
                    linia = sr.ReadLine();
                    Log("\n\nLogin: " + AesOperation.DecryptString(key, linia));
                    linia1 = sr.ReadLine();
                    Log("Hasło: " + AesOperation.DecryptString(key, linia1));
                    linia2 = sr.ReadLine();
                    Log("Email: " + AesOperation.DecryptString(key, linia2));
                    linia3 = sr.ReadLine();
                    Log("Dodatkowe informacje:");
                    Log(AesOperation.DecryptString(key, linia3));
                }
            }
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            dodajpozostale dp = new dodajpozostale(this);
            dp.Show();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Object wybranepozostale = wyswietlaniepozostale.SelectedItem;
            string pozostaleodousuniecia = wybranepozostale + ".password";
            if (!File.Exists(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\pozostale\" + pozostaleodousuniecia)))
            {
                Log("Wystapił problem podczas usuwania danych!");
            }
            else
            {
                try
                {
                    File.Delete(Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\pozostale\" + pozostaleodousuniecia));
                    Log("Pomyślnie usunięto dane");
                    zaladujpozostale();
                }

                catch (IOException error)
                {
                    Log(error.Message);
                }
            }
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            Object wybranepozostale = wyswietlaniepozostale.SelectedItem;
            var plik = Environment.ExpandEnvironmentVariables(@"%appdata%\Passdata\pozostale\" + wybranepozostale + ".password");
            if (!File.Exists(plik))
            {
                Log("Wystapił problem podczas wyświetlania danych!");
            }
            else
            {
                string linia, linia1;
                using (var sr = new StreamReader(plik))
                {
                    linia = sr.ReadLine();
                    Log("\n\nTytuł: " + AesOperation.DecryptString(key, linia));
                    linia1 = sr.ReadLine();
                    Log("Dane:");
                    Log(AesOperation.DecryptString(key, linia1));
                }
            }
        }
    }
}
