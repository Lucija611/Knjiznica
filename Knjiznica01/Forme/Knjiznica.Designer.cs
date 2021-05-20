
namespace Knjiznica01
{
    partial class Knjiznica
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
            this.ucenici = new System.Windows.Forms.Label();
            this.knjige = new System.Windows.Forms.Label();
            this.posudeneKnjige = new System.Windows.Forms.Label();
            this.UceniciButton = new System.Windows.Forms.Button();
            this.KnjigeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.posudiButton = new System.Windows.Forms.Button();
            this.izmijeniButton = new System.Windows.Forms.Button();
            this.vratiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucenici
            // 
            this.ucenici.AutoSize = true;
            this.ucenici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucenici.Location = new System.Drawing.Point(22, 9);
            this.ucenici.Name = "ucenici";
            this.ucenici.Size = new System.Drawing.Size(75, 28);
            this.ucenici.TabIndex = 0;
            this.ucenici.Text = "Učenici";
            this.ucenici.Click += new System.EventHandler(this.label1_Click);
            // 
            // knjige
            // 
            this.knjige.AutoSize = true;
            this.knjige.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knjige.Location = new System.Drawing.Point(123, 9);
            this.knjige.Name = "knjige";
            this.knjige.Size = new System.Drawing.Size(67, 28);
            this.knjige.TabIndex = 1;
            this.knjige.Text = "Knjige";
            // 
            // posudeneKnjige
            // 
            this.posudeneKnjige.AutoSize = true;
            this.posudeneKnjige.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.posudeneKnjige.Location = new System.Drawing.Point(22, 63);
            this.posudeneKnjige.Name = "posudeneKnjige";
            this.posudeneKnjige.Size = new System.Drawing.Size(154, 28);
            this.posudeneKnjige.TabIndex = 2;
            this.posudeneKnjige.Text = "Posuđene knjige";
            // 
            // UceniciButton
            // 
            this.UceniciButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UceniciButton.Location = new System.Drawing.Point(208, 58);
            this.UceniciButton.Name = "UceniciButton";
            this.UceniciButton.Size = new System.Drawing.Size(94, 39);
            this.UceniciButton.TabIndex = 3;
            this.UceniciButton.Text = "Učenici";
            this.UceniciButton.UseVisualStyleBackColor = true;
            // 
            // KnjigeButton
            // 
            this.KnjigeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KnjigeButton.Location = new System.Drawing.Point(322, 58);
            this.KnjigeButton.Name = "KnjigeButton";
            this.KnjigeButton.Size = new System.Drawing.Size(94, 39);
            this.KnjigeButton.TabIndex = 4;
            this.KnjigeButton.Text = "Knjige";
            this.KnjigeButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 289);
            this.textBox1.TabIndex = 5;
            // 
            // posudiButton
            // 
            this.posudiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.posudiButton.Location = new System.Drawing.Point(631, 108);
            this.posudiButton.Name = "posudiButton";
            this.posudiButton.Size = new System.Drawing.Size(114, 55);
            this.posudiButton.TabIndex = 6;
            this.posudiButton.Text = "Posudi";
            this.posudiButton.UseVisualStyleBackColor = true;
            // 
            // izmijeniButton
            // 
            this.izmijeniButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.izmijeniButton.Location = new System.Drawing.Point(631, 169);
            this.izmijeniButton.Name = "izmijeniButton";
            this.izmijeniButton.Size = new System.Drawing.Size(114, 55);
            this.izmijeniButton.TabIndex = 7;
            this.izmijeniButton.Text = "Izmijeni";
            this.izmijeniButton.UseVisualStyleBackColor = true;
            // 
            // vratiButton
            // 
            this.vratiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vratiButton.Location = new System.Drawing.Point(631, 262);
            this.vratiButton.Name = "vratiButton";
            this.vratiButton.Size = new System.Drawing.Size(114, 55);
            this.vratiButton.TabIndex = 8;
            this.vratiButton.Text = "Vrati";
            this.vratiButton.UseVisualStyleBackColor = true;
            // 
            // Knjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.vratiButton);
            this.Controls.Add(this.izmijeniButton);
            this.Controls.Add(this.posudiButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KnjigeButton);
            this.Controls.Add(this.UceniciButton);
            this.Controls.Add(this.posudeneKnjige);
            this.Controls.Add(this.knjige);
            this.Controls.Add(this.ucenici);
            this.Name = "Knjiznica";
            this.Text = "Knjiznica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucenici;
        private System.Windows.Forms.Label knjige;
        private System.Windows.Forms.Label posudeneKnjige;
        private System.Windows.Forms.Button UceniciButton;
        private System.Windows.Forms.Button KnjigeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button posudiButton;
        private System.Windows.Forms.Button izmijeniButton;
        private System.Windows.Forms.Button vratiButton;
    }
}