namespace hasła
{
    partial class dodajmaila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajmaila));
            this.dodajbutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.haslo = new MetroFramework.Controls.MetroTextBox();
            this.dodatkoweinfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dodajbutton
            // 
            this.dodajbutton.Location = new System.Drawing.Point(3, 177);
            this.dodajbutton.Name = "dodajbutton";
            this.dodajbutton.Size = new System.Drawing.Size(377, 23);
            this.dodajbutton.TabIndex = 19;
            this.dodajbutton.Text = "Dodaj nowe konto email";
            this.dodajbutton.UseSelectable = true;
            this.dodajbutton.Click += new System.EventHandler(this.dodajbutton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(141, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Dodatkowe informacje";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Hasło";
            // 
            // mail
            // 
            // 
            // 
            // 
            this.mail.CustomButton.Image = null;
            this.mail.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.mail.CustomButton.Name = "";
            this.mail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mail.CustomButton.TabIndex = 1;
            this.mail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mail.CustomButton.UseSelectable = true;
            this.mail.CustomButton.Visible = false;
            this.mail.Lines = new string[0];
            this.mail.Location = new System.Drawing.Point(88, 6);
            this.mail.MaxLength = 32767;
            this.mail.Name = "mail";
            this.mail.PasswordChar = '\0';
            this.mail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mail.SelectedText = "";
            this.mail.SelectionLength = 0;
            this.mail.SelectionStart = 0;
            this.mail.ShortcutsEnabled = true;
            this.mail.Size = new System.Drawing.Size(283, 23);
            this.mail.TabIndex = 12;
            this.mail.UseSelectable = true;
            this.mail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Adres email";
            // 
            // haslo
            // 
            // 
            // 
            // 
            this.haslo.CustomButton.Image = null;
            this.haslo.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.haslo.CustomButton.Name = "";
            this.haslo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.haslo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.haslo.CustomButton.TabIndex = 1;
            this.haslo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.haslo.CustomButton.UseSelectable = true;
            this.haslo.CustomButton.Visible = false;
            this.haslo.Lines = new string[0];
            this.haslo.Location = new System.Drawing.Point(50, 35);
            this.haslo.MaxLength = 32767;
            this.haslo.Name = "haslo";
            this.haslo.PasswordChar = '\0';
            this.haslo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.haslo.SelectedText = "";
            this.haslo.SelectionLength = 0;
            this.haslo.SelectionStart = 0;
            this.haslo.ShortcutsEnabled = true;
            this.haslo.Size = new System.Drawing.Size(321, 23);
            this.haslo.TabIndex = 20;
            this.haslo.UseSelectable = true;
            this.haslo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.haslo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dodatkoweinfo
            // 
            this.dodatkoweinfo.Location = new System.Drawing.Point(3, 83);
            this.dodatkoweinfo.Name = "dodatkoweinfo";
            this.dodatkoweinfo.Size = new System.Drawing.Size(377, 88);
            this.dodatkoweinfo.TabIndex = 21;
            this.dodatkoweinfo.Text = "";
            // 
            // dodajmaila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(383, 205);
            this.Controls.Add(this.dodatkoweinfo);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.dodajbutton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dodajmaila";
            this.Text = "Dodaj maila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton dodajbutton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox haslo;
        private System.Windows.Forms.RichTextBox dodatkoweinfo;
    }
}