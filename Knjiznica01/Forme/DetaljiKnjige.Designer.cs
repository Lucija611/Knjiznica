
namespace Knjiznica01
{
    partial class DetaljiKnjige
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
            this.PREZIMEtextbox = new System.Windows.Forms.TextBox();
            this.IMEtextbox = new System.Windows.Forms.TextBox();
            this.Naslov = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.OIBtextbox = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.GodinaIzdanja = new System.Windows.Forms.Label();
            this.brojdanaBR = new System.Windows.Forms.NumericUpDown();
            this.BrojPrimjeraka = new System.Windows.Forms.Label();
            this.RazredComboBox = new System.Windows.Forms.ComboBox();
            this.OKbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brojdanaBR)).BeginInit();
            this.SuspendLayout();
            // 
            // PREZIMEtextbox
            // 
            this.PREZIMEtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PREZIMEtextbox.Location = new System.Drawing.Point(199, 159);
            this.PREZIMEtextbox.Name = "PREZIMEtextbox";
            this.PREZIMEtextbox.Size = new System.Drawing.Size(365, 34);
            this.PREZIMEtextbox.TabIndex = 13;
            this.PREZIMEtextbox.TextChanged += new System.EventHandler(this.PREZIMEtextbox_TextChanged);
            // 
            // IMEtextbox
            // 
            this.IMEtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IMEtextbox.Location = new System.Drawing.Point(199, 98);
            this.IMEtextbox.Name = "IMEtextbox";
            this.IMEtextbox.Size = new System.Drawing.Size(256, 34);
            this.IMEtextbox.TabIndex = 12;
            this.IMEtextbox.TextChanged += new System.EventHandler(this.IMEtextbox_TextChanged);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Naslov.Location = new System.Drawing.Point(37, 159);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(76, 28);
            this.Naslov.TabIndex = 11;
            this.Naslov.Text = "Naslov:";
            this.Naslov.Click += new System.EventHandler(this.Prezime_Click);
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Autor.Location = new System.Drawing.Point(37, 98);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(66, 28);
            this.Autor.TabIndex = 10;
            this.Autor.Text = "Autor:";
            this.Autor.Click += new System.EventHandler(this.Ime_Click);
            // 
            // OIBtextbox
            // 
            this.OIBtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OIBtextbox.Location = new System.Drawing.Point(199, 39);
            this.OIBtextbox.Name = "OIBtextbox";
            this.OIBtextbox.Size = new System.Drawing.Size(256, 34);
            this.OIBtextbox.TabIndex = 9;
            this.OIBtextbox.TextChanged += new System.EventHandler(this.OIBtextbox_TextChanged);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ISBN.Location = new System.Drawing.Point(37, 39);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(58, 28);
            this.ISBN.TabIndex = 8;
            this.ISBN.Text = "ISBN:";
            this.ISBN.Click += new System.EventHandler(this.OIB_Click);
            // 
            // GodinaIzdanja
            // 
            this.GodinaIzdanja.AutoSize = true;
            this.GodinaIzdanja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GodinaIzdanja.Location = new System.Drawing.Point(37, 213);
            this.GodinaIzdanja.Name = "GodinaIzdanja";
            this.GodinaIzdanja.Size = new System.Drawing.Size(152, 28);
            this.GodinaIzdanja.TabIndex = 14;
            this.GodinaIzdanja.Text = "Godinja izdanja:";
            // 
            // brojdanaBR
            // 
            this.brojdanaBR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brojdanaBR.Location = new System.Drawing.Point(199, 214);
            this.brojdanaBR.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.brojdanaBR.Name = "brojdanaBR";
            this.brojdanaBR.Size = new System.Drawing.Size(102, 32);
            this.brojdanaBR.TabIndex = 15;
            this.brojdanaBR.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // BrojPrimjeraka
            // 
            this.BrojPrimjeraka.AutoSize = true;
            this.BrojPrimjeraka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrojPrimjeraka.Location = new System.Drawing.Point(37, 271);
            this.BrojPrimjeraka.Name = "BrojPrimjeraka";
            this.BrojPrimjeraka.Size = new System.Drawing.Size(149, 28);
            this.BrojPrimjeraka.TabIndex = 16;
            this.BrojPrimjeraka.Text = "Broj primjeraka:";
            // 
            // RazredComboBox
            // 
            this.RazredComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RazredComboBox.FormattingEnabled = true;
            this.RazredComboBox.Location = new System.Drawing.Point(199, 271);
            this.RazredComboBox.Name = "RazredComboBox";
            this.RazredComboBox.Size = new System.Drawing.Size(101, 36);
            this.RazredComboBox.TabIndex = 17;
            // 
            // OKbutton2
            // 
            this.OKbutton2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OKbutton2.Location = new System.Drawing.Point(444, 252);
            this.OKbutton2.Name = "OKbutton2";
            this.OKbutton2.Size = new System.Drawing.Size(98, 47);
            this.OKbutton2.TabIndex = 18;
            this.OKbutton2.Text = "OK";
            this.OKbutton2.UseVisualStyleBackColor = true;
            // 
            // DetaljiKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 332);
            this.Controls.Add(this.OKbutton2);
            this.Controls.Add(this.RazredComboBox);
            this.Controls.Add(this.BrojPrimjeraka);
            this.Controls.Add(this.brojdanaBR);
            this.Controls.Add(this.GodinaIzdanja);
            this.Controls.Add(this.PREZIMEtextbox);
            this.Controls.Add(this.IMEtextbox);
            this.Controls.Add(this.Naslov);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.OIBtextbox);
            this.Controls.Add(this.ISBN);
            this.Name = "DetaljiKnjige";
            this.Text = "DetaljiKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.brojdanaBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PREZIMEtextbox;
        private System.Windows.Forms.TextBox IMEtextbox;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox OIBtextbox;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label GodinaIzdanja;
        private System.Windows.Forms.NumericUpDown brojdanaBR;
        private System.Windows.Forms.Label BrojPrimjeraka;
        private System.Windows.Forms.ComboBox RazredComboBox;
        private System.Windows.Forms.Button OKbutton2;
    }
}