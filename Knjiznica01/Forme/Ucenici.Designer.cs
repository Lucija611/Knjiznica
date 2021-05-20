
namespace Knjiznica01
{
    partial class Ucenici
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
            this.Ucenici1 = new System.Windows.Forms.Label();
            this.textBoxUcenici = new System.Windows.Forms.TextBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.BrisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ucenici1
            // 
            this.Ucenici1.AutoSize = true;
            this.Ucenici1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ucenici1.Location = new System.Drawing.Point(45, 30);
            this.Ucenici1.Name = "Ucenici1";
            this.Ucenici1.Size = new System.Drawing.Size(79, 28);
            this.Ucenici1.TabIndex = 1;
            this.Ucenici1.Text = "Učenici:";
            // 
            // textBoxUcenici
            // 
            this.textBoxUcenici.Location = new System.Drawing.Point(32, 88);
            this.textBoxUcenici.Multiline = true;
            this.textBoxUcenici.Name = "textBoxUcenici";
            this.textBoxUcenici.Size = new System.Drawing.Size(268, 234);
            this.textBoxUcenici.TabIndex = 6;
            // 
            // DodajButton
            // 
            this.DodajButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DodajButton.Location = new System.Drawing.Point(421, 88);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(114, 55);
            this.DodajButton.TabIndex = 7;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            // 
            // UrediButton
            // 
            this.UrediButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrediButton.Location = new System.Drawing.Point(421, 171);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(114, 55);
            this.UrediButton.TabIndex = 8;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            // 
            // BrisiButton
            // 
            this.BrisiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrisiButton.Location = new System.Drawing.Point(421, 267);
            this.BrisiButton.Name = "BrisiButton";
            this.BrisiButton.Size = new System.Drawing.Size(114, 55);
            this.BrisiButton.TabIndex = 9;
            this.BrisiButton.Text = "Briši";
            this.BrisiButton.UseVisualStyleBackColor = true;
            // 
            // Ucenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.BrisiButton);
            this.Controls.Add(this.UrediButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.textBoxUcenici);
            this.Controls.Add(this.Ucenici1);
            this.Name = "Ucenici";
            this.Text = "Ucenici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ucenici1;
        private System.Windows.Forms.TextBox textBoxUcenici;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.Button BrisiButton;
    }
}