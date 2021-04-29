
namespace Knjiznica01
{
    partial class DetaljiPosudbe
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
            this.Ucenik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Knjiga = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.datumPosudbe = new System.Windows.Forms.Label();
            this.brojDana = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.DatumPicker = new System.Windows.Forms.DateTimePicker();
            this.brojdanaBR = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.brojdanaBR)).BeginInit();
            this.SuspendLayout();
            // 
            // Ucenik
            // 
            this.Ucenik.AutoSize = true;
            this.Ucenik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ucenik.Location = new System.Drawing.Point(30, 21);
            this.Ucenik.Name = "Ucenik";
            this.Ucenik.Size = new System.Drawing.Size(75, 28);
            this.Ucenik.TabIndex = 0;
            this.Ucenik.Text = "Učenik:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 202);
            this.textBox1.TabIndex = 1;
            // 
            // Knjiga
            // 
            this.Knjiga.AutoSize = true;
            this.Knjiga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Knjiga.Location = new System.Drawing.Point(30, 290);
            this.Knjiga.Name = "Knjiga";
            this.Knjiga.Size = new System.Drawing.Size(71, 28);
            this.Knjiga.TabIndex = 2;
            this.Knjiga.Text = "Knjiga:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 321);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 202);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Branko Ćopić: Ježeva kućica";
            // 
            // datumPosudbe
            // 
            this.datumPosudbe.AutoSize = true;
            this.datumPosudbe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datumPosudbe.Location = new System.Drawing.Point(386, 48);
            this.datumPosudbe.Name = "datumPosudbe";
            this.datumPosudbe.Size = new System.Drawing.Size(157, 28);
            this.datumPosudbe.TabIndex = 4;
            this.datumPosudbe.Text = "Datum posudbe:";
            // 
            // brojDana
            // 
            this.brojDana.AutoSize = true;
            this.brojDana.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brojDana.Location = new System.Drawing.Point(386, 156);
            this.brojDana.Name = "brojDana";
            this.brojDana.Size = new System.Drawing.Size(99, 28);
            this.brojDana.TabIndex = 5;
            this.brojDana.Text = "Broj dana:";
            // 
            // OKbutton
            // 
            this.OKbutton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OKbutton.Location = new System.Drawing.Point(563, 207);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(98, 47);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // DatumPicker
            // 
            this.DatumPicker.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatumPicker.Location = new System.Drawing.Point(386, 79);
            this.DatumPicker.Name = "DatumPicker";
            this.DatumPicker.Size = new System.Drawing.Size(210, 32);
            this.DatumPicker.TabIndex = 7;
            // 
            // brojdanaBR
            // 
            this.brojdanaBR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brojdanaBR.Location = new System.Drawing.Point(386, 187);
            this.brojdanaBR.Name = "brojdanaBR";
            this.brojdanaBR.Size = new System.Drawing.Size(102, 32);
            this.brojdanaBR.TabIndex = 8;
            this.brojdanaBR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DetaljiPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 548);
            this.Controls.Add(this.brojdanaBR);
            this.Controls.Add(this.DatumPicker);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.brojDana);
            this.Controls.Add(this.datumPosudbe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Knjiga);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ucenik);
            this.Name = "DetaljiPosudbe";
            this.Text = "DetaljiPosudbe";
            ((System.ComponentModel.ISupportInitialize)(this.brojdanaBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ucenik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Knjiga;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label datumPosudbe;
        private System.Windows.Forms.Label brojDana;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.DateTimePicker DatumPicker;
        private System.Windows.Forms.NumericUpDown brojdanaBR;
    }
}