namespace hasła
{
    partial class dodajpozostale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajpozostale));
            this.dane = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tytul = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // dane
            // 
            this.dane.Location = new System.Drawing.Point(12, 63);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(776, 301);
            this.dane.TabIndex = 0;
            this.dane.Text = "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(213, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Wprowadź dane do przechowania:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 370);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(776, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Dodaj dane";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tytul
            // 
            // 
            // 
            // 
            this.tytul.CustomButton.Image = null;
            this.tytul.CustomButton.Location = new System.Drawing.Point(754, 1);
            this.tytul.CustomButton.Name = "";
            this.tytul.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tytul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tytul.CustomButton.TabIndex = 1;
            this.tytul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tytul.CustomButton.UseSelectable = true;
            this.tytul.CustomButton.Visible = false;
            this.tytul.Lines = new string[] {
        "Wprowadź tytuł danych "};
            this.tytul.Location = new System.Drawing.Point(12, 12);
            this.tytul.MaxLength = 32767;
            this.tytul.Name = "tytul";
            this.tytul.PasswordChar = '\0';
            this.tytul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tytul.SelectedText = "";
            this.tytul.SelectionLength = 0;
            this.tytul.SelectionStart = 0;
            this.tytul.ShortcutsEnabled = true;
            this.tytul.Size = new System.Drawing.Size(776, 23);
            this.tytul.TabIndex = 3;
            this.tytul.Text = "Wprowadź tytuł danych ";
            this.tytul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tytul.UseSelectable = true;
            this.tytul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tytul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dodajpozostale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dodajpozostale";
            this.Text = "Przechowaj ważne dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dane;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tytul;
    }
}